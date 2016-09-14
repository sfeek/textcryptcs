using System;
using System.Windows.Forms;

namespace TextCrypt
{
    public partial class frmGetPubKey : Form
    {
        // Shared variable
        public string newKey { get; set; }

        // Initialize the form
        public frmGetPubKey()
        {
            InitializeComponent();

            this.FormClosing += frmGetPubKey_FormClosing;
            this.Activated += frmGetPubKey_Activiated;
            txtPubKey.KeyDown += txtPubKey_KeyDown;
        }

        // Enter 
        private void txtPubKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) leave();
        }

        // Exit the form
        private void leave()
        {
            newKey = txtPubKey.Text;
            Hide();
        }

        // Send the new key when the form is closed
        private void frmGetPubKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            leave();
            e.Cancel = true;
        }

        // Clear the form when activated
        private void frmGetPubKey_Activiated(object sender, EventArgs e)
        {
            txtPubKey.Text = String.Empty;
        }

        // Paste Button
        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtPubKey.Text = Clipboard.GetText();
            txtPubKey.Focus();
        }
    }
}
