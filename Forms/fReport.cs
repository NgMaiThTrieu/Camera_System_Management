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

namespace Camera_System_Management.Forms
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6GL392S1\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fReport_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM REPORT";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "REPORT");
                dgvReport.DataSource = ds.Tables["REPORT"].DefaultView;
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

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
