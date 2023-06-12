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
    public partial class fAccount : Form
    {
        private BUS_Account _account = new BUS_Account();
        private BUS_Account _staff_ID = new BUS_Account();

        public string ID;
        public fAccount()
        {
            InitializeComponent();
            dgvAccount.AutoGenerateColumns = false;
        }


        private int ImageNumber = 1;

        private void Slider()
        {
            if (ImageNumber == 5)
                ImageNumber = 1;
            pictureBoxSlider.ImageLocation = String.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Slider();
        }


        private void sqlAccount(String query)
        {

        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = _account.LoadListAcc();
            cboStaffCode.DataSource = _staff_ID.LoadListID();
            cboStaffCode.DisplayMember = "DisplayName";
            cboStaffCode.ValueMember = "Acc_ID";
            
           
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAccount.DataSource = _account.Sreach_Account(txtSearch.Text);
           
            
        }

        private void txtDisplayName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '*')
                txtPassWord.PasswordChar = '\0';
            else
            {
                txtPassWord.PasswordChar = '*';
            }
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '*')
                txtConfirmPassword.PasswordChar = '\0';
            else
            {
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            btnPassword.Visible = true;
            if (txtPassWord.Text == "")
            {
                btnPassword.Visible = false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            btnConfirmPassword.Visible = true;
            if (txtPassWord.Text == "")
            {
                btnConfirmPassword.Visible = false;
            }
        }

        private void cboStaffCode_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboStaffCode.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassWord.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please enter full information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (txtPassWord.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DTO_Account acc = new DTO_Account()
                    {
                        Acc_ID = cboStaffCode.SelectedValue.ToString(),
                        DisplayName = cboStaffCode.Text,
                        UserName = txtUsername.Text,
                        L_Password = txtPassWord.Text,
                    };

                    MessageBox.Show(_account.Add_Account(acc) == true? "Account added successfully": "Account added failed");
                    fAccount_Load(sender, e);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(_account.Remove_Account(ID) == true ? "Account removed successfully" : "Account removed failed");
            fAccount_Load(sender, e);

        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indx = e.RowIndex;
            if(indx >= 0)
            {
                DataGridViewRow row = dgvAccount.Rows[indx];
               ID = row.Cells[0].Value.ToString();
               
            }
        }
    }
}
