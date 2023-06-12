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
    public partial class fProductDiscount : Form
    {
        BUS_Discount _busDis = new BUS_Discount();
        public fProductDiscount()
        {
            InitializeComponent();
            cbbFillter.SelectedItem = 0;
        }

        private void fProductDiscount_Load(object sender, EventArgs e)
        {
            _busDis.autoUpdateDis();
            dgvDiscount.DataSource = _busDis._loadL_Discount();
        }

        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow row = dgvDiscount.Rows[index];
                txtDiscountID.Text = row.Cells[0].Value.ToString();
                txtDiscount.Text = row.Cells[1].Value.ToString();
                dtpFirstDay.Text = row.Cells[2].Value.ToString();
                dtpLastDay.Text = row.Cells[3].Value.ToString();

            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDiscount.Text.Trim();
            txtDiscountID.Text.Trim();
            if (string.IsNullOrEmpty(txtDiscount.Text)|| string.IsNullOrEmpty(txtDiscountID.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            DTO_Discount dis = new DTO_Discount()
            {
                Dis_ID = txtDiscountID.Text,
                Dis_Money = float.Parse(txtDiscount.Text),
                FirstDay = dtpFirstDay.Value,
                LastDay = dtpLastDay.Value,
            };

            if (_busDis.addDiscount(dis))
            {
                fProductDiscount_Load(sender, e);
                txtDiscountID.Text = String.Empty;
                txtDiscount.Text = String.Empty;
                dtpFirstDay.Text = String.Empty;
                dtpLastDay.Text = String.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.THEM_THAT_BAI);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtDiscountID.Text.Trim();
            if (string.IsNullOrEmpty(txtDiscountID.Text))
            {
                MessageBox.Show(DTO_Contants.VUI_LONG_CHON);
                return;
            }
            DTO_Discount dis = new DTO_Discount()
            {
                Dis_ID = txtDiscountID.Text,
                Dis_Money = float.Parse(txtDiscount.Text),
                FirstDay = dtpFirstDay.Value,
                LastDay = dtpLastDay.Value,
            };

            if (_busDis.deleteDiscount(dis))
            {
                fProductDiscount_Load(sender, e);
                txtDiscountID.Text = String.Empty;
                txtDiscount.Text = String.Empty;
                dtpFirstDay.Text = String.Empty;
                dtpLastDay.Text = String.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.CHANGE);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtDiscountID.Text.Trim();
            if (string.IsNullOrEmpty(txtDiscountID.Text))
            {
                MessageBox.Show(DTO_Contants.VUI_LONG_CHON);
                return;
            }

            DTO_Discount dis = new DTO_Discount()
            {
                Dis_ID = txtDiscountID.Text,
                Dis_Money = float.Parse(txtDiscount.Text),
                FirstDay = dtpFirstDay.Value,
                LastDay = dtpLastDay.Value,
            };

            if (_busDis.updateDiscount(dis))
            {
                fProductDiscount_Load(sender, e);
                txtDiscountID.Text = String.Empty;
                txtDiscount.Text = String.Empty;
                dtpFirstDay.Text = String.Empty;
                dtpLastDay.Text = String.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.SUA_KTHANH_CONG);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvDiscount.DataSource = _busDis.searchDis(txtSearch.Text);
        }

        private void cbbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbFillter.SelectedIndex != 0)
            {
                dgvDiscount.DataSource = _busDis.fillterDis(cbbFillter.SelectedIndex);
            }
            else
            {
                fProductDiscount_Load(sender, e);
            }
            
        }
    }
}
