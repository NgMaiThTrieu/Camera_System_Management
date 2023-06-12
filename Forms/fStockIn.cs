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
using DTO;

namespace Camera_System_Management.Forms
{
    public partial class fStockIn : Form
    {
        BUS_GoodReceiptDetails _busGR= new BUS_GoodReceiptDetails();
        BUS_Product _busProd= new BUS_Product();
        BUS_Staff _busStaff= new BUS_Staff();
        public fStockIn()
        {
            InitializeComponent();

            dgvGoodsReceiptNote.AutoGenerateColumns=false;
        }

        

        private void fStockIn_Load(object sender, EventArgs e)
        {
            dgvGoodsReceiptNote.DataSource = _busGR.loadL_GR();
            cbbProd.DataSource = _busProd._loadLProd2();
            cbbProd.DisplayMember = "Prod_ID";
            cbbProd.ValueMember = "Prod_ID";

            cboStaffID.DataSource = _busStaff.LoadListStaff();
            cboStaffID.DisplayMember = "FirstName"+" "+"LastName";
            cboStaffID.ValueMember = "Staff_ID";
        }

        private void dgvGoodsReceiptNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index=e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow row=dgvGoodsReceiptNote.Rows[index];
                txtNoteCode.Text= row.Cells[0].Value.ToString();
                cboStaffID.Text= row.Cells[1].Value.ToString();
                dtpGR.Text= row.Cells[3].Value.ToString();
            }
        }

        private void dgvGoodsReceiptNote_DoubleClick(object sender, EventArgs e)
        {
            dgvImportGoods.DataSource= _busGR.loadL_GRDetails(txtNoteCode.Text);
        }

        private void dgvImportGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow row = dgvImportGoods.Rows[index];
                txtGRID.Text= row.Cells[0].Value.ToString();
                txtLotID.Text= row.Cells[1].Value.ToString();
                cbbProd.SelectedValue = row.Cells[2].Value.ToString();
                txtOriginprice.Text= row.Cells[3].Value.ToString();
                txtQuantity.Text= row.Cells[4].Value.ToString();
            }
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            fProduct f= new fProduct();
            f.Show();
            this.Hide();
        }

        private void btnCreateAcount_Click(object sender, EventArgs e)
        {
            int i = DTO_Contants.Gia_Tri_1;
            do
            {
                txtNoteCode.Text = String.Format("GR{0}", (_busGR.loadL_GR().Count).ToString("000"));
                i++;
            } while (_busGR.loadL_GR().SingleOrDefault(u => u.GR_ID == txtNoteCode.Text) != null);


        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtOriginprice.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            int i = DTO_Contants.Gia_Tri_1;
            do
            {
                txtLotID.Text = String.Format("L{0}", (_busGR.loadL_GR().Count + i).ToString("000"));
                i++;
            } while (_busGR.loadL_GR().SingleOrDefault(u => u.GR_ID == txtLotID.Text) != null);
            txtGRID.Text = txtNoteCode.Text;

            DTO_GRDetail gr = new DTO_GRDetail()
            {
                GR_ID = txtGRID.Text,
                Lot_ID = txtLotID.Text,
                Product_ID = cbbProd.SelectedValue.ToString(),
                OriginalPrice = decimal.Parse(txtOriginprice.Text),
                GR_Quantity = int.Parse(txtQuantity.Text)
            };
        
            if (_busGR.addGRDt(gr))
            {
                dgvGoodsReceiptNote_DoubleClick(sender, e);
                MessageBox.Show(DTO_Contants.THEM_THANH_CONG);
            }
            else
            {
                MessageBox.Show(DTO_Contants.THEM_THAT_BAI);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DTO_GRDetail gr = new DTO_GRDetail()
            {
                GR_ID = txtGRID.Text,
                Lot_ID = txtLotID.Text,
                Product_ID = cbbProd.SelectedValue.ToString(),
                OriginalPrice = decimal.Parse(txtOriginprice.Text),
                GR_Quantity = int.Parse(txtQuantity.Text)
            };

            if (_busGR.updateDRDt(gr))
            {
                dgvGoodsReceiptNote_DoubleClick(sender, e);
                MessageBox.Show(DTO_Contants.SUA_THANG_CONG);
            }
            else
            {
                MessageBox.Show(DTO_Contants.SUA_KTHANH_CONG);
            }
        }
    }
}
