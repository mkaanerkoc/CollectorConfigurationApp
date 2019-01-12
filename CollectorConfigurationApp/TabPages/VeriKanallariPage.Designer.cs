namespace CollectorConfigurationApp.TabPages
{
    partial class VeriKanallariPage
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
            this.dataChannelListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNewChannel = new System.Windows.Forms.Button();
            this.removeChannelBtn = new System.Windows.Forms.Button();
            this.saveChannelBtn = new System.Windows.Forms.Button();
            this.channelTypeCb = new System.Windows.Forms.ComboBox();
            this.getAllDataChannelsBtn = new System.Windows.Forms.Button();
            this.setAllDataChannelsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataTypeCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uzakCihazIDTb = new System.Windows.Forms.TextBox();
            this.retryCountTb = new System.Windows.Forms.TextBox();
            this.readTimeoutTb = new System.Windows.Forms.TextBox();
            this.readPeriodTb = new System.Windows.Forms.TextBox();
            this.modbusRegisterTb = new System.Windows.Forms.TextBox();
            this.deviceChannelTypeCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dataChannelListView
            // 
            this.dataChannelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.dataChannelListView.FullRowSelect = true;
            this.dataChannelListView.GridLines = true;
            this.dataChannelListView.Location = new System.Drawing.Point(16, 17);
            this.dataChannelListView.MultiSelect = false;
            this.dataChannelListView.Name = "dataChannelListView";
            this.dataChannelListView.Size = new System.Drawing.Size(1084, 331);
            this.dataChannelListView.TabIndex = 0;
            this.dataChannelListView.UseCompatibleStateImageBehavior = false;
            this.dataChannelListView.SelectedIndexChanged += new System.EventHandler(this.dataChannelListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kanal ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Uzak Cihaz ID";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cihaz Kanal ID";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kanal Türü";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Veri Türü";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Okuma Periyodu";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Zaman Aşımı";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tekrar Sayısı";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Modbus Register";
            this.columnHeader9.Width = 130;
            // 
            // addNewChannel
            // 
            this.addNewChannel.Location = new System.Drawing.Point(767, 376);
            this.addNewChannel.Name = "addNewChannel";
            this.addNewChannel.Size = new System.Drawing.Size(100, 63);
            this.addNewChannel.TabIndex = 1;
            this.addNewChannel.Text = "Yeni Kanal Ekle";
            this.addNewChannel.UseVisualStyleBackColor = true;
            this.addNewChannel.Click += new System.EventHandler(this.addNewChannel_Click);
            // 
            // removeChannelBtn
            // 
            this.removeChannelBtn.Location = new System.Drawing.Point(982, 376);
            this.removeChannelBtn.Name = "removeChannelBtn";
            this.removeChannelBtn.Size = new System.Drawing.Size(95, 63);
            this.removeChannelBtn.TabIndex = 2;
            this.removeChannelBtn.Text = "Kanalı Kaldır";
            this.removeChannelBtn.UseVisualStyleBackColor = true;
            this.removeChannelBtn.Click += new System.EventHandler(this.removeChannelBtn_Click);
            // 
            // saveChannelBtn
            // 
            this.saveChannelBtn.Location = new System.Drawing.Point(873, 376);
            this.saveChannelBtn.Name = "saveChannelBtn";
            this.saveChannelBtn.Size = new System.Drawing.Size(103, 63);
            this.saveChannelBtn.TabIndex = 3;
            this.saveChannelBtn.Text = "Kanalı Kaydet";
            this.saveChannelBtn.UseVisualStyleBackColor = true;
            this.saveChannelBtn.Click += new System.EventHandler(this.saveChannelBtn_Click);
            // 
            // channelTypeCb
            // 
            this.channelTypeCb.FormattingEnabled = true;
            this.channelTypeCb.Location = new System.Drawing.Point(160, 420);
            this.channelTypeCb.Name = "channelTypeCb";
            this.channelTypeCb.Size = new System.Drawing.Size(206, 24);
            this.channelTypeCb.TabIndex = 7;
            // 
            // getAllDataChannelsBtn
            // 
            this.getAllDataChannelsBtn.Location = new System.Drawing.Point(767, 489);
            this.getAllDataChannelsBtn.Name = "getAllDataChannelsBtn";
            this.getAllDataChannelsBtn.Size = new System.Drawing.Size(165, 50);
            this.getAllDataChannelsBtn.TabIndex = 8;
            this.getAllDataChannelsBtn.Text = "Tüm Veri Kanallarını Getir";
            this.getAllDataChannelsBtn.UseVisualStyleBackColor = true;
            this.getAllDataChannelsBtn.Click += new System.EventHandler(this.getAllDataChannelsBtn_Click);
            // 
            // setAllDataChannelsBtn
            // 
            this.setAllDataChannelsBtn.Location = new System.Drawing.Point(938, 489);
            this.setAllDataChannelsBtn.Name = "setAllDataChannelsBtn";
            this.setAllDataChannelsBtn.Size = new System.Drawing.Size(170, 50);
            this.setAllDataChannelsBtn.TabIndex = 9;
            this.setAllDataChannelsBtn.Text = "Veri Kanallarını Kaydet";
            this.setAllDataChannelsBtn.UseVisualStyleBackColor = true;
            this.setAllDataChannelsBtn.Click += new System.EventHandler(this.setAllDataChannelsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Uzak Cihaz ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Uzak Cihaz Kanal ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kanal Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Okuma Periyodu ( sn ) ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Veri Türü";
            // 
            // dataTypeCb
            // 
            this.dataTypeCb.FormattingEnabled = true;
            this.dataTypeCb.Location = new System.Drawing.Point(160, 448);
            this.dataTypeCb.Name = "dataTypeCb";
            this.dataTypeCb.Size = new System.Drawing.Size(206, 24);
            this.dataTypeCb.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Okuma Zaman Aşımı ( ms )";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Modbus Register";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tekrar Sayısı ";
            // 
            // uzakCihazIDTb
            // 
            this.uzakCihazIDTb.Location = new System.Drawing.Point(160, 367);
            this.uzakCihazIDTb.Name = "uzakCihazIDTb";
            this.uzakCihazIDTb.Size = new System.Drawing.Size(122, 22);
            this.uzakCihazIDTb.TabIndex = 25;
            // 
            // retryCountTb
            // 
            this.retryCountTb.Location = new System.Drawing.Point(591, 421);
            this.retryCountTb.Name = "retryCountTb";
            this.retryCountTb.Size = new System.Drawing.Size(122, 22);
            this.retryCountTb.TabIndex = 29;
            // 
            // readTimeoutTb
            // 
            this.readTimeoutTb.Location = new System.Drawing.Point(591, 394);
            this.readTimeoutTb.Name = "readTimeoutTb";
            this.readTimeoutTb.Size = new System.Drawing.Size(122, 22);
            this.readTimeoutTb.TabIndex = 28;
            // 
            // readPeriodTb
            // 
            this.readPeriodTb.Location = new System.Drawing.Point(591, 367);
            this.readPeriodTb.Name = "readPeriodTb";
            this.readPeriodTb.Size = new System.Drawing.Size(122, 22);
            this.readPeriodTb.TabIndex = 27;
            // 
            // modbusRegisterTb
            // 
            this.modbusRegisterTb.Location = new System.Drawing.Point(591, 449);
            this.modbusRegisterTb.Name = "modbusRegisterTb";
            this.modbusRegisterTb.Size = new System.Drawing.Size(122, 22);
            this.modbusRegisterTb.TabIndex = 30;
            // 
            // deviceChannelTypeCb
            // 
            this.deviceChannelTypeCb.FormattingEnabled = true;
            this.deviceChannelTypeCb.Location = new System.Drawing.Point(160, 394);
            this.deviceChannelTypeCb.Name = "deviceChannelTypeCb";
            this.deviceChannelTypeCb.Size = new System.Drawing.Size(206, 24);
            this.deviceChannelTypeCb.TabIndex = 31;
            // 
            // VeriKanallariPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deviceChannelTypeCb);
            this.Controls.Add(this.modbusRegisterTb);
            this.Controls.Add(this.retryCountTb);
            this.Controls.Add(this.readTimeoutTb);
            this.Controls.Add(this.readPeriodTb);
            this.Controls.Add(this.uzakCihazIDTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataTypeCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setAllDataChannelsBtn);
            this.Controls.Add(this.getAllDataChannelsBtn);
            this.Controls.Add(this.channelTypeCb);
            this.Controls.Add(this.saveChannelBtn);
            this.Controls.Add(this.removeChannelBtn);
            this.Controls.Add(this.addNewChannel);
            this.Controls.Add(this.dataChannelListView);
            this.Name = "VeriKanallariPage";
            this.Size = new System.Drawing.Size(1125, 550);
            this.Load += new System.EventHandler(this.VeriKanallariPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dataChannelListView;
        private System.Windows.Forms.Button addNewChannel;
        private System.Windows.Forms.Button removeChannelBtn;
        private System.Windows.Forms.Button saveChannelBtn;
        private System.Windows.Forms.ComboBox channelTypeCb;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button getAllDataChannelsBtn;
        private System.Windows.Forms.Button setAllDataChannelsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dataTypeCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uzakCihazIDTb;
        private System.Windows.Forms.TextBox retryCountTb;
        private System.Windows.Forms.TextBox readTimeoutTb;
        private System.Windows.Forms.TextBox readPeriodTb;
        private System.Windows.Forms.TextBox modbusRegisterTb;
        private System.Windows.Forms.ComboBox deviceChannelTypeCb;
    }
}
