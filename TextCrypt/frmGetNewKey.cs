using System;
using System.Windows.Forms;

namespace TextCrypt
{
    public partial class frmGetNewKey : Form
    {
        // Shared variable
        public string newKey { get; set; }

        // Initialize the form
        public frmGetNewKey()
        {
            InitializeComponent();

            this.FormClosing += frmGetNewKey_FormClosing;
            this.Activated += frmGetNewKey_Activiated;
            txtNewKey.KeyDown += txtNewKey_KeyDown;
        }

        // Enter 
        private void txtNewKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) leave();
        }

        // Exit the form
        private void leave()
        {
            newKey = txtNewKey.Text;
            Hide();
        }

        // Send the new key when the form is closed
        private void frmGetNewKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            leave();
            e.Cancel = true;
        }

        // Clear the form when activated
        private void frmGetNewKey_Activiated(object sender, EventArgs e)
        {
            txtNewKey.Text = String.Empty;
        }
    }
}
