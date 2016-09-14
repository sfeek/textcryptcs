using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace TextCrypt
{
    public partial class frmTextCrypt : Form
    {
        Crypto crypto;
        frmFriendsKeys friendsKeys;
        frmYourKeys yourKeys;
        frmSettings settings;
        frmGetPassword1 password1;
        string keyStorePath;
        string fileStorePath;
        string[] configLines;

        // Intialize Form and Crypto Object
        public frmTextCrypt()
        {
            InitializeComponent();

            crypto = new Crypto();
            yourKeys = new frmYourKeys();
            friendsKeys = new frmFriendsKeys();
            settings = new frmSettings();
            password1 = new frmGetPassword1();

            try
            {
                if (File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\TextCrypt.cfg"))
                {
                    keyStorePath = String.Empty;
                    fileStorePath = String.Empty;

                    configLines = File.ReadAllLines(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\TextCrypt.cfg");

                    if (configLines.Length == 2)
                    {
                        keyStorePath = configLines[0];
                        fileStorePath = configLines[1];
                    }

                    if (keyStorePath == String.Empty)
                    {
                        keyStorePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\keys\";

                        Directory.CreateDirectory(keyStorePath);
                    }

                    if (fileStorePath == String.Empty)
                    {
                        fileStorePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\files\";

                        Directory.CreateDirectory(fileStorePath);
                    }
                }
                else
                {
                    keyStorePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\keys\";
                    fileStorePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\files\";

                    Directory.CreateDirectory(keyStorePath);
                    Directory.CreateDirectory(fileStorePath);
                }
            }
            catch
            {
                MessageBox.Show("Directory creation error!", "Directory Error");
                return;
            }
        }

        // Update key name list
        private void updateKeyPairList()
        {
            cmbChooseKey.Items.Clear();
            cmbChooseKey.Text = String.Empty;

            try
            {
                string[] list = Directory.GetFiles(keyStorePath, "*.pubkey");

                foreach (string item in list)
                {
                    string nameOnly = Path.GetFileNameWithoutExtension(item);
                    cmbChooseKey.Items.Add(nameOnly);
                }

                if (cmbChooseKey.Items.Count > 0) cmbChooseKey.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Failed to Locate the Key Store Directory!", "Key Store Error");
                return;
            }
        }


        // Copy Text from the Cipher Window
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtMainText.Text != String.Empty) Clipboard.SetText(txtMainText.Text);
        }
        
        // Paste Text to the Cipher Window
        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtMainText.Text = Clipboard.GetText();
        }

        // Clear the Text Boxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMainText.Text = String.Empty;
        }

        // Manage Friends Keys
        private void btnFriendsKeys_Click(object sender, EventArgs e)
        {
            friendsKeys.keyStorePath = keyStorePath;
            friendsKeys.ShowDialog();
            updateKeyPairList();
        }

        // Manage Your Keys
        private void btnYourKeys_Click(object sender, EventArgs e)
        {
            yourKeys.keyStorePath = keyStorePath;
            yourKeys.ShowDialog();
            updateKeyPairList();
        }

        // Encrypt
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] RSAencbytes;
            byte[] AESencbytes;
            string CipherString;

            // Make sure there is text to encrypt
            if (txtMainText.Text == String.Empty)
            {
                return;
            }

            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                RijndaelManaged AES = new RijndaelManaged();

                // Read the public key
                string pubkey = crypto.RSAReadPublicKey(keyStorePath + cmbChooseKey.Text + ".pubkey");
                
                // Generate a new Key and IV for AES
                AES.KeySize = 256;
                AES.GenerateKey();
                AES.GenerateIV();

                // Encrypt the window contents with AES
                AESencbytes = crypto.AESEncrypt(Encoding.UTF8.GetBytes(txtMainText.Text), AES.Key, AES.IV);

                if (AESencbytes == null)
                {
                    MessageBox.Show("AES Encryption failed!", "AES Encryption Error");
                    
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;
                    return;
                }

                // Encrypt Key and IV with RSA
                RSAencbytes = crypto.RSAEncrypt(pubkey, crypto.KeyIV(AES.Key, AES.IV));

                if (RSAencbytes == null)
                {
                    MessageBox.Show("RSA Encryption failed!", "RSA Encryption Error");
                    
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;
                    return;
                }

                // Get rid of all AES objects
                if (AES != null) AES.Dispose();

                //  Combine RSA and AES ciphers and convert to Base64
                CipherString = Convert.ToBase64String(crypto.KeyIVCipher(RSAencbytes, AESencbytes),Base64FormattingOptions.InsertLineBreaks);

                // Send to main window
                txtMainText.Text = CipherString;
            }
            catch
            {
                MessageBox.Show("General Encryption Failure!", "Encryption Error");
               
                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;
                return;
            }
            
            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        // Decrypt
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            byte[] RSAdecbytes;
            byte[] AESdecbytes;

            byte[] KIV;
            byte[] Cipher;

            byte[] CipherBytes;
            string PlainText;

            // Make sure there is text to decrypt
            if (txtMainText.Text == String.Empty)
            {
                return;
            }

            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            try
            {

                // Show the Get Password Dialog
                password1.ShowDialog();
                string password = password1.Password;
                if (password == String.Empty) return;

                // Read Private Keys
                string privkey = crypto.RSAReadPrivateKey(keyStorePath + cmbChooseKey.Text + ".prvkey", password);

                // Recover RSA and AES ciphers bytes from Base64
                try
                {
                    CipherBytes = Convert.FromBase64String(crypto.RemoveWhitespace(txtMainText.Text));
                }
                catch
                {
                    MessageBox.Show("Cannot Decrypt non-cipher text!", "Cipher Text Error");
                   
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;
                    return;
                }

                // Split Key and IV bytes from Cipher bytes
                KIV = crypto.GetKeyIVfromKeyIVCipher(CipherBytes);
                Cipher = crypto.GetCipherfromKeyIVCipher(CipherBytes);

                if (KIV == null || Cipher == null)
                {
                    MessageBox.Show("RSA/AES Cipher Split Error!", "RSA/AES Split Error");
                    
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;
                    return;
                }

                // Decrypt the Key and IV
                RSAdecbytes = crypto.RSADecrypt(privkey, KIV);

                if (RSAdecbytes == null)
                {
                    MessageBox.Show("RSA Decryption failed!", "RSA Decryption Error");
                    
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;
                    return;
                }

                // Decrypt AES 
                AESdecbytes = crypto.AESDecrypt(Cipher, crypto.GetKeyfromKeyIV(RSAdecbytes), crypto.GetIVfromKeyIV(RSAdecbytes));

                if (AESdecbytes == null)
                {
                    MessageBox.Show("AES Decryption failed!", "AES Decryption Error");
                    
                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;
                    return;
                }

                // Extract Plain Text
                PlainText = Encoding.UTF8.GetString(AESdecbytes);

                // Check to see if we have a file to download
                if (PlainText[0] == '<')
                {
                    int x = PlainText.IndexOf('>');

                    string fileName = PlainText.Substring(1, x - 1);
                    string contents = PlainText.Substring(x + 1);

                    try
                    {
                        File.WriteAllBytes(fileStorePath + fileName, Convert.FromBase64String(contents));
                    }
                    catch
                    {
                        MessageBox.Show("Failed to download file", "File Error");
                       
                        // Set cursor as default arrow
                        Cursor.Current = Cursors.Default;
                        return;
                    }

                    txtMainText.Text = "Downloaded file: " + fileStorePath + fileName;

                    // Set cursor as default arrow
                    Cursor.Current = Cursors.Default;
                    return;
                }

                // Send to main window
                txtMainText.Text = PlainText;
            }
            catch
            {
                MessageBox.Show("General Decryption failure!", "Decryption Error");
               
                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;
                return;
            }
            
            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        // Settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Get updated settings
            settings.keyStorePath = keyStorePath;
            settings.fileStorePath = fileStorePath;

            // Show settings window
            settings.ShowDialog();

            keyStorePath = settings.keyStorePath;
            fileStorePath = settings.fileStorePath;

            if (keyStorePath == String.Empty)
            {
                MessageBox.Show("Invalid Key Store directory", "Directory Error");
                return;
            }

            if (fileStorePath == String.Empty)
            {
                MessageBox.Show("Invalid File Store directory", "Directory Error");
                return;
            }

            // Add trailing slash if it is not there
            if (keyStorePath[keyStorePath.Length-1] != '\\')
            {
                keyStorePath += @"\";
            }

            try
            {
                // Make sure the path exists
                Directory.CreateDirectory(keyStorePath);

                // Write the file path to config file
                File.WriteAllText(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\TextCrypt.cfg", keyStorePath);
            }
            catch
            {
                MessageBox.Show("Directory creation error!", "Directory Error");
            }

            // Add trailing slash if it is not there
            if (fileStorePath[fileStorePath.Length - 1] != '\\')
            {
                fileStorePath += @"\";
            }

            try
            {
                // Make sure the path exists
                Directory.CreateDirectory(fileStorePath);

                // Write the file path to config file
                File.AppendAllText(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\TextCrypt.cfg", "\n" + fileStorePath);
            }
            catch
            {
                MessageBox.Show("Directory creation error!", "Directory Error");
            }

            updateKeyPairList();
        }

        // Form Load
        private void frmTextCrypt_Load(object sender, EventArgs e)
        {
            updateKeyPairList();
        }


        // Load a file into the main windows as base64 text
        private void btnFile_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            byte[] fileContents;
            OpenFileDialog fileOpen = new OpenFileDialog();

            fileOpen.InitialDirectory = fileStorePath;

            DialogResult result = fileOpen.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileContents = File.ReadAllBytes(fileOpen.FileName);
                txtMainText.Text = "<" + Path.GetFileName(fileOpen.FileName) + ">\n" + Convert.ToBase64String(fileContents,Base64FormattingOptions.InsertLineBreaks);
            }

            MessageBox.Show("File copied into Cipher window.\nDon't forget to press the Encrypt button!", "File Upload Status");
            
            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }
    }
}
