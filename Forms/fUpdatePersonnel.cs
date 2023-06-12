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
    public partial class fUpdatePersonnel : Form
    {
        public fUpdatePersonnel()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=LAPTOP-6GL392S1\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True";

        private void btnUpDate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtPersonCode.Text) || string.IsNullOrEmpty(txtNumberPhone.Text) || string.IsNullOrEmpty(txtGmail.Text))
            {
                MessageBox.Show("Please enter full personal information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPersonCode.Text.Length != 12)
            {
                MessageBox.Show("Invalid person code", "Nofity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DateTime.Now < dateTimePickerBirdthDay.Value)
            {
                MessageBox.Show("Year of birth must be less than current date", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerBirdthDay.Value = DateTime.Now;
            }
            else if (DateTime.Now.Year - Convert.ToInt32(dateTimePickerBirdthDay.Value.Year) < 18)
            {
                MessageBox.Show("Year of birth must be 18 years old", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerBirdthDay.Value = DateTime.Now;
            }
            else if (txtNumberPhone.Text.Length != 10)
            {
                MessageBox.Show("Invalid number phone", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sDecentralization, sPosition, sFirstName, sLastName, sPersonCode, sSex, sBirthDay, sProvince, sNumberPhone, sEmail;
                String sEmployeeCode, sJobCode;
                sDecentralization = cbbDecentralization.Text;
                sPosition = cbbPosition.Text;
                sFirstName = txtFirstName.Text;
                sLastName = txtLastName.Text;
                sPersonCode = txtPersonCode.Text;
                sSex = cbbSex.Text;
                sBirthDay = dateTimePickerBirdthDay.Value.ToString();
                sProvince = cbbProvince.Text;
                sNumberPhone = txtNumberPhone.Text;
                sEmail = txtGmail.Text;

                if (sPosition == "Personnel")
                    sEmployeeCode = "PSN";
                else

                    sEmployeeCode = "AD";
                if (sDecentralization == "Manage")
                    sJobCode = "MNG";
                else if (sDecentralization == "Sell")
                    sJobCode = "SL";
                else if (sDecentralization == "Cashier")
                    sJobCode = "CH";
                else
                    sJobCode = "TK";

                string query = string.Format("INSERT INTO PERSONNEL ([EMPLOYEE CODE], [JOB CODE],[FIRST NAME],[LAST NAME],[PERSON CODE],SEX,[BIRTH DAY],PROVINCE,[NUMBER PHONE],EMAIL,SARALY) " +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", sEmployeeCode, sJobCode, sFirstName, sLastName, sPersonCode, sSex, sBirthDay, sProvince, sNumberPhone, sEmail, 1000000);
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowCount = cmd.ExecuteNonQuery();

                if (rowCount == 1)
                    MessageBox.Show("Successfully updated personal information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Personal information update failed", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFirstName.Clear();
                txtLastName.Clear();
                txtNumberPhone.Clear();
                txtPersonCode.Clear();
                cbbSex.StartIndex = 0;
                dateTimePickerBirdthDay.Value = DateTime.Now;
                txtGmail.Clear();
                cbbProvince.StartIndex = 57;
                txtNumberPhone.Clear();
            }
        }

        private void txtPersonCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void txtFirstName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void txtLastName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPersonCode_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNumberPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPersonCode_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPersonCode.Text.Length == 12)
                iconPtCheckPersonCode.Visible = true;
            else
                iconPtCheckPersonCode.Visible = false;
        }

        private void txtNumberPhone_TextChanged_1(object sender, EventArgs e)
        {
            if (txtNumberPhone.Text.Length == 10)
                iconPtCheck.Visible = true;
            else
                iconPtCheck.Visible = false;
          
        }

        private void cbbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
