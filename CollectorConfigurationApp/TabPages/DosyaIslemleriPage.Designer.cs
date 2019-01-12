namespace CollectorConfigurationApp.TabPages
{
    partial class DosyaIslemleriPage
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
            this.getLastWrittenBtn = new System.Windows.Forms.Button();
            this.getLastReadBtn = new System.Windows.Forms.Button();
            this.getFileInfosBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clearFileInfoList = new System.Windows.Forms.Button();
            this.destinationIdTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.responseTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getLastWrittenBtn
            // 
            this.getLastWrittenBtn.Location = new System.Drawing.Point(31, 68);
            this.getLastWrittenBtn.Name = "getLastWrittenBtn";
            this.getLastWrittenBtn.Size = new System.Drawing.Size(194, 39);
            this.getLastWrittenBtn.TabIndex = 0;
            this.getLastWrittenBtn.Text = "Son Kaydedileni Getir";
            this.getLastWrittenBtn.UseVisualStyleBackColor = true;
            this.getLastWrittenBtn.Click += new System.EventHandler(this.getLastWrittenBtn_Click);
            // 
            // getLastReadBtn
            // 
            this.getLastReadBtn.Location = new System.Drawing.Point(231, 68);
            this.getLastReadBtn.Name = "getLastReadBtn";
            this.getLastReadBtn.Size = new System.Drawing.Size(197, 39);
            this.getLastReadBtn.TabIndex = 1;
            this.getLastReadBtn.Text = "Son Okunanı Getir";
            this.getLastReadBtn.UseVisualStyleBackColor = true;
            // 
            // getFileInfosBtn
            // 
            this.getFileInfosBtn.Location = new System.Drawing.Point(664, 252);
            this.getFileInfosBtn.Name = "getFileInfosBtn";
            this.getFileInfosBtn.Size = new System.Drawing.Size(163, 36);
            this.getFileInfosBtn.TabIndex = 2;
            this.getFileInfosBtn.Text = "Dosya Listesini Getir";
            this.getFileInfosBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(664, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(254, 225);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // clearFileInfoList
            // 
            this.clearFileInfoList.Location = new System.Drawing.Point(833, 252);
            this.clearFileInfoList.Name = "clearFileInfoList";
            this.clearFileInfoList.Size = new System.Drawing.Size(85, 36);
            this.clearFileInfoList.TabIndex = 4;
            this.clearFileInfoList.Text = "Temizle";
            this.clearFileInfoList.UseVisualStyleBackColor = true;
            // 
            // destinationIdTb
            // 
            this.destinationIdTb.Location = new System.Drawing.Point(137, 18);
            this.destinationIdTb.Name = "destinationIdTb";
            this.destinationIdTb.Size = new System.Drawing.Size(100, 22);
            this.destinationIdTb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cihaz LoRa ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Response Text";
            // 
            // responseTextLabel
            // 
            this.responseTextLabel.Location = new System.Drawing.Point(13, 375);
            this.responseTextLabel.Name = "responseTextLabel";
            this.responseTextLabel.Size = new System.Drawing.Size(1070, 88);
            this.responseTextLabel.TabIndex = 8;
            this.responseTextLabel.Text = "---";
            // 
            // DosyaIslemleriPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.responseTextLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationIdTb);
            this.Controls.Add(this.clearFileInfoList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.getFileInfosBtn);
            this.Controls.Add(this.getLastReadBtn);
            this.Controls.Add(this.getLastWrittenBtn);
            this.Name = "DosyaIslemleriPage";
            this.Size = new System.Drawing.Size(1104, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getLastWrittenBtn;
        private System.Windows.Forms.Button getLastReadBtn;
        private System.Windows.Forms.Button getFileInfosBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button clearFileInfoList;
        private System.Windows.Forms.TextBox destinationIdTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label responseTextLabel;
    }
}
