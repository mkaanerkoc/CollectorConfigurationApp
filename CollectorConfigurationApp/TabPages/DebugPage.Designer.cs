﻿namespace CollectorConfigurationApp.TabPages
{
    partial class DebugPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.queueElementsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Queue Elements";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // queueElementsLbl
            // 
            this.queueElementsLbl.AutoSize = true;
            this.queueElementsLbl.Location = new System.Drawing.Point(280, 30);
            this.queueElementsLbl.Name = "queueElementsLbl";
            this.queueElementsLbl.Size = new System.Drawing.Size(18, 17);
            this.queueElementsLbl.TabIndex = 1;
            this.queueElementsLbl.Text = "--";
            // 
            // DebugPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.queueElementsLbl);
            this.Controls.Add(this.button1);
            this.Name = "DebugPage";
            this.Size = new System.Drawing.Size(1125, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label queueElementsLbl;
    }
}
