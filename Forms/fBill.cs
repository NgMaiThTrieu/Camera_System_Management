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

namespace Camera_System_Management.Forms
{
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
            dgvBill.AutoGenerateColumns = false;
            dgvInvoiceDetail.AutoGenerateColumns = false;
        }

        BUS_Invoice _CMSBill = new BUS_Invoice();

        private void fBill_Load(object sender, EventArgs e)
        {
            dgvBill.DataSource = _CMSBill.displayListInvoice();
            dtpkStartDay.Value = DateTime.Now;
            dtpkEndDay.Value = DateTime.Now;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvBill.Rows[index];
                string invd = row.Cells[0].Value.ToString();
                dgvInvoiceDetail.DataSource = _CMSBill.displayListInvoiceDetail(invd);
            }
        }
    }
}
