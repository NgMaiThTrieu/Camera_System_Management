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
using BUS;
using DTO;

namespace Camera_System_Management.Forms
{
    public partial class fMClient : Form
    {
        public fMClient()
        {
            InitializeComponent();
            dgvClient.AutoGenerateColumns = false;
        }

        BUS_Client _CMSClient = new BUS_Client();

        private void fCustomer_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = _CMSClient.displayClient();
        }

        private void cbbAccumulatedPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAccumulatedPoints.Text != "All")
            {
                int points = Convert.ToInt32(cbbAccumulatedPoints.Text);
                dgvClient.DataSource = _CMSClient.displayClientPoints(points);
            }
            else
            {
                dgvClient.DataSource = _CMSClient.displayClient();
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvClient.Rows[index];
                txtCustomerCode.Text = row.Cells[0].Value.ToString();
                txtFullname.Text = row.Cells[1].Value.ToString();
                txtNumberPhone.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            DTO_Client cli = new DTO_Client()
            {
                ClientID = txtCustomerCode.Text,
            };

            if (_CMSClient.removeClient(cli))
            {
                MessageBox.Show("Delete customer successfully");
                fCustomer_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Delete failed customers");
            }
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvClient.Rows[index];
                txtCustomerCode.Text = row.Cells[0].Value.ToString();
                txtFullname.Text = row.Cells[1].Value.ToString();
                txtNumberPhone.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            DTO_Client cli = new DTO_Client()
            {
                ClientID = txtCustomerCode.Text,
                FullName = txtFullname.Text,
                NumberPhone = txtNumberPhone.Text,
            };

            if (_CMSClient.editClient(cli))
            {
                MessageBox.Show("Successful customer update");
                fCustomer_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Client update failed");
            }
        }
    }
}
