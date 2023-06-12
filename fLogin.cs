using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace Camera_System_Management
{
    public partial class fLogin : Form
    {
        private BUS_Login _login = new BUS_Login();

        public fLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            DateTime TimeLogin;
            string sUsername, sPassword, DPlay;

            sUsername = txbUserName.Text;
            sPassword = txbPassword.Text;
            TimeLogin = DateTime.Now;
            DPlay = _login.Accuracy(sUsername, sPassword, TimeLogin);

            if (DPlay != string.Empty)
            {
                fCameraSystemManagement f = new fCameraSystemManagement(sUsername);
                this.Hide();
                f.Show();


                MessageBox.Show(String.Format("Hello {0} To Camera System Management", DPlay), "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnLogin_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the program?", "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void iconEyeHide_Click(object sender, EventArgs e)
        {
            if (txbPassword.PasswordChar == '*')
                txbPassword.PasswordChar = '\0';
            else
            {
                txbPassword.PasswordChar = '*';
            }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            iconEyeHide.Visible = true;
            if (txbPassword.Text == "")
            {
                iconEyeHide.Visible = false;
            }
        }
    }
}


