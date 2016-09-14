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
    public partial class frmGetPassword1 : Form
    {
        // Shared variable
        public string Password { get; set; }

        public frmGetPassword1()
        {
            InitializeComponent();

            this.FormClosing += FrmGetPassword1_FormClosing;
            this.Activated += frmGetPassword1_Activated;
            txtPassword.KeyDown += txtPassword_KeyDown;
        }

        // Enter 
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) leave();
        }

        // Send the new key when the form is closed
        private void FrmGetPassword1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            leave();
        }

        // Exit the form
        private void leave()
        {
            Password = txtPassword.Text;
            Hide();
        }

        // Form Load
        private void frmGetPassword2_Load(object sender, EventArgs e)
        {
            txtPassword.Text = String.Empty;
        }

        // Clear the form on activation
        private void frmGetPassword1_Activated(object sender, EventArgs e)
        {
            txtPassword.Text = String.Empty;
            txtPassword.Focus();
        }
    }
}
