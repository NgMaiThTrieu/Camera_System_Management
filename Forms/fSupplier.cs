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
    public partial class fSupplier : Form
    {
        private int ImageNumber;
        public fSupplier()
        {
            InitializeComponent();
        }

        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6GL392S1\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");


        private void Slider()
        {
            //if (ImageNumber == 5)
            //{
            //    ImageNumber = 1;
            //}
            //pictureBoxSlider.ImageLocation = String.Format(@"Images\{0}.jpg", ImageNumber);
            //ImageNumber++;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Slider();
        }

        private void fSupplier_Load(object sender, EventArgs e)
        {
            SqlSelect("");
        }

        private void SqlSelect(String sSql)
        {
            //try
            //{
            //    String querry = String.Format("SELECT * FROM SUPPLIER {0}", sSql);
            //    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            //    DataSet ds = new DataSet();
            //    sda.Fill(ds, "SUPPLIER");
            //    dgvSupplier.DataSource = ds.Tables["SUPPLIER"].DefaultView;
            //}
            //catch
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void SqlSupplier(String querry)
        {
            //try
            //{
            //    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            //    DataSet ds = new DataSet();
            //    sda.Fill(ds, "SUPPLIER");
            //    SqlSelect("");
            //}
            //catch
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //if (e.RowIndex != -1)
            //{
            //    DataGridViewRow row = dgvSupplier.Rows[index];
            //    txtSupplierCode.Text = row.Cells[0].Value.ToString();
            //    txtSupplierName.Text = row.Cells[1].Value.ToString();
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //String sSupplierCode, sSupplierName;
            //sSupplierCode = txtSupplierCode.Text;
            //sSupplierName = txtSupplierName.Text;
            //String sSql = String.Format("INSERT INTO SUPPLIER ([SUPPLIER CODE], [SUPPLIER NAME]) VALUES ('{0}', '{1}')", sSupplierCode, sSupplierName);
            //SqlSupplier(sSql);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //String sSupplierCode;
            //sSupplierCode = txtSupplierCode.Text;
            //String sSql = String.Format("DELETE FROM SUPPLIER WHERE [SUPPLIER CODE] = '{0}'", sSupplierCode);
            //SqlSupplier(sSql);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //String sSupplierName = txtSearch.Text;
            //String sSearch = String.Format("WHERE [SUPPLIER NAME] LIKE '%{0}%'", sSupplierName);
            //SqlSelect(sSearch);
        }
    }

}
