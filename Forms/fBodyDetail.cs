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
    public partial class fBodyDetail : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6GL392S1\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");


        public fBodyDetail(string Sql)
        {
            InitializeComponent();
            try
            {
                String querry = String.Format("SELECT [PRODUCT NAME], [CHIP], [SENSOR (CMOS)], [AUTO FOCUS (AF)], [INTERNATIONAL ORGANISATION (ISO)], [SHUTTER SPEED], [VIDEO] FROM BODYDETAIL WHERE [PRODUCT CODE] = '{0}'", Sql);
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dTable = new DataTable();
                sda.Fill(dTable);
                lblProductName.Text = dTable.Rows[0][0].ToString();
                lblChip.Text = dTable.Rows[0][1].ToString();
                lblSensor.Text = dTable.Rows[0][2].ToString();
                lblAutoFocus.Text = dTable.Rows[0][3].ToString();
                lblInternationelOrganisation.Text = dTable.Rows[0][4].ToString();
                lblShutterSpeed.Text = dTable.Rows[0][5].ToString();
                lblVideo.Text = dTable.Rows[0][6].ToString();
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

        private void fBodyDetail_Load(object sender, EventArgs e)
        {
            
        }
    }
}
