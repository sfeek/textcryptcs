namespace TextCrypt
{
    partial class frmFriendsKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFriendsKeys));
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.lblPublicKeyName = new System.Windows.Forms.Label();
            this.btnAddKey = new System.Windows.Forms.Button();
            this.btnDeleteKey = new System.Windows.Forms.Button();
            this.cmbPublicKeyName = new System.Windows.Forms.ComboBox();
            this.btnUpdateKey = new System.Windows.Forms.Button();
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
            // 
            // lblPublicKeyName
            // 
            this.lblPublicKeyName.AutoSize = true;
            this.lblPublicKeyName.Location = new System.Drawing.Point(47, 172);
            this.lblPublicKeyName.Name = "lblPublicKeyName";
            this.lblPublicKeyName.Size = new System.Drawing.Size(88, 13);
            this.lblPublicKeyName.TabIndex = 1;
            this.lblPublicKeyName.Text = "Public Key Name";
            // 
            // btnAddKey
            // 
            this.btnAddKey.Location = new System.Drawing.Point(47, 208);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(111, 23);
            this.btnAddKey.TabIndex = 3;
            this.btnAddKey.Text = "Add Key";
            this.btnAddKey.UseVisualStyleBackColor = true;
            this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);
            // 
            // btnDeleteKey
            // 
            this.btnDeleteKey.Location = new System.Drawing.Point(344, 208);
            this.btnDeleteKey.Name = "btnDeleteKey";
            this.btnDeleteKey.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteKey.TabIndex = 4;
            this.btnDeleteKey.Text = "Delete Key";
            this.btnDeleteKey.UseVisualStyleBackColor = true;
            this.btnDeleteKey.Click += new System.EventHandler(this.btnDeleteKey_Click);
            // 
            // cmbPublicKeyName
            // 
            this.cmbPublicKeyName.FormattingEnabled = true;
            this.cmbPublicKeyName.Location = new System.Drawing.Point(141, 169);
            this.cmbPublicKeyName.Name = "cmbPublicKeyName";
            this.cmbPublicKeyName.Size = new System.Drawing.Size(121, 21);
            this.cmbPublicKeyName.TabIndex = 7;
            // 
            // btnUpdateKey
            // 
            this.btnUpdateKey.Location = new System.Drawing.Point(196, 208);
            this.btnUpdateKey.Name = "btnUpdateKey";
            this.btnUpdateKey.Size = new System.Drawing.Size(111, 23);
            this.btnUpdateKey.TabIndex = 8;
            this.btnUpdateKey.Text = "Update Key";
            this.btnUpdateKey.UseVisualStyleBackColor = true;
            this.btnUpdateKey.Click += new System.EventHandler(this.btnUpdateKey_Click);
            // 
            // frmFriendsKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 243);
            this.Controls.Add(this.btnUpdateKey);
            this.Controls.Add(this.cmbPublicKeyName);
            this.Controls.Add(this.btnDeleteKey);
            this.Controls.Add(this.btnAddKey);
            this.Controls.Add(this.lblPublicKeyName);
            this.Controls.Add(this.txtPublicKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFriendsKeys";
            this.Text = "Manage Friend\'s Keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label lblPublicKeyName;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.Button btnDeleteKey;
        private System.Windows.Forms.ComboBox cmbPublicKeyName;
        private System.Windows.Forms.Button btnUpdateKey;
    }
}