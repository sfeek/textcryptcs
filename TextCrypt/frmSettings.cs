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
    public partial class frmSettings : Form
    {
        // Shared variable
        public string keyStorePath { get; set; }
        public string fileStorePath { get; set; }

        // Initialize form
        public frmSettings()
        {
            InitializeComponent();

            this.FormClosing += FrmSettings_FormClosing;
            txtKeyStorePath.KeyDown += txtKeyStorePath_KeyDown;
            txtFileStorePath.KeyDown += txtFileStorePath_KeyDown;
        }

        // Enter 
        private void txtKeyStorePath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) leave();
        }

        // Enter 
        private void txtFileStorePath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) leave();
        }

        // Exit the form
        private void leave()
        {
            keyStorePath = txtKeyStorePath.Text;
            fileStorePath = txtFileStorePath.Text;
            Hide();
        }

        // Send the variables back when the form is closed
        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            leave();
            e.Cancel = true;
        }

        // On Form Load
        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtKeyStorePath.Text = keyStorePath;
            txtFileStorePath.Text = fileStorePath;
        }
    }
}
