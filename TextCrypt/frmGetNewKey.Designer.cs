namespace TextCrypt
{
    partial class frmGetNewKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetNewKey));
            this.lblAddNewKey = new System.Windows.Forms.Label();
            this.txtNewKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddNewKey
            // 
            this.lblAddNewKey.AutoSize = true;
            this.lblAddNewKey.Location = new System.Drawing.Point(12, 27);
            this.lblAddNewKey.Name = "lblAddNewKey";
            this.lblAddNewKey.Size = new System.Drawing.Size(81, 13);
            this.lblAddNewKey.TabIndex = 0;
            this.lblAddNewKey.Text = "New Key Name";
            // 
            // txtNewKey
            // 
            this.txtNewKey.Location = new System.Drawing.Point(99, 24);
            this.txtNewKey.Name = "txtNewKey";
            this.txtNewKey.Size = new System.Drawing.Size(176, 20);
            this.txtNewKey.TabIndex = 1;
            // 
            // frmGetNewKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 66);
            this.Controls.Add(this.txtNewKey);
            this.Controls.Add(this.lblAddNewKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGetNewKey";
            this.Text = "Add New Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewKey;
        private System.Windows.Forms.TextBox txtNewKey;
    }
}