using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace Camera_System_Management.Forms
{
    public partial class fSalary : Form
    {
        public fSalary()
        {
            InitializeComponent();
            dgvSalary.AutoGenerateColumns = false;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6GL392S1\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");

        BUS_Salary _CMSSalary = new BUS_Salary();

        private void SqlSelect(String sSql)
        {
            try
            {
                String querry = String.Format("SELECT * FROM SALARY {0}", sSql);
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "SALARY");
                dgvSalary.DataSource = ds.Tables["SALARY"].DefaultView;
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

        private void SqlSalary(String querry)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "SALARY");
                SqlSelect("");
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

        private void fSalary_Load(object sender, EventArgs e)
        {
            //SqlSelect("");
            //LoadComboBox();
            dgvSalary.DataSource = _CMSSalary.displaySalary();
        }

        public void LoadComboBox()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT [FULL NAME] FROM PERSONNEL", conn);
                da.Fill(dt);
                cbbFullName.DisplayMember = String.Format("FULL NAME");
                cbbFullName.DataSource = dt;
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

        private void dgvSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvSalary.Rows[index];
                cbbFullName.Text = row.Cells[0].Value.ToString();
                txtBasicSaraly.Text = row.Cells[2].Value.ToString();
                txtSalaryDeduction.Text = row.Cells[3].Value.ToString();
                cbbMouth.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String sFullName, sBasicSalary, sDeductionSalary, sMouth;
            sFullName = cbbFullName.Text;
            sBasicSalary = txtBasicSaraly.Text;
            sDeductionSalary = txtSalaryDeduction.Text;
            int sTotalSalary = Convert.ToInt32(sBasicSalary) - Convert.ToInt32(sDeductionSalary);
            sMouth = cbbMouth.Text;
            String sSql = String.Format("INSERT INTO SALARY ([FULL NAME], [SALARY], [SUBTRACT SALARY], [TOTAL SALARY], [MOUTH]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", sFullName, sBasicSalary, sDeductionSalary, sTotalSalary, sMouth);
            SqlSalary(sSql);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String sFullName;
            sFullName = cbbFullName.Text;
            String sSql = String.Format("DELETE FROM SALARY WHERE [FULL NAME] = '{0}'", sFullName);
            SqlSalary(sSql);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


            String sFullName = txtSearch.Text;
            String sSearch = String.Format("WHERE [FULL NAME] LIKE '%{0}%'", sFullName);
            SqlSelect(sSearch);
        }

        private void btnAssi_Click(object sender, EventArgs e)
        {
            fAssi f = new fAssi();
            f.Show();
        }
    }
}
