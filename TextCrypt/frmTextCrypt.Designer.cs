namespace TextCrypt
{
    partial class frmTextCrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextCrypt));
            this.txtMainText = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbChooseKey = new System.Windows.Forms.ComboBox();
            this.lblKeyName = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnFriendsKeys = new System.Windows.Forms.Button();
            this.btnYourKeys = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMainText
            // 
            this.txtMainText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainText.Location = new System.Drawing.Point(12, 12);
            this.txtMainText.MaxLength = 0;
            this.txtMainText.Multiline = true;
            this.txtMainText.Name = "txtMainText";
            this.txtMainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMainText.Size = new System.Drawing.Size(560, 348);
            this.txtMainText.TabIndex = 0;
            this.txtMainText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainText_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(89, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbChooseKey
            // 
            this.cmbChooseKey.FormattingEnabled = true;
            this.cmbChooseKey.Location = new System.Drawing.Point(89, 402);
            this.cmbChooseKey.Name = "cmbChooseKey";
            this.cmbChooseKey.Size = new System.Drawing.Size(164, 21);
            this.cmbChooseKey.TabIndex = 3;
            // 
            // lblKeyName
            // 
            this.lblKeyName.AutoSize = true;
            this.lblKeyName.Location = new System.Drawing.Point(27, 405);
            this.lblKeyName.Name = "lblKeyName";
            this.lblKeyName.Size = new System.Drawing.Size(56, 13);
            this.lblKeyName.TabIndex = 4;
            this.lblKeyName.Text = "Key Name";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(357, 367);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(447, 367);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 6;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(327, 396);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(105, 30);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(447, 396);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(105, 30);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnFriendsKeys
            // 
            this.btnFriendsKeys.Location = new System.Drawing.Point(30, 436);
            this.btnFriendsKeys.Name = "btnFriendsKeys";
            this.btnFriendsKeys.Size = new System.Drawing.Size(128, 23);
            this.btnFriendsKeys.TabIndex = 9;
            this.btnFriendsKeys.Text = "Manage Friend\'s Keys";
            this.btnFriendsKeys.UseVisualStyleBackColor = true;
            this.btnFriendsKeys.Click += new System.EventHandler(this.btnFriendsKeys_Click);
            // 
            // btnYourKeys
            // 
            this.btnYourKeys.Location = new System.Drawing.Point(164, 436);
            this.btnYourKeys.Name = "btnYourKeys";
            this.btnYourKeys.Size = new System.Drawing.Size(128, 23);
            this.btnYourKeys.TabIndex = 10;
            this.btnYourKeys.Text = "Mange Your Keys";
            this.btnYourKeys.UseVisualStyleBackColor = true;
            this.btnYourKeys.Click += new System.EventHandler(this.btnYourKeys_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(327, 436);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(105, 23);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(447, 436);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(105, 23);
            this.btnFile.TabIndex = 12;
            this.btnFile.Text = "Send File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // frmTextCrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 471);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnYourKeys);
            this.Controls.Add(this.btnFriendsKeys);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblKeyName);
            this.Controls.Add(this.cmbChooseKey);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtMainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 510);
            this.MinimumSize = new System.Drawing.Size(600, 510);
            this.Name = "frmTextCrypt";
            this.Text = "Text Crypt v2.10";
            this.Load += new System.EventHandler(this.frmTextCrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbChooseKey;
        private System.Windows.Forms.Label lblKeyName;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnFriendsKeys;
        private System.Windows.Forms.Button btnYourKeys;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFile;
    }
}

