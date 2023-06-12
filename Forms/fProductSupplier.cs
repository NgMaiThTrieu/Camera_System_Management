using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Camera_System_Management.Forms
{
    public partial class fProductSupplier : Form
    {
        BUS_Supplier _busSupp= new BUS_Supplier();
        public fProductSupplier()
        {
            InitializeComponent();

            dgvProductSupplier.AutoGenerateColumns=false;
        }

        private void fProductSupplier_Load(object sender, EventArgs e)
        {
            dgvProductSupplier.DataSource = _busSupp.loadL_Supp();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            txtSupplier.Text.Trim();
            if (string.IsNullOrEmpty(txtSupplier.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            DTO_Supplier Supp = new DTO_Supplier()
            {
                Supp_Name = txtSupplier.Text,
            };

            if (_busSupp.addSupp(Supp))
            {
                fProductSupplier_Load(sender, e);
                txtSupplier.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.THEM_THAT_BAI);
            }
        }

        private void dgvProductSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index != -1)
            {
                DataGridViewRow row = dgvProductSupplier.Rows[index];
                txtSupplierCode.Text = row.Cells[0].Value.ToString();
                txtSupplier.Text= row.Cells[1].Value.ToString();
            }
        }

        private void txtSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplier.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            DTO_Supplier Supp = new DTO_Supplier()
            {
                Supp_Name=txtSupplier.Text,
                Supp_ID = int.Parse(txtSupplierCode.Text)
            };
            if (_busSupp.deleteSupp(Supp))
            {
                fProductSupplier_Load(sender, e);
                txtSupplier.Text = string.Empty;
                txtSupplierCode.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.XOA_KTHANH_CONG);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtSupplier.Text.Trim();
            if (string.IsNullOrEmpty(txtSupplier.Text)||string.IsNullOrEmpty(txtSupplierCode.Text))
            {
                MessageBox.Show(DTO_Contants.VUI_LONG_CHON);
                return;
            }

            DTO_Supplier Supp = new DTO_Supplier()
            {
                Supp_Name = txtSupplier.Text,
                Supp_ID = int.Parse(txtSupplierCode.Text)
            };
            if (_busSupp.updateSupp(Supp))
            {
                fProductSupplier_Load(sender, e);
                txtSupplier.Text = string.Empty;
                txtSupplierCode.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.SUA_KTHANH_CONG);
            }
        }
    }
}
