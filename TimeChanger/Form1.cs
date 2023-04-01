using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeChanger
{
    

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME
    {
        public short wYear;
        public short wMonth;
        public short wDayOfWeek;
        public short wDay;
        public short wHour;
        public short wMinute;
        public short wSecond;
        public short wMilliseconds;
    }

    public partial class Form1 : Form
    {
        public DateTime systemTime;


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime(ref SYSTEMTIME st);

        public Form1()
        {
            InitializeComponent();
            textBox_ntpServerUrl.Text = Properties.Settings.Default.ntpServer;
            checkBox_summertime.Checked = Properties.Settings.Default.isSummertime;
        }

        public static DateTime GetNetworkTime()
        {
            //German-Standard = de.pool.ntp.org
            try 
            {
                //default timeserver saved in Settings of App
                string ntpServer = Properties.Settings.Default.ntpServer;

                // NTP message size - 16 bytes of the digest (RFC 2030)
                var ntpData = new byte[48];

                //Setting the Leap Indicator, Version Number and Mode values
                ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

                var addresses = Dns.GetHostEntry(ntpServer).AddressList;

                //The UDP port number assigned to NTP is 123
                var ipEndPoint = new IPEndPoint(addresses[0], 123);
                //NTP uses UDP

                using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
                {
                    socket.Connect(ipEndPoint);

                    //Stops code hang if NTP is blocked
                    socket.ReceiveTimeout = 3000;

                    socket.Send(ntpData);
                    socket.Receive(ntpData);
                    socket.Close();
                }

                //Offset to get to the "Transmit Timestamp" field (time at which the reply 
                //departed the server for the client, in 64-bit timestamp format."
                const byte serverReplyTime = 40;

                //Get the seconds part
                ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

                //Get the seconds fraction
                ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

                //Convert From big-endian to little-endian
                intPart = SwapEndianness(intPart);
                fractPart = SwapEndianness(fractPart);

                var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

                //**UTC** time
                var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Local)).AddMilliseconds((long)milliseconds);

                return networkDateTime;
            }
            catch 
            {
                DateTime placeholderDate = new DateTime(1986, 3, 8, 13, 5, 0);
                return placeholderDate;
            }
            
        }

        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        private void button_setTime_manually_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker_manual.Value;
            
            SYSTEMTIME st = new SYSTEMTIME();
            st.wYear = (Int16)dateTime.Year; 
            st.wMonth = (Int16)dateTime.Month;
            st.wDay = (Int16)dateTime.Day;
            st.wHour = (Int16)(Int32.Parse(textBox_hour.Text) - 1); //could be that this is related to the timezone 
            st.wMinute = Int16.Parse(textBox_minute.Text);
            st.wSecond = 0;

            SetSystemTime(ref st);
        }

        private void button_setTime_automatically_Click(object sender, EventArgs e)
        {
            SYSTEMTIME st = new SYSTEMTIME();

            // if its wintertime decrease value by 1
            int adjustHour = 0;
            if (!checkBox_summertime.Checked)
            {
                adjustHour = 1;
            }
            st.wYear = (Int16)systemTime.Year; 
            st.wMonth = (Int16)systemTime.Month;
            st.wDay = (Int16)systemTime.Day;
            st.wHour = (Int16)(systemTime.Hour - adjustHour);
            st.wMinute = (Int16)systemTime.Minute;
            st.wSecond = 0;

            SetSystemTime(ref st);
        }

        private void button_getTimeFromWeb_Click(object sender, EventArgs e)
        {
            DateTime dateTime = GetNetworkTime();
            DateTime placeholderDate = new DateTime(1986, 3, 8, 13, 5, 0);

            if (dateTime == placeholderDate)
            {
                button_setTime_automatically.Enabled = false;
                label_currentTime.Text = "NTP-Server not avaiable - \r\nIs there a internet connection?";
                return;
            }

            if (checkBox_summertime.Checked)
            {
                label_currentTime.Text = dateTime.AddHours(2).ToString();
                systemTime = dateTime.AddHours(2);
            }
            else
            {
                label_currentTime.Text = dateTime.AddHours(1).ToString();
                systemTime = dateTime.AddHours(1);
            }

            button_setTime_automatically.Enabled = true;
        }

        // HELPER - FUNCTIONS

        private bool isNumeric(TextBox textBox)
        {
            int parsedValue;
            if (!int.TryParse(textBox.Text, out parsedValue))
            {
                textBox.BackColor = Color.FromArgb(255, 102, 102);
                return false;
            }
            else
            {
                if(parsedValue < 0 || parsedValue > 23)
                {
                    textBox.BackColor = Color.FromArgb(255, 102, 102);
                    return false;
                }
            }

            textBox.BackColor = Color.FromArgb(140, 255, 102);
            return true;
        }

        private void textBox_hour_TextChanged(object sender, EventArgs e)
        {
            if(isNumeric(textBox_hour) && isNumeric(textBox_minute))
            {
                button_setTime_manually.Enabled = true;
            }
            else
            {
                button_setTime_manually.Enabled = false;
            }
        }

        private void textBox_minute_TextChanged(object sender, EventArgs e)
        {
            textBox_hour_TextChanged(sender, e);
        }

        private void button_showNTPSetting_Click(object sender, EventArgs e)
        {
            if(button_saveNTP.Visible)
            {
                button_saveNTP.Visible = false;
                textBox_ntpServerUrl.Visible = false;
                return;
            }

            button_saveNTP.Visible = true;
            textBox_ntpServerUrl.Visible = true;
        }

        private void button_saveNTP_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ntpServer = textBox_ntpServerUrl.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBox_summertime_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_summertime.Checked)
            {
                
            }

            Properties.Settings.Default.isSummertime = true;
            Properties.Settings.Default.Save();
        }
    }
}
