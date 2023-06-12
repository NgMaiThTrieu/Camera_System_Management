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
using System.Threading;
using BUS;
using DTO;

namespace Camera_System_Management.Forms
{
    public partial class fTimeKeeping : Form
    {
        private BUS_TimeKeeping _timeKeeping = new BUS_TimeKeeping();

        public fTimeKeeping()
        {
            InitializeComponent();
            dgvPersonnel.AutoGenerateColumns = false;
            
        }


        private void fUser_Load(object sender, EventArgs e)
        {
            dgvPersonnel.DataSource = _timeKeeping.LoadListStaffOn1();
            

        }

        private void dgvPersonnel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {         
            
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fUser_Load(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPersonnel.DataSource = _timeKeeping.Sreach_TimeKeeping(txtSearch.Text);
        }

        private void dgvPersonnel_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fUser_Load(sender, e);
            int ind = e.RowIndex;
            if(ind >= 0)
            {
                DataGridViewRow row = dgvPersonnel.Rows[ind];

                if (_timeKeeping.GetStatus((row.Cells[0].Value.ToString())) == 0)
                {
                    fLogin_Staff f = new fLogin_Staff(row.Cells[0].Value.ToString());
                    f.Show();
                    
                }
                else
                {
                    
                    fLogoutStaff f = new fLogoutStaff((row.Cells[0].Value.ToString()));
                    f.Show();
                }

            }
            
        }
    }
}
