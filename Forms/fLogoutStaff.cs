using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Camera_System_Management.Forms
{
    public partial class fLogoutStaff : Form
    {

        private BUS_Login _logout = new BUS_Login();
        public string pID;
        public fLogoutStaff(string perID)
        {
            InitializeComponent();
            pID = perID;
        }

        private void fLogoutStaff_Load(object sender, EventArgs e)
        {
            txbUserName.Text = _logout.TakeID(pID);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DateTime TimeLogin;
            string sUsername, sPassword, DPlay;

            sUsername = txbUserName.Text;
            sPassword = txbPassword.Text;
            TimeLogin = DateTime.Now;

            MessageBox.Show(_logout.Logout(sUsername, sPassword) == true ? "successful logout" : "logout failed");
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
