﻿namespace TimeChanger
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker_manual = new System.Windows.Forms.DateTimePicker();
            this.textBox_hour = new System.Windows.Forms.TextBox();
            this.textBox_minute = new System.Windows.Forms.TextBox();
            this.label_hour = new System.Windows.Forms.Label();
            this.label_minute = new System.Windows.Forms.Label();
            this.label_dots = new System.Windows.Forms.Label();
            this.groupBox_manual = new System.Windows.Forms.GroupBox();
            this.button_setTime_manually = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_summertime = new System.Windows.Forms.CheckBox();
            this.button_saveNTP = new System.Windows.Forms.Button();
            this.textBox_ntpServerUrl = new System.Windows.Forms.TextBox();
            this.button_setTime_automatically = new System.Windows.Forms.Button();
            this.button_showNTPSetting = new System.Windows.Forms.Button();
            this.label_currentTime = new System.Windows.Forms.Label();
            this.button_getTimeFromWeb = new System.Windows.Forms.Button();
            this.label_footer = new System.Windows.Forms.Label();
            this.label_timezone = new System.Windows.Forms.Label();
            this.groupBox_manual.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_manual
            // 
            this.dateTimePicker_manual.CalendarFont = new System.Drawing.Font("Britannic Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_manual.Location = new System.Drawing.Point(38, 78);
            this.dateTimePicker_manual.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_manual.Name = "dateTimePicker_manual";
            this.dateTimePicker_manual.Size = new System.Drawing.Size(481, 39);
            this.dateTimePicker_manual.TabIndex = 20;
            // 
            // textBox_hour
            // 
            this.textBox_hour.Location = new System.Drawing.Point(568, 78);
            this.textBox_hour.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hour.MaxLength = 2;
            this.textBox_hour.Name = "textBox_hour";
            this.textBox_hour.Size = new System.Drawing.Size(55, 39);
            this.textBox_hour.TabIndex = 0;
            this.textBox_hour.TextChanged += new System.EventHandler(this.textBox_hour_TextChanged);
            // 
            // textBox_minute
            // 
            this.textBox_minute.Location = new System.Drawing.Point(688, 78);
            this.textBox_minute.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_minute.MaxLength = 2;
            this.textBox_minute.Name = "textBox_minute";
            this.textBox_minute.Size = new System.Drawing.Size(55, 39);
            this.textBox_minute.TabIndex = 2;
            this.textBox_minute.TextChanged += new System.EventHandler(this.textBox_minute_TextChanged);
            // 
            // label_hour
            // 
            this.label_hour.AutoSize = true;
            this.label_hour.Location = new System.Drawing.Point(579, 39);
            this.label_hour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hour.Name = "label_hour";
            this.label_hour.Size = new System.Drawing.Size(29, 31);
            this.label_hour.TabIndex = 3;
            this.label_hour.Text = "h";
            // 
            // label_minute
            // 
            this.label_minute.AutoSize = true;
            this.label_minute.Location = new System.Drawing.Point(697, 39);
            this.label_minute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_minute.Name = "label_minute";
            this.label_minute.Size = new System.Drawing.Size(36, 31);
            this.label_minute.TabIndex = 4;
            this.label_minute.Text = "m";
            // 
            // label_dots
            // 
            this.label_dots.AutoSize = true;
            this.label_dots.Location = new System.Drawing.Point(649, 83);
            this.label_dots.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dots.Name = "label_dots";
            this.label_dots.Size = new System.Drawing.Size(20, 31);
            this.label_dots.TabIndex = 5;
            this.label_dots.Text = ":";
            // 
            // groupBox_manual
            // 
            this.groupBox_manual.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox_manual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_manual.Controls.Add(this.button_setTime_manually);
            this.groupBox_manual.Controls.Add(this.label_dots);
            this.groupBox_manual.Controls.Add(this.label_minute);
            this.groupBox_manual.Controls.Add(this.label_hour);
            this.groupBox_manual.Controls.Add(this.textBox_minute);
            this.groupBox_manual.Controls.Add(this.textBox_hour);
            this.groupBox_manual.Controls.Add(this.dateTimePicker_manual);
            this.groupBox_manual.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_manual.Location = new System.Drawing.Point(20, 20);
            this.groupBox_manual.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_manual.Name = "groupBox_manual";
            this.groupBox_manual.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_manual.Size = new System.Drawing.Size(1208, 209);
            this.groupBox_manual.TabIndex = 6;
            this.groupBox_manual.TabStop = false;
            this.groupBox_manual.Text = "Set time manually";
            // 
            // button_setTime_manually
            // 
            this.button_setTime_manually.Enabled = false;
            this.button_setTime_manually.Location = new System.Drawing.Point(953, 65);
            this.button_setTime_manually.Margin = new System.Windows.Forms.Padding(6);
            this.button_setTime_manually.Name = "button_setTime_manually";
            this.button_setTime_manually.Size = new System.Drawing.Size(170, 81);
            this.button_setTime_manually.TabIndex = 10;
            this.button_setTime_manually.Text = "Set Time";
            this.button_setTime_manually.UseVisualStyleBackColor = true;
            this.button_setTime_manually.Click += new System.EventHandler(this.button_setTime_manually_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.checkBox_summertime);
            this.groupBox1.Controls.Add(this.button_saveNTP);
            this.groupBox1.Controls.Add(this.textBox_ntpServerUrl);
            this.groupBox1.Controls.Add(this.button_setTime_automatically);
            this.groupBox1.Controls.Add(this.button_showNTPSetting);
            this.groupBox1.Controls.Add(this.label_currentTime);
            this.groupBox1.Controls.Add(this.button_getTimeFromWeb);
            this.groupBox1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 266);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1208, 246);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set time automatically";
            // 
            // checkBox_summertime
            // 
            this.checkBox_summertime.AutoSize = true;
            this.checkBox_summertime.Location = new System.Drawing.Point(953, 155);
            this.checkBox_summertime.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_summertime.Name = "checkBox_summertime";
            this.checkBox_summertime.Size = new System.Drawing.Size(187, 35);
            this.checkBox_summertime.TabIndex = 12;
            this.checkBox_summertime.Text = "Summertime";
            this.checkBox_summertime.UseVisualStyleBackColor = true;
            this.checkBox_summertime.CheckedChanged += new System.EventHandler(this.checkBox_summertime_CheckedChanged);
            // 
            // button_saveNTP
            // 
            this.button_saveNTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveNTP.Location = new System.Drawing.Point(544, 170);
            this.button_saveNTP.Margin = new System.Windows.Forms.Padding(6);
            this.button_saveNTP.Name = "button_saveNTP";
            this.button_saveNTP.Size = new System.Drawing.Size(106, 42);
            this.button_saveNTP.TabIndex = 11;
            this.button_saveNTP.Text = "Save";
            this.button_saveNTP.UseVisualStyleBackColor = true;
            this.button_saveNTP.Visible = false;
            this.button_saveNTP.Click += new System.EventHandler(this.button_saveNTP_Click);
            // 
            // textBox_ntpServerUrl
            // 
            this.textBox_ntpServerUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ntpServerUrl.Location = new System.Drawing.Point(277, 172);
            this.textBox_ntpServerUrl.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ntpServerUrl.MaxLength = 70;
            this.textBox_ntpServerUrl.Name = "textBox_ntpServerUrl";
            this.textBox_ntpServerUrl.Size = new System.Drawing.Size(255, 33);
            this.textBox_ntpServerUrl.TabIndex = 10;
            this.textBox_ntpServerUrl.Visible = false;
            // 
            // button_setTime_automatically
            // 
            this.button_setTime_automatically.Enabled = false;
            this.button_setTime_automatically.Location = new System.Drawing.Point(953, 65);
            this.button_setTime_automatically.Margin = new System.Windows.Forms.Padding(6);
            this.button_setTime_automatically.Name = "button_setTime_automatically";
            this.button_setTime_automatically.Size = new System.Drawing.Size(170, 81);
            this.button_setTime_automatically.TabIndex = 9;
            this.button_setTime_automatically.Text = "Set Time";
            this.button_setTime_automatically.UseVisualStyleBackColor = true;
            this.button_setTime_automatically.Click += new System.EventHandler(this.button_setTime_automatically_Click);
            // 
            // button_showNTPSetting
            // 
            this.button_showNTPSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showNTPSetting.Location = new System.Drawing.Point(38, 170);
            this.button_showNTPSetting.Margin = new System.Windows.Forms.Padding(6);
            this.button_showNTPSetting.Name = "button_showNTPSetting";
            this.button_showNTPSetting.Size = new System.Drawing.Size(229, 42);
            this.button_showNTPSetting.TabIndex = 9;
            this.button_showNTPSetting.Text = "NTP-Server >>";
            this.button_showNTPSetting.UseVisualStyleBackColor = true;
            this.button_showNTPSetting.Click += new System.EventHandler(this.button_showNTPSetting_Click);
            // 
            // label_currentTime
            // 
            this.label_currentTime.AutoSize = true;
            this.label_currentTime.Font = new System.Drawing.Font("Britannic Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentTime.Location = new System.Drawing.Point(414, 84);
            this.label_currentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_currentTime.Name = "label_currentTime";
            this.label_currentTime.Size = new System.Drawing.Size(47, 37);
            this.label_currentTime.TabIndex = 8;
            this.label_currentTime.Text = "...";
            // 
            // button_getTimeFromWeb
            // 
            this.button_getTimeFromWeb.Location = new System.Drawing.Point(38, 65);
            this.button_getTimeFromWeb.Margin = new System.Windows.Forms.Padding(4);
            this.button_getTimeFromWeb.Name = "button_getTimeFromWeb";
            this.button_getTimeFromWeb.Size = new System.Drawing.Size(341, 81);
            this.button_getTimeFromWeb.TabIndex = 0;
            this.button_getTimeFromWeb.Text = "Get Time From Web";
            this.button_getTimeFromWeb.UseVisualStyleBackColor = true;
            this.button_getTimeFromWeb.Click += new System.EventHandler(this.button_getTimeFromWeb_Click);
            // 
            // label_footer
            // 
            this.label_footer.AutoSize = true;
            this.label_footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_footer.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_footer.Location = new System.Drawing.Point(390, 541);
            this.label_footer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_footer.Name = "label_footer";
            this.label_footer.Size = new System.Drawing.Size(442, 29);
            this.label_footer.TabIndex = 8;
            this.label_footer.Text = "It is time to change, it is a change of time";
            // 
            // label_timezone
            // 
            this.label_timezone.AutoSize = true;
            this.label_timezone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timezone.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_timezone.Location = new System.Drawing.Point(15, 541);
            this.label_timezone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timezone.Name = "label_timezone";
            this.label_timezone.Size = new System.Drawing.Size(31, 29);
            this.label_timezone.TabIndex = 9;
            this.label_timezone.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1248, 579);
            this.Controls.Add(this.label_timezone);
            this.Controls.Add(this.label_footer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_manual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1243, 566);
            this.Name = "Form1";
            this.Text = "TimeChanger 1.0";
            this.groupBox_manual.ResumeLayout(false);
            this.groupBox_manual.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_manual;
        private System.Windows.Forms.TextBox textBox_hour;
        private System.Windows.Forms.TextBox textBox_minute;
        private System.Windows.Forms.Label label_hour;
        private System.Windows.Forms.Label label_minute;
        private System.Windows.Forms.Label label_dots;
        private System.Windows.Forms.GroupBox groupBox_manual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_getTimeFromWeb;
        private System.Windows.Forms.Label label_currentTime;
        private System.Windows.Forms.Button button_setTime_manually;
        private System.Windows.Forms.Button button_setTime_automatically;
        private System.Windows.Forms.Label label_footer;
        private System.Windows.Forms.Button button_showNTPSetting;
        private System.Windows.Forms.TextBox textBox_ntpServerUrl;
        private System.Windows.Forms.Button button_saveNTP;
        private System.Windows.Forms.CheckBox checkBox_summertime;
        private System.Windows.Forms.Label label_timezone;
    }
}

