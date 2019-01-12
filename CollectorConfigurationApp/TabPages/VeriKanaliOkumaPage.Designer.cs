namespace CollectorConfigurationApp.TabPages
{
    partial class VeriKanaliOkumaPage
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
            this.channelResponseListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destinationUnitTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.responseReceiveTimeLabel = new System.Windows.Forms.Label();
            this.signalRssiLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clearReceivedResponseBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timeoutInMilisTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msgRetryCountTb = new System.Windows.Forms.TextBox();
            this.SendResponseBtn = new System.Windows.Forms.Button();
            this.channelsToReadCbList = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // channelResponseListView
            // 
            this.channelResponseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.channelResponseListView.FullRowSelect = true;
            this.channelResponseListView.GridLines = true;
            this.channelResponseListView.Location = new System.Drawing.Point(28, 129);
            this.channelResponseListView.Name = "channelResponseListView";
            this.channelResponseListView.Size = new System.Drawing.Size(492, 241);
            this.channelResponseListView.TabIndex = 1;
            this.channelResponseListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kanal Türü";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Değer";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 90;
            // 
            // destinationUnitTb
            // 
            this.destinationUnitTb.Location = new System.Drawing.Point(233, 26);
            this.destinationUnitTb.Name = "destinationUnitTb";
            this.destinationUnitTb.Size = new System.Drawing.Size(137, 22);
            this.destinationUnitTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veri Kanalları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hedef Cihaz ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kanal Verileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sinyal Gücü : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.responseReceiveTimeLabel);
            this.groupBox1.Controls.Add(this.signalRssiLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.clearReceivedResponseBtn);
            this.groupBox1.Controls.Add(this.channelResponseListView);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(588, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 491);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelen Yanıt ";
            // 
            // responseReceiveTimeLabel
            // 
            this.responseReceiveTimeLabel.AutoSize = true;
            this.responseReceiveTimeLabel.Location = new System.Drawing.Point(158, 53);
            this.responseReceiveTimeLabel.Name = "responseReceiveTimeLabel";
            this.responseReceiveTimeLabel.Size = new System.Drawing.Size(23, 17);
            this.responseReceiveTimeLabel.TabIndex = 10;
            this.responseReceiveTimeLabel.Text = "---";
            // 
            // signalRssiLabel
            // 
            this.signalRssiLabel.AutoSize = true;
            this.signalRssiLabel.Location = new System.Drawing.Point(158, 29);
            this.signalRssiLabel.Name = "signalRssiLabel";
            this.signalRssiLabel.Size = new System.Drawing.Size(23, 17);
            this.signalRssiLabel.TabIndex = 9;
            this.signalRssiLabel.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yanıt Zamanı :";
            // 
            // clearReceivedResponseBtn
            // 
            this.clearReceivedResponseBtn.Location = new System.Drawing.Point(227, 430);
            this.clearReceivedResponseBtn.Name = "clearReceivedResponseBtn";
            this.clearReceivedResponseBtn.Size = new System.Drawing.Size(151, 33);
            this.clearReceivedResponseBtn.TabIndex = 7;
            this.clearReceivedResponseBtn.Text = "Temizle";
            this.clearReceivedResponseBtn.UseVisualStyleBackColor = true;
            this.clearReceivedResponseBtn.Click += new System.EventHandler(this.clearReceivedResponseBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Zaman Aşımı Süresi ( ms )";
            // 
            // timeoutInMilisTb
            // 
            this.timeoutInMilisTb.Location = new System.Drawing.Point(233, 54);
            this.timeoutInMilisTb.Name = "timeoutInMilisTb";
            this.timeoutInMilisTb.Size = new System.Drawing.Size(137, 22);
            this.timeoutInMilisTb.TabIndex = 11;
            this.timeoutInMilisTb.Text = "500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mesaj Tekrarlama Sayısı";
            // 
            // msgRetryCountTb
            // 
            this.msgRetryCountTb.Location = new System.Drawing.Point(233, 82);
            this.msgRetryCountTb.Name = "msgRetryCountTb";
            this.msgRetryCountTb.Size = new System.Drawing.Size(137, 22);
            this.msgRetryCountTb.TabIndex = 13;
            this.msgRetryCountTb.Text = "3";
            // 
            // SendResponseBtn
            // 
            this.SendResponseBtn.Location = new System.Drawing.Point(114, 416);
            this.SendResponseBtn.Name = "SendResponseBtn";
            this.SendResponseBtn.Size = new System.Drawing.Size(150, 43);
            this.SendResponseBtn.TabIndex = 16;
            this.SendResponseBtn.Text = "Kanalları Oku";
            this.SendResponseBtn.UseVisualStyleBackColor = true;
            this.SendResponseBtn.Click += new System.EventHandler(this.SendResponseBtn_Click);
            // 
            // channelsToReadCbList
            // 
            this.channelsToReadCbList.CheckOnClick = true;
            this.channelsToReadCbList.FormattingEnabled = true;
            this.channelsToReadCbList.Location = new System.Drawing.Point(35, 219);
            this.channelsToReadCbList.Name = "channelsToReadCbList";
            this.channelsToReadCbList.Size = new System.Drawing.Size(315, 191);
            this.channelsToReadCbList.TabIndex = 17;
            // 
            // VeriKanaliOkumaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.channelsToReadCbList);
            this.Controls.Add(this.SendResponseBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msgRetryCountTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeoutInMilisTb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationUnitTb);
            this.Name = "VeriKanaliOkumaPage";
            this.Size = new System.Drawing.Size(1205, 623);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView channelResponseListView;
        private System.Windows.Forms.TextBox destinationUnitTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearReceivedResponseBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox timeoutInMilisTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox msgRetryCountTb;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button SendResponseBtn;
        private System.Windows.Forms.Label responseReceiveTimeLabel;
        private System.Windows.Forms.Label signalRssiLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox channelsToReadCbList;
    }
}
