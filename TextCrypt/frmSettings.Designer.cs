namespace TextCrypt
{
    partial class frmSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.lblKeyPath = new System.Windows.Forms.Label();
            this.txtKeyStorePath = new System.Windows.Forms.TextBox();
            this.lblFileStorePath = new System.Windows.Forms.Label();
            this.txtFileStorePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKeyPath
            // 
            this.lblKeyPath.AutoSize = true;
            this.lblKeyPath.Location = new System.Drawing.Point(12, 19);
            this.lblKeyPath.Name = "lblKeyPath";
            this.lblKeyPath.Size = new System.Drawing.Size(78, 13);
            this.lblKeyPath.TabIndex = 0;
            this.lblKeyPath.Text = "Key Store Path";
            // 
            // txtKeyStorePath
            // 
            this.txtKeyStorePath.Location = new System.Drawing.Point(96, 16);
            this.txtKeyStorePath.Name = "txtKeyStorePath";
            this.txtKeyStorePath.Size = new System.Drawing.Size(305, 20);
            this.txtKeyStorePath.TabIndex = 1;
            // 
            // lblFileStorePath
            // 
            this.lblFileStorePath.AutoSize = true;
            this.lblFileStorePath.Location = new System.Drawing.Point(12, 55);
            this.lblFileStorePath.Name = "lblFileStorePath";
            this.lblFileStorePath.Size = new System.Drawing.Size(76, 13);
            this.lblFileStorePath.TabIndex = 2;
            this.lblFileStorePath.Text = "File Store Path";
            // 
            // txtFileStorePath
            // 
            this.txtFileStorePath.Location = new System.Drawing.Point(96, 52);
            this.txtFileStorePath.Name = "txtFileStorePath";
            this.txtFileStorePath.Size = new System.Drawing.Size(305, 20);
            this.txtFileStorePath.TabIndex = 3;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 88);
            this.Controls.Add(this.txtFileStorePath);
            this.Controls.Add(this.lblFileStorePath);
            this.Controls.Add(this.txtKeyStorePath);
            this.Controls.Add(this.lblKeyPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyPath;
        private System.Windows.Forms.TextBox txtKeyStorePath;
        private System.Windows.Forms.Label lblFileStorePath;
        private System.Windows.Forms.TextBox txtFileStorePath;
    }
}