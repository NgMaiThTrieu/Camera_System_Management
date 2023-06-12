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

namespace Camera_System_Management.Forms
{
    public partial class fCreateAccount : Form
    {
        public fCreateAccount()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6GL392S1\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            String sFullName, sUserName,sUserPassword, sTatus;
            sFullName = txtDisplayName.Text;
            sUserName = txtUserName.Text;
            sUserPassword = txtPassWord.Text;
            sTatus = "OFF";
            try
            {
                String querry = String.Format("INSERT INTO ACCOUNT (FULLNAME, USERNAME, PASSWORD, STATUS) VALUES ('{0}', '{1}', '{2}', '{3}')", sFullName, sUserName, sUserPassword, sTatus);

                if (txtUserName.Text != "" && txtPassWord.Text != "")
                {
                    if (txtConfirmPassword.Text == txtPassWord.Text)
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);
                        MessageBox.Show("Wellcome " + txtDisplayName.Text + " To Camera System Management DTD", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDisplayName.Clear();
                        txtUserName.Clear();
                        txtPassWord.Clear();
                        txtConfirmPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Confirmation password does not match", "Nofity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter full information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

       

        private void txtDisplayName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEyeHidePassword_Click_1(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '*')
                txtPassWord.PasswordChar = '\0';
            else
            {
                txtPassWord.PasswordChar = '*';
            }
        }

        private void btnEyeHideConfirmPasswrod_Click_1(object sender, EventArgs e)
        {

            if (txtConfirmPassword.PasswordChar == '*')
                txtConfirmPassword.PasswordChar = '\0';
            else
            {
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void txtPassWord_TextChanged_1(object sender, EventArgs e)
        {
            btnEyeHidePassword.Visible = true;
            if (txtPassWord.Text == "")
            {
                btnEyeHidePassword.Visible = false;
            }
        }

        private void txtConfirmPassword_TextChanged_1(object sender, EventArgs e)
        {
            btnEyeHideConfirmPasswrod.Visible = true;
            if (txtConfirmPassword.Text == "")
            {
                btnEyeHideConfirmPasswrod.Visible = false;
            }
        }

        private void fCreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
