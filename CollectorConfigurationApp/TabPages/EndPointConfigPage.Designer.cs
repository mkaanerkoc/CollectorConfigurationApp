namespace CollectorConfigurationApp.TabPages
{
    partial class EndPointConfigPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeOutTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.retryCountTb = new System.Windows.Forms.TextBox();
            this.cihazIdTb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.utcTimeZoneTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getTimeZoneBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.setTimeZoneBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.getLoraTxPowerBtn = new System.Windows.Forms.Button();
            this.getLoraConfigurationsBtn = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.setLoraConfigurationsBtn = new System.Windows.Forms.Button();
            this.devSpreadingFactorCb = new System.Windows.Forms.ComboBox();
            this.devCodingRateCb = new System.Windows.Forms.ComboBox();
            this.devBandwidthCb = new System.Windows.Forms.ComboBox();
            this.devFreqTb = new System.Windows.Forms.TextBox();
            this.devTxPowerTb = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.devLongtitudeTb = new System.Windows.Forms.TextBox();
            this.getDevicePositionBtn = new System.Windows.Forms.Button();
            this.setDevicePositionBtn = new System.Windows.Forms.Button();
            this.getDeviceRadiusBtn = new System.Windows.Forms.Button();
            this.setDeviceRadiusBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.devLatitudeTb = new System.Windows.Forms.TextBox();
            this.devRadiusTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeOutTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.retryCountTb);
            this.groupBox1.Controls.Add(this.cihazIdTb);
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uzak Cihaz Bilgileri";
            // 
            // timeOutTb
            // 
            this.timeOutTb.Location = new System.Drawing.Point(168, 46);
            this.timeOutTb.Name = "timeOutTb";
            this.timeOutTb.Size = new System.Drawing.Size(100, 22);
            this.timeOutTb.TabIndex = 5;
            this.timeOutTb.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tekrar Deneme Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaman Aşımı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cihaz ID";
            // 
            // retryCountTb
            // 
            this.retryCountTb.Location = new System.Drawing.Point(341, 46);
            this.retryCountTb.Name = "retryCountTb";
            this.retryCountTb.Size = new System.Drawing.Size(52, 22);
            this.retryCountTb.TabIndex = 2;
            this.retryCountTb.Text = "3";
            // 
            // cihazIdTb
            // 
            this.cihazIdTb.Location = new System.Drawing.Point(22, 46);
            this.cihazIdTb.Name = "cihazIdTb";
            this.cihazIdTb.Size = new System.Drawing.Size(100, 22);
            this.cihazIdTb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.utcTimeZoneTb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.getTimeZoneBtn);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.setTimeZoneBtn);
            this.groupBox2.Location = new System.Drawing.Point(14, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saat / Tarih";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 48;
            // 
            // utcTimeZoneTb
            // 
            this.utcTimeZoneTb.Location = new System.Drawing.Point(168, 66);
            this.utcTimeZoneTb.Name = "utcTimeZoneTb";
            this.utcTimeZoneTb.Size = new System.Drawing.Size(100, 22);
            this.utcTimeZoneTb.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "TimeZone";
            // 
            // getTimeZoneBtn
            // 
            this.getTimeZoneBtn.Location = new System.Drawing.Point(366, 59);
            this.getTimeZoneBtn.Name = "getTimeZoneBtn";
            this.getTimeZoneBtn.Size = new System.Drawing.Size(75, 36);
            this.getTimeZoneBtn.TabIndex = 47;
            this.getTimeZoneBtn.Text = "Getir";
            this.getTimeZoneBtn.UseVisualStyleBackColor = true;
            this.getTimeZoneBtn.Click += new System.EventHandler(this.getTimeZoneBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 46;
            this.button2.Text = "Getir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 44;
            this.button4.Text = "Kaydet";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // setTimeZoneBtn
            // 
            this.setTimeZoneBtn.Location = new System.Drawing.Point(285, 59);
            this.setTimeZoneBtn.Name = "setTimeZoneBtn";
            this.setTimeZoneBtn.Size = new System.Drawing.Size(75, 36);
            this.setTimeZoneBtn.TabIndex = 45;
            this.setTimeZoneBtn.Text = "Kaydet";
            this.setTimeZoneBtn.UseVisualStyleBackColor = true;
            this.setTimeZoneBtn.Click += new System.EventHandler(this.setTimeZoneBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.getLoraTxPowerBtn);
            this.groupBox3.Controls.Add(this.getLoraConfigurationsBtn);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.setLoraConfigurationsBtn);
            this.groupBox3.Controls.Add(this.devSpreadingFactorCb);
            this.groupBox3.Controls.Add(this.devCodingRateCb);
            this.groupBox3.Controls.Add(this.devBandwidthCb);
            this.groupBox3.Controls.Add(this.devFreqTb);
            this.groupBox3.Controls.Add(this.devTxPowerTb);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Location = new System.Drawing.Point(14, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 201);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LoRa Ayarları";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(366, 58);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 36);
            this.button14.TabIndex = 43;
            this.button14.Text = "Getir";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // getLoraTxPowerBtn
            // 
            this.getLoraTxPowerBtn.Location = new System.Drawing.Point(366, 16);
            this.getLoraTxPowerBtn.Name = "getLoraTxPowerBtn";
            this.getLoraTxPowerBtn.Size = new System.Drawing.Size(75, 36);
            this.getLoraTxPowerBtn.TabIndex = 42;
            this.getLoraTxPowerBtn.Text = "Getir";
            this.getLoraTxPowerBtn.UseVisualStyleBackColor = true;
            // 
            // getLoraConfigurationsBtn
            // 
            this.getLoraConfigurationsBtn.Location = new System.Drawing.Point(366, 98);
            this.getLoraConfigurationsBtn.Name = "getLoraConfigurationsBtn";
            this.getLoraConfigurationsBtn.Size = new System.Drawing.Size(75, 90);
            this.getLoraConfigurationsBtn.TabIndex = 41;
            this.getLoraConfigurationsBtn.Text = "Getir";
            this.getLoraConfigurationsBtn.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(285, 58);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 36);
            this.button13.TabIndex = 40;
            this.button13.Text = "Kaydet";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(285, 16);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 36);
            this.button12.TabIndex = 39;
            this.button12.Text = "Kaydet";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // setLoraConfigurationsBtn
            // 
            this.setLoraConfigurationsBtn.Location = new System.Drawing.Point(285, 98);
            this.setLoraConfigurationsBtn.Name = "setLoraConfigurationsBtn";
            this.setLoraConfigurationsBtn.Size = new System.Drawing.Size(75, 90);
            this.setLoraConfigurationsBtn.TabIndex = 38;
            this.setLoraConfigurationsBtn.Text = "Kaydet";
            this.setLoraConfigurationsBtn.UseVisualStyleBackColor = true;
            // 
            // devSpreadingFactorCb
            // 
            this.devSpreadingFactorCb.FormattingEnabled = true;
            this.devSpreadingFactorCb.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096"});
            this.devSpreadingFactorCb.Location = new System.Drawing.Point(169, 164);
            this.devSpreadingFactorCb.Name = "devSpreadingFactorCb";
            this.devSpreadingFactorCb.Size = new System.Drawing.Size(100, 24);
            this.devSpreadingFactorCb.TabIndex = 37;
            // 
            // devCodingRateCb
            // 
            this.devCodingRateCb.FormattingEnabled = true;
            this.devCodingRateCb.Items.AddRange(new object[] {
            "4/5",
            "4/6",
            "4/7",
            "4/8"});
            this.devCodingRateCb.Location = new System.Drawing.Point(169, 132);
            this.devCodingRateCb.Name = "devCodingRateCb";
            this.devCodingRateCb.Size = new System.Drawing.Size(100, 24);
            this.devCodingRateCb.TabIndex = 36;
            // 
            // devBandwidthCb
            // 
            this.devBandwidthCb.FormattingEnabled = true;
            this.devBandwidthCb.Items.AddRange(new object[] {
            "125 Khz",
            "250 Khz",
            "500 Khz"});
            this.devBandwidthCb.Location = new System.Drawing.Point(169, 98);
            this.devBandwidthCb.Name = "devBandwidthCb";
            this.devBandwidthCb.Size = new System.Drawing.Size(100, 24);
            this.devBandwidthCb.TabIndex = 35;
            // 
            // devFreqTb
            // 
            this.devFreqTb.Location = new System.Drawing.Point(169, 65);
            this.devFreqTb.Name = "devFreqTb";
            this.devFreqTb.Size = new System.Drawing.Size(100, 22);
            this.devFreqTb.TabIndex = 34;
            // 
            // devTxPowerTb
            // 
            this.devTxPowerTb.Location = new System.Drawing.Point(169, 23);
            this.devTxPowerTb.Name = "devTxPowerTb";
            this.devTxPowerTb.Size = new System.Drawing.Size(100, 22);
            this.devTxPowerTb.TabIndex = 33;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(29, 164);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(125, 17);
            this.label33.TabIndex = 32;
            this.label33.Text = "Spreading Factor: ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(52, 134);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(98, 17);
            this.label32.TabIndex = 31;
            this.label32.Text = "Coding Rate : ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(62, 101);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 17);
            this.label31.TabIndex = 30;
            this.label31.Text = "Bandwidth : ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(83, 68);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 17);
            this.label28.TabIndex = 29;
            this.label28.Text = "Frekans : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(78, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 17);
            this.label27.TabIndex = 28;
            this.label27.Text = "TX Gücü : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.devRadiusTb);
            this.groupBox4.Controls.Add(this.devLatitudeTb);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.getDeviceRadiusBtn);
            this.groupBox4.Controls.Add(this.setDeviceRadiusBtn);
            this.groupBox4.Controls.Add(this.getDevicePositionBtn);
            this.groupBox4.Controls.Add(this.setDevicePositionBtn);
            this.groupBox4.Controls.Add(this.devLongtitudeTb);
            this.groupBox4.Location = new System.Drawing.Point(14, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(578, 134);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Konum Ayarları";
            // 
            // devLongtitudeTb
            // 
            this.devLongtitudeTb.Location = new System.Drawing.Point(168, 23);
            this.devLongtitudeTb.Name = "devLongtitudeTb";
            this.devLongtitudeTb.Size = new System.Drawing.Size(100, 22);
            this.devLongtitudeTb.TabIndex = 0;
            // 
            // getDevicePositionBtn
            // 
            this.getDevicePositionBtn.Location = new System.Drawing.Point(366, 16);
            this.getDevicePositionBtn.Name = "getDevicePositionBtn";
            this.getDevicePositionBtn.Size = new System.Drawing.Size(75, 67);
            this.getDevicePositionBtn.TabIndex = 52;
            this.getDevicePositionBtn.Text = "Getir";
            this.getDevicePositionBtn.UseVisualStyleBackColor = true;
            this.getDevicePositionBtn.Click += new System.EventHandler(this.getDevicePositionBtn_Click);
            // 
            // setDevicePositionBtn
            // 
            this.setDevicePositionBtn.Location = new System.Drawing.Point(285, 16);
            this.setDevicePositionBtn.Name = "setDevicePositionBtn";
            this.setDevicePositionBtn.Size = new System.Drawing.Size(75, 67);
            this.setDevicePositionBtn.TabIndex = 50;
            this.setDevicePositionBtn.Text = "Kaydet";
            this.setDevicePositionBtn.UseVisualStyleBackColor = true;
            this.setDevicePositionBtn.Click += new System.EventHandler(this.setDevicePositionBtn_Click);
            // 
            // getDeviceRadiusBtn
            // 
            this.getDeviceRadiusBtn.Location = new System.Drawing.Point(366, 92);
            this.getDeviceRadiusBtn.Name = "getDeviceRadiusBtn";
            this.getDeviceRadiusBtn.Size = new System.Drawing.Size(75, 36);
            this.getDeviceRadiusBtn.TabIndex = 56;
            this.getDeviceRadiusBtn.Text = "Getir";
            this.getDeviceRadiusBtn.UseVisualStyleBackColor = true;
            this.getDeviceRadiusBtn.Click += new System.EventHandler(this.getDeviceRadiusBtn_Click);
            // 
            // setDeviceRadiusBtn
            // 
            this.setDeviceRadiusBtn.Location = new System.Drawing.Point(285, 92);
            this.setDeviceRadiusBtn.Name = "setDeviceRadiusBtn";
            this.setDeviceRadiusBtn.Size = new System.Drawing.Size(75, 36);
            this.setDeviceRadiusBtn.TabIndex = 55;
            this.setDeviceRadiusBtn.Text = "Kaydet";
            this.setDeviceRadiusBtn.UseVisualStyleBackColor = true;
            this.setDeviceRadiusBtn.Click += new System.EventHandler(this.setDeviceRadiusBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Cihaz Longtitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Cihaz Latitude";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Cihaz Yarıçapı ( metre )";
            // 
            // devLatitudeTb
            // 
            this.devLatitudeTb.Location = new System.Drawing.Point(168, 59);
            this.devLatitudeTb.Name = "devLatitudeTb";
            this.devLatitudeTb.Size = new System.Drawing.Size(100, 22);
            this.devLatitudeTb.TabIndex = 50;
            // 
            // devRadiusTb
            // 
            this.devRadiusTb.Location = new System.Drawing.Point(169, 101);
            this.devRadiusTb.Name = "devRadiusTb";
            this.devRadiusTb.Size = new System.Drawing.Size(100, 22);
            this.devRadiusTb.TabIndex = 60;
            // 
            // EndPointConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EndPointConfigPage";
            this.Size = new System.Drawing.Size(1125, 550);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox timeOutTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox retryCountTb;
        private System.Windows.Forms.TextBox cihazIdTb;
        private System.Windows.Forms.Button getTimeZoneBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button setTimeZoneBtn;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button getLoraTxPowerBtn;
        private System.Windows.Forms.Button getLoraConfigurationsBtn;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button setLoraConfigurationsBtn;
        private System.Windows.Forms.ComboBox devSpreadingFactorCb;
        private System.Windows.Forms.ComboBox devCodingRateCb;
        private System.Windows.Forms.ComboBox devBandwidthCb;
        private System.Windows.Forms.TextBox devFreqTb;
        private System.Windows.Forms.TextBox devTxPowerTb;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox utcTimeZoneTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button getDevicePositionBtn;
        private System.Windows.Forms.Button setDevicePositionBtn;
        private System.Windows.Forms.TextBox devLongtitudeTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getDeviceRadiusBtn;
        private System.Windows.Forms.Button setDeviceRadiusBtn;
        private System.Windows.Forms.TextBox devRadiusTb;
        private System.Windows.Forms.TextBox devLatitudeTb;
    }
}
