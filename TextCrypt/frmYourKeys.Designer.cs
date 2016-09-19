namespace TextCrypt
{
    partial class frmYourKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYourKeys));
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.lblKeyPairName = new System.Windows.Forms.Label();
            this.cmbKeyPairName = new System.Windows.Forms.ComboBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnAddKeyPair = new System.Windows.Forms.Button();
            this.btnUpdateKeyPair = new System.Windows.Forms.Button();
            this.btnDeleteKeyPair = new System.Windows.Forms.Button();
            this.lblFingerPrint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicKey.Location = new System.Drawing.Point(12, 12);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublicKey.Size = new System.Drawing.Size(474, 143);
            this.txtPublicKey.TabIndex = 0;
            this.txtPublicKey.WordWrap = false;
            // 
            // lblKeyPairName
            // 
            this.lblKeyPairName.AutoSize = true;
            this.lblKeyPairName.Location = new System.Drawing.Point(53, 184);
            this.lblKeyPairName.Name = "lblKeyPairName";
            this.lblKeyPairName.Size = new System.Drawing.Size(77, 13);
            this.lblKeyPairName.TabIndex = 1;
            this.lblKeyPairName.Text = "Key Pair Name";
            // 
            // cmbKeyPairName
            // 
            this.cmbKeyPairName.FormattingEnabled = true;
            this.cmbKeyPairName.Location = new System.Drawing.Point(136, 181);
            this.cmbKeyPairName.Name = "cmbKeyPairName";
            this.cmbKeyPairName.Size = new System.Drawing.Size(121, 21);
            this.cmbKeyPairName.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(339, 178);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnAddKeyPair
            // 
            this.btnAddKeyPair.Location = new System.Drawing.Point(42, 220);
            this.btnAddKeyPair.Name = "btnAddKeyPair";
            this.btnAddKeyPair.Size = new System.Drawing.Size(111, 23);
            this.btnAddKeyPair.TabIndex = 4;
            this.btnAddKeyPair.Text = "Add Key Pair";
            this.btnAddKeyPair.UseVisualStyleBackColor = true;
            this.btnAddKeyPair.Click += new System.EventHandler(this.btnAddKeyPair_Click);
            // 
            // btnUpdateKeyPair
            // 
            this.btnUpdateKeyPair.Location = new System.Drawing.Point(191, 220);
            this.btnUpdateKeyPair.Name = "btnUpdateKeyPair";
            this.btnUpdateKeyPair.Size = new System.Drawing.Size(111, 23);
            this.btnUpdateKeyPair.TabIndex = 5;
            this.btnUpdateKeyPair.Text = "Update Key Pair";
            this.btnUpdateKeyPair.UseVisualStyleBackColor = true;
            this.btnUpdateKeyPair.Click += new System.EventHandler(this.UpdateKeyPair_Click);
            // 
            // btnDeleteKeyPair
            // 
            this.btnDeleteKeyPair.Location = new System.Drawing.Point(339, 220);
            this.btnDeleteKeyPair.Name = "btnDeleteKeyPair";
            this.btnDeleteKeyPair.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteKeyPair.TabIndex = 6;
            this.btnDeleteKeyPair.Text = "Delete Key Pair";
            this.btnDeleteKeyPair.UseVisualStyleBackColor = true;
            this.btnDeleteKeyPair.Click += new System.EventHandler(this.btnDeleteKeyPair_Click);
            // 
            // lblFingerPrint
            // 
            this.lblFingerPrint.AutoSize = true;
            this.lblFingerPrint.Location = new System.Drawing.Point(53, 158);
            this.lblFingerPrint.Name = "lblFingerPrint";
            this.lblFingerPrint.Size = new System.Drawing.Size(66, 13);
            this.lblFingerPrint.TabIndex = 7;
            this.lblFingerPrint.Text = "Finger Print :";
            // 
            // frmYourKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 257);
            this.Controls.Add(this.lblFingerPrint);
            this.Controls.Add(this.btnDeleteKeyPair);
            this.Controls.Add(this.btnUpdateKeyPair);
            this.Controls.Add(this.btnAddKeyPair);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.cmbKeyPairName);
            this.Controls.Add(this.lblKeyPairName);
            this.Controls.Add(this.txtPublicKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 296);
            this.MinimumSize = new System.Drawing.Size(517, 296);
            this.Name = "frmYourKeys";
            this.Text = "Manage Your Keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label lblKeyPairName;
        private System.Windows.Forms.ComboBox cmbKeyPairName;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnAddKeyPair;
        private System.Windows.Forms.Button btnUpdateKeyPair;
        private System.Windows.Forms.Button btnDeleteKeyPair;
        private System.Windows.Forms.Label lblFingerPrint;
    }
}