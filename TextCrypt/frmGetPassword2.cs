using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCrypt
{
    public partial class frmGetPassword2 : Form
    {
        // Shared variable
        public string Password { get; set; }

        public frmGetPassword2()
        {
            InitializeComponent();

            this.FormClosing += frmGetPassword2_FormClosing;
            this.Activated += frmGetPassword2_Activated;
            txtPassword2.KeyDown += txtPassword2_KeyDown;
        }

        // Enter 
        private void txtPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) leave();
        }

        // Exit the form
        private void leave()
        {
            if (txtPassword1.Text == txtPassword2.Text)
            {
                Password = txtPassword1.Text;
                Hide();
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "Password Error");

            }
        }

        // Send the new key when the form is closed
        private void frmGetPassword2_FormClosing(object sender, FormClosingEventArgs e)
        {
            leave();
            e.Cancel = true;
        }

        // Clear the form on activation
        private void frmGetPassword2_Activated(object sender, EventArgs e)
        {
            txtPassword1.Text = String.Empty;
            txtPassword2.Text = String.Empty;
            txtPassword1.Focus();
        }
    }
}
