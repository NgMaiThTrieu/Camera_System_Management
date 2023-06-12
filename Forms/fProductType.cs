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
    public partial class fProductType : Form
    {
        BUS_ProdType _busPT= new BUS_ProdType();
        public fProductType()
        {
            InitializeComponent();

            dgvProductType.AutoGenerateColumns=false;
        }

        private void dgvProductType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index= e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow row=dgvProductType.Rows[index];
                txtTypeCode.Text=row.Cells[0].Value.ToString();
                txtProductTName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void fProductType_Load(object sender, EventArgs e)
        {
            dgvProductType.DataSource = _busPT.loadL_ProdType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtProductTName.Text.Trim();
            if (string.IsNullOrEmpty(txtProductTName.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            DTO_ProdType pT = new DTO_ProdType()
            {
                ProductType = txtProductTName.Text,
            };

            if (_busPT.addProdType(pT))
            {
                fProductType_Load(sender, e);
                txtProductTName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.THEM_THAT_BAI);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtProductTName.Text.Trim();
            if (string.IsNullOrEmpty(txtProductTName.Text))
            {
                MessageBox.Show(DTO_Contants.VUI_LONG_CHON);
                return;
            }

            DTO_ProdType pT = new DTO_ProdType()
            {
                ProductType = txtProductTName.Text,
                ProductType_ID = int.Parse(txtTypeCode.Text)
            };
            if (_busPT.deleteProdType(pT))
            {
                fProductType_Load(sender, e);
                txtTypeCode.Text = string.Empty;
                txtProductTName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.SUA_KTHANH_CONG);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtProductTName.Text.Trim();
            if (string.IsNullOrEmpty(txtProductTName.Text) || string.IsNullOrEmpty(txtTypeCode.Text))
            {
                MessageBox.Show(DTO_Contants.VUI_LONG_CHON);
                return;
            }

            DTO_ProdType pT = new DTO_ProdType()
            {
                ProductType = txtProductTName.Text,
                ProductType_ID = int.Parse(txtTypeCode.Text)
            };
            if (_busPT.updateProdType(pT))
            {
                fProductType_Load(sender, e);
                txtTypeCode.Text = string.Empty;
                txtProductTName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.SUA_KTHANH_CONG);
            }
        }

        private void txtProductTName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
