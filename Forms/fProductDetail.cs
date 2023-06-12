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
    public partial class fProductDetail : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6GL392S1\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");

        public fProductDetail()
        {
            InitializeComponent();
        }

        private void fProductDetail_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BODYDETAIL";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "BODYDETAIL");
                dgvProductDetail.DataSource = ds.Tables["BODYDETAIL"].DefaultView;
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }


            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT [PRODUCT NAME] FROM PRODUCT", conn);
                da.Fill(dt);
                cbbProductName.DisplayMember = String.Format("PRODUCT NAME");
                cbbProductName.DataSource = dt;
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
    }
}
