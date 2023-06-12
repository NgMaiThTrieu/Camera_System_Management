using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Camera_System_Management.Forms
{
    public partial class fLogin_Staff : Form
    {
        private BUS_Login _login = new BUS_Login();
        public string pID;
        public fLogin_Staff(string perID)
        {
            InitializeComponent();
            pID = perID;
        }

        private void fLogin_Staff_Load(object sender, EventArgs e)
        {
            txbUserName.Text = _login.TakeID(pID);
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

                MessageBox.Show(string.Format("Hello {0} To Camera System Management", DPlay), "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fCameraSystemManagement x= new fCameraSystemManagement(sUsername);
                x.Show();
                x.Hide();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
