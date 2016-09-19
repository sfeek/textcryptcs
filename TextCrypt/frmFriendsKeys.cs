using System;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;

namespace TextCrypt
{
    public partial class frmFriendsKeys : Form
    {
        frmGetNewKey getNewKey;
        frmGetPubKey getPubKey;
        Crypto crypto;


        // Shared variable
        public string keyStorePath { get; set; }

        // Form Load
        public frmFriendsKeys()
        {
            InitializeComponent();

            getNewKey = new frmGetNewKey();
            getPubKey = new frmGetPubKey();
            crypto = new Crypto();

            // Event for Combo Box Select
            this.cmbPublicKeyName.SelectedIndexChanged += new System.EventHandler(cmbPublicKeyName_SelectedIndexChanged);

            // Event for Text Box Change
            this.txtPublicKey.TextChanged += new System.EventHandler(txtPublicKey_TextChanged);

            // Event to refresh form on activate
            this.Activated += frmFriendsKeys_Activated;
        }

        // Update Public Key Window
        private void cmbPublicKeyName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                string[] pKey = File.ReadAllLines(keyStorePath + cmbPublicKeyName.Text + ".pubkey");

                txtPublicKey.Text = String.Empty;
                foreach (string line in pKey)
                {
                    txtPublicKey.AppendText(line);
                    txtPublicKey.AppendText(Environment.NewLine);
                }
            }
            catch { return; }
        }

        private void txtPublicKey_TextChanged(object sender, EventArgs e)
        {
            string pKey;

            pKey = RemoveWhitespace(txtPublicKey.Text);
            pKey = pKey.Replace("BEGINPUBLICKEY", String.Empty);
            pKey = pKey.Replace("ENDPUBLICKEY", String.Empty);
            pKey = pKey.Replace("-", String.Empty);

            lblFingerPrint.Text = MD5Hash(pKey);
        }

        // Remove Whitespace
        public string RemoveWhitespace(string str)
        {
            try
            {
                return string.Join(String.Empty, str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            }
            catch { return String.Empty; }
        }

        // Compute SHA 1 finger print
        private static String MD5Hash(String value)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Finger Print : ");

            using (MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(value));

                foreach (Byte b in result)
                    sb.Append(b.ToString("x2") + " ");
            }

            return sb.ToString();
        }

        // Paste Button
        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtPublicKey.Text = Clipboard.GetText();
        }

        // Add/Update Button
        private void btnAddKey_Click(object sender, EventArgs e)
        {
            string pKey;

            // Get a new key name
            getNewKey.Location = new Point(this.Location.X + 10, this.Location.Y + 10);
            getNewKey.StartPosition = FormStartPosition.Manual;

            getNewKey.ShowDialog();

            string keyName = getNewKey.newKey;
            if (keyName == String.Empty) return;

            // Make sure that the public key is not part of a key pair in the store
            if (File.Exists(keyStorePath + keyName + ".prvkey"))
            {
                MessageBox.Show("Cannot add Public Key because it is part of a Key Pair!", "Public Key Status");
                return;
            }

            // Get a new public key
            getPubKey.Location = new Point(this.Location.X + 10, this.Location.Y + 10);
            getPubKey.StartPosition = FormStartPosition.Manual;

            getPubKey.ShowDialog();

            string pub = getPubKey.newKey;
            if (pub == String.Empty) return;

            // Remove the junk from pasted text
            pKey = crypto.RemoveWhitespace(pub);
            pKey = pKey.Replace("BEGINPUBLICKEY", String.Empty);
            pKey = pKey.Replace("ENDPUBLICKEY", String.Empty);
            pKey = pKey.Replace("-", String.Empty);

            // Store the key pairs
            if (crypto.RSAStorePublicKey(keyStorePath + keyName + ".pubkey", pKey) == 1)
            {
                MessageBox.Show("Failed to store RSA Public Key", "RSA Key Error");
                return;
            }

            updateKeyPairList();
        }

        // Delete Button
        private void btnDeleteKey_Click(object sender, EventArgs e)
        {
            string keyName;

            //Get name from dropdown
            keyName = cmbPublicKeyName.Text;
            if (keyName == String.Empty) return;

            // Show Warning
            DialogResult yesno = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);

            // Bail out if no
            if (yesno == DialogResult.No) return;

            // Make sure that the public key is not part of a key pair in the store
            if (File.Exists(keyStorePath + keyName + ".prvkey"))
            {
                MessageBox.Show("Cannot delete Public Key because it is part of a Key Pair!", "Public Key Status");
                return;
            }

            // Delete the file
            try
            {
                File.Delete(keyStorePath + keyName + ".pubkey");
            }
            catch
            {
                MessageBox.Show("Public Key delete failed!", "Public Key Status");
                return;
            }

            MessageBox.Show("Public Key Deleted!", "Public Key Status");

            updateKeyPairList();
        }

        // Update Button
        private void btnUpdateKey_Click(object sender, EventArgs e)
        {
            string pKey;

            // Get the key name
            string keyName = cmbPublicKeyName.Text;
            if (keyName == String.Empty) return;

            // Make sure that the public key is not part of a key pair in the store
            if (File.Exists(keyStorePath + keyName + ".prvkey"))
            {
                MessageBox.Show("Cannot Update Public Key because it is part of a Key Pair!", "Public Key Status");
                return;
            }

            // Get a new public key
            getPubKey.Location = new Point(this.Location.X + 10, this.Location.Y + 10);
            getPubKey.StartPosition = FormStartPosition.Manual;

            getPubKey.ShowDialog();

            string pub = getPubKey.newKey;
            if (pub == String.Empty) return;

            // Remove the junk from pasted text
            pKey = crypto.RemoveWhitespace(pub);
            pKey = pKey.Replace("BEGINPUBLICKEY", String.Empty);
            pKey = pKey.Replace("ENDPUBLICKEY", String.Empty);
            pKey = pKey.Replace("-", String.Empty);

            // Store the key pairs
            if (crypto.RSAStorePublicKey(keyStorePath + keyName + ".pubkey", pKey) == 1)
            {
                MessageBox.Show("Failed to store RSA Public Key", "RSA Key Error");
                return;
            }

            updateKeyPairList();
        }

        // Update key name list
        private void updateKeyPairList()
        {
            cmbPublicKeyName.Items.Clear();
            cmbPublicKeyName.Text = String.Empty;
            txtPublicKey.Text = String.Empty;

            try
            {
                string[] list = Directory.GetFiles(keyStorePath, "*.pubkey");
                foreach (string item in list)
                {
                    string nameOnly = Path.GetFileNameWithoutExtension(item);
                    cmbPublicKeyName.Items.Add(nameOnly);
                }

                if (cmbPublicKeyName.Items.Count > 0) cmbPublicKeyName.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Failed to locate the Key Store directory!", "Key Store Error");
                this.Close();
                return;
            }
        }

        // Update the drop down when form activated
        private void frmFriendsKeys_Activated(object sender, EventArgs e)
        {
            updateKeyPairList();
        }
    }
}
