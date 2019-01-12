namespace CollectorConfigurationApp.TabPages
{
    partial class CihazTaramaPage
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
            this.components = new System.ComponentModel.Container();
            this.clearListBtn = new System.Windows.Forms.Button();
            this.startScanBtn = new System.Windows.Forms.Button();
            this.foundDevicesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.responseTimeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scanningProgresBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.syncClocksCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // clearListBtn
            // 
            this.clearListBtn.Location = new System.Drawing.Point(473, 415);
            this.clearListBtn.Name = "clearListBtn";
            this.clearListBtn.Size = new System.Drawing.Size(137, 43);
            this.clearListBtn.TabIndex = 5;
            this.clearListBtn.Text = "Listeyi Temizle";
            this.clearListBtn.UseVisualStyleBackColor = true;
            this.clearListBtn.Click += new System.EventHandler(this.clearListBtn_Click);
            // 
            // startScanBtn
            // 
            this.startScanBtn.Location = new System.Drawing.Point(329, 415);
            this.startScanBtn.Name = "startScanBtn";
            this.startScanBtn.Size = new System.Drawing.Size(138, 43);
            this.startScanBtn.TabIndex = 4;
            this.startScanBtn.Text = "Tarama Başlat";
            this.startScanBtn.UseVisualStyleBackColor = true;
            this.startScanBtn.Click += new System.EventHandler(this.startScanBtn_Click);
            // 
            // foundDevicesListView
            // 
            this.foundDevicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.foundDevicesListView.FullRowSelect = true;
            this.foundDevicesListView.GridLines = true;
            this.foundDevicesListView.Location = new System.Drawing.Point(40, 37);
            this.foundDevicesListView.Name = "foundDevicesListView";
            this.foundDevicesListView.Size = new System.Drawing.Size(830, 369);
            this.foundDevicesListView.TabIndex = 3;
            this.foundDevicesListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cihaz ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "RSSI ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cihaz Saat/Tarih";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cihaz Türü";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kanallar";
            this.columnHeader5.Width = 120;
            // 
            // responseTimeTb
            // 
            this.responseTimeTb.Location = new System.Drawing.Point(157, 421);
            this.responseTimeTb.Name = "responseTimeTb";
            this.responseTimeTb.Size = new System.Drawing.Size(100, 22);
            this.responseTimeTb.TabIndex = 6;
            this.responseTimeTb.Text = "5000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarama Süresi";
            // 
            // scanningProgresBar
            // 
            this.scanningProgresBar.Location = new System.Drawing.Point(219, 488);
            this.scanningProgresBar.Name = "scanningProgresBar";
            this.scanningProgresBar.Size = new System.Drawing.Size(151, 23);
            this.scanningProgresBar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Interval = 50;
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // syncClocksCb
            // 
            this.syncClocksCb.AutoSize = true;
            this.syncClocksCb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.syncClocksCb.Location = new System.Drawing.Point(50, 449);
            this.syncClocksCb.Name = "syncClocksCb";
            this.syncClocksCb.Size = new System.Drawing.Size(157, 21);
            this.syncClocksCb.TabIndex = 10;
            this.syncClocksCb.Text = "Saatleri Eş Zamanla";
            this.syncClocksCb.UseVisualStyleBackColor = true;
            // 
            // CihazTaramaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.syncClocksCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scanningProgresBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.responseTimeTb);
            this.Controls.Add(this.clearListBtn);
            this.Controls.Add(this.startScanBtn);
            this.Controls.Add(this.foundDevicesListView);
            this.Name = "CihazTaramaPage";
            this.Size = new System.Drawing.Size(925, 529);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearListBtn;
        private System.Windows.Forms.Button startScanBtn;
        private System.Windows.Forms.ListView foundDevicesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox responseTimeTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar scanningProgresBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer progressBarTimer;
        private System.Windows.Forms.CheckBox syncClocksCb;
    }
}
