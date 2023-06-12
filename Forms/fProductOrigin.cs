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
    public partial class fProductOrigin : Form
    {
        BUS_Origin _busOri = new BUS_Origin();
        public fProductOrigin()
        {
            InitializeComponent();
            dgvProductOrigin.AutoGenerateColumns = false;
        }

        private void fProductOrigin_Load(object sender, EventArgs e)
        {
            dgvProductOrigin.DataSource = _busOri._loadL_Ori();
        }

        private void dgvProductOrigin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow row = dgvProductOrigin.Rows[index];
                txtOriginCode.Text = row.Cells[0].Value.ToString();
                txtOriginName.Text = row.Cells[1].Value.ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOriginName.Text.Trim();
            if (string.IsNullOrEmpty(txtOriginName.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            DTO_Origin Ori = new DTO_Origin()
            {
                Origin = txtOriginName.Text,
            };
            if (_busOri.addOri(Ori))
            {
                fProductOrigin_Load(sender, e);
                txtOriginName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.THEM_THAT_BAI);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOriginCode.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            DTO_Origin Ori = new DTO_Origin()
            {
                Origin = txtOriginName.Text,
                Ori_ID = int.Parse(txtOriginCode.Text)
            };
            if (_busOri.deleteOri(Ori))
            {
                fProductOrigin_Load(sender, e);
                txtOriginName.Text = string.Empty;
                txtOriginCode.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.XOA_KTHANH_CONG);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtOriginName.Text.Trim();

            if (string.IsNullOrEmpty(txtOriginCode.Text) || string.IsNullOrEmpty(txtOriginName.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            DTO_Origin Ori = new DTO_Origin()
            {
                Origin = txtOriginName.Text,
                Ori_ID = int.Parse(txtOriginCode.Text)
            };
            if (_busOri.updateOri(Ori))
            {
                fProductOrigin_Load(sender, e);
                txtOriginName.Text = string.Empty;
                txtOriginCode.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(DTO_Contants.SUA_KTHANH_CONG);
            }
        }

        private void txtOriginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar)){
                e.Handled=true;
            }
        }
    }
}
