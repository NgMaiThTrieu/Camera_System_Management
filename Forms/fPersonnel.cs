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
using Camera_System_Management.Forms;
using BUS;
using DTO;

namespace Camera_System_Management.Forms
{
    public partial class fPersonnel : Form
    {
        private BUS_Staff _staff = new BUS_Staff();
        private BUS_Staff _staff_Sreach = new BUS_Staff();
        public int ID=1;
        public fPersonnel()
        {
            InitializeComponent();
            dgvPersonnel.AutoGenerateColumns = false;
        }

        public void Refesh(object sender, EventArgs e)
        {
            txtPersonCode_Click(sender, e);

            cboPosition.SelectedIndex = 0;

            txtLastName.Text = string.Empty;

            txtFirstName.Text = string.Empty;

            txtCCCD.Text = string.Empty;

            cboSex.SelectedIndex = 0;

            dtpBirdthDay.Value = DateTime.Now;

            cboProvince.SelectedIndex = 0;
            txtNumberPhone.Text = string.Empty;
            txtGmail.Text = string.Empty;
            txtSaraly.Text = string.Empty;
        }
        private void sqlSelectPersonnel(String sSql)
        {
           
        }

        private void sqlPersonnel(String query)
        {
            
        }

        private void fPersonnel_Load(object sender, EventArgs e)
        {
            string sPersonalCode;
            int Temp;
            
            dgvPersonnel.DataSource = _staff.LoadAllListStaff();

            for (int i = 0; i< dgvPersonnel.Rows.Count; i++)
            {
                sPersonalCode = dgvPersonnel.Rows[i].Cells[0].Value.ToString();
                Temp = int.Parse(sPersonalCode.Substring(2, sPersonalCode.Length - 2));
                if(Temp > ID) ID = Temp;
            }
            dgvPersonnel.DataSource = _staff.LoadListStaff();
        }

        private void dgvPersonnel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvPersonnel.Rows[index];

                if (row.Cells[0].Value.ToString().Contains("AD")) cboDecentralization.Text = "Admin";
                else  cboDecentralization.Text = "Staff";

                if (row.Cells[1].Value.ToString().Contains("MNG"))
                    cboPosition.Text = "Manage";
                else if (row.Cells[1].Value.ToString().Contains("SL"))
                    cboPosition.Text = "Sell";
                else if (row.Cells[1].Value.ToString().Contains("CH"))
                    cboPosition.Text = "Cashier";
                else
                    cboPosition.Text = "TK";

                txtPersonCode.Text = row.Cells[0].Value.ToString();

                txtLastName.Text = row.Cells[2].Value.ToString();

                txtFirstName.Text =row.Cells[3].Value.ToString();

                txtCCCD.Text = row.Cells[4].Value.ToString();

                cboSex.Text = row.Cells[5].Value.ToString();

                dtpBirdthDay.Value = DateTime.Parse(row.Cells[6].Value.ToString());

                cboProvince.Text = row.Cells[7].Value.ToString();

                if(cboProvince.Text != row.Cells[7].Value.ToString())
                {
                    cboProvince.Items.Add(row.Cells[7].Value.ToString());
                    cboProvince.Text = row.Cells[7].Value.ToString();
                }    
                txtNumberPhone.Text = row.Cells[8].Value.ToString();
                txtGmail.Text = row.Cells[9].Value.ToString();
                txtSaraly.Text = row.Cells[10].Value.ToString();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string notification;
            //Kiểm tra nhập đầy đủ thông tin trong các ô Textbox
           if (string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtGmail.Text) || string.IsNullOrEmpty(txtNumberPhone.Text) || string.IsNullOrEmpty(txtPersonCode.Text) && string.IsNullOrEmpty(txtSaraly.Text) || string.IsNullOrEmpty(txtCCCD.Text))
            {
                MessageBox.Show("Please enter full information","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else
            {
                DateTime dateTime = DateTime.Now;
                //Kiểm tra Ngày sinh
                if(dtpBirdthDay.Value>dateTime)
                {
                    MessageBox.Show("Invalid birthday","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DTO_Staff1 staff = new DTO_Staff1()
                    {
                        Staff_ID = txtPersonCode.Text,
                        MACV = cboPosition.Text,
                        FistName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        CCCD = txtCCCD.Text,
                        Sex = cboSex.Text,
                        DateOfBirth = dtpBirdthDay.Value,
                        NativeLand = cboProvince.Text,
                        NumberPhone = decimal.Parse(txtNumberPhone.Text.ToString()),
                        Email = txtGmail.Text,
                       
                    };
                    if((notification = _staff.Add_Staff(staff)) == "Personnel added successfully")
                    {
                        MessageBox.Show(notification, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fPersonnel_Load(sender, e);
                        Refesh(sender, e);
                    }    
                    else
                    {
                        MessageBox.Show(notification, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                    
                }    
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(_staff.Remove_Staff(txtPersonCode.Text) == true ? "Rersonnel removed successfully" : "Personnel removed failed");
            fPersonnel_Load(sender, e);
            Refesh(sender, e);
        }

        private void txtPersonCode_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtPersonCode.Text.Substring(2, txtPersonCode.Text.Length - 2)) < ID + 1)
            {
                btnAdd.Enabled = false;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }    
                
            else
            {
                btnAdd.Enabled = true;
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }    

        }

        private void txtNumberPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberPhone.Text.Length == 10)
                iconPtCheck.Visible = true;
            else
                iconPtCheck.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPersonnel.DataSource = _staff_Sreach.Sreach_Staff(txtSearch.Text);
        }

        private void txtPersonCode_Click(object sender, EventArgs e)
        {
            string TempCode;

            if (ID + 1 < 10)
            {
                TempCode = "00";
            }
            else if (ID + 1 < 100)
            {
                TempCode = "0";
            }
            else
            {
                TempCode = string.Empty;
            }

                txtPersonCode.Text = cboDecentralization.SelectedIndex == 1 ? "AD" + TempCode + (ID + 1).ToString() : "ST" + TempCode + (ID + 1).ToString();
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtSaraly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void lblBirthDay_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtGmail.Text) || string.IsNullOrEmpty(txtNumberPhone.Text) || string.IsNullOrEmpty(txtPersonCode.Text) && string.IsNullOrEmpty(txtSaraly.Text) || string.IsNullOrEmpty(txtCCCD.Text))
            {
                MessageBox.Show("Please enter full information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime dateTime = DateTime.Now;
                //Kiểm tra Ngày sinh
                if (dtpBirdthDay.Value > dateTime)
                {
                    MessageBox.Show("Invalid birthday", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DTO_Staff1 staff = new DTO_Staff1()
                    {
                        Staff_ID = txtPersonCode.Text,
                        MACV = cboPosition.Text,
                        FistName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        CCCD = txtCCCD.Text,
                        Sex = cboSex.Text,
                        DateOfBirth = dtpBirdthDay.Value,
                        NativeLand = cboProvince.Text,
                        NumberPhone = decimal.Parse(txtNumberPhone.Text.ToString()),
                        Email = txtGmail.Text,
                       
                    };
                    MessageBox.Show(_staff.Remove_Staff(txtPersonCode.Text) == true ? "Rersonnel update successfully" : "Personnel update failed");

                    fPersonnel_Load(sender, e);
                    Refesh(sender, e);
                   

                }
            }
        }
    }
}
