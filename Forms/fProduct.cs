using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Camera_System_Management.Forms
{
    public partial class fProduct : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtnPanelProduct;
        private Panel leftBorderBtnPanelBrand;

        BUS_Product _busProd = new BUS_Product();
        BUS_ProdType _busProdType = new BUS_ProdType();
        BUS_Supplier _busSupplier = new BUS_Supplier();
        BUS_Origin _busOrigin = new BUS_Origin();
        BUS_Discount _busDiscount = new BUS_Discount();
        BUS_GoodReceiptDetails _busGR=new BUS_GoodReceiptDetails();

        private BUS_Login _login = new BUS_Login();
        public string ID;

        public fProduct()
        {
            InitializeComponent();
            leftBorderBtnPanelProduct = new Panel();
            leftBorderBtnPanelProduct.Size = new Size(5, 41);
            panelProduct.Controls.Add(leftBorderBtnPanelProduct);

            leftBorderBtnPanelBrand = new Panel();
            leftBorderBtnPanelBrand.Size = new Size(5, 41);
            panelBrand.Controls.Add(leftBorderBtnPanelBrand);

            dgvProduct.AutoGenerateColumns = false;
        }



        private void ActivateButton(object senderBtn, Color color, Panel currentType, Panel leftBorderBtn)
        {
            DisableButton(leftBorderBtn);
            //Button
            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = Color.Black;
            currentBtn.ForeColor = color;
            currentBtn.IconColor = color;

            //Left border button
            currentType.BackColor = color;
            currentType.Location = new Point(0, currentBtn.Location.Y);
            currentType.Visible = true;
            currentType.BringToFront();
        }

        private void DisableButton(Panel leftBorderBtn)
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Black;
                currentBtn.ForeColor = Color.Khaki;
                currentBtn.IconColor = Color.Khaki;
                leftBorderBtn.Visible = false;
            }
        }

        public void addButton(string temp)
        {
            FontAwesome.Sharp.IconButton btn = new FontAwesome.Sharp.IconButton();
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("ROG Fonts", 10F);
            btn.ForeColor = System.Drawing.Color.Khaki;
            btn.IconChar = FontAwesome.Sharp.IconChar.Expand;
            btn.IconColor = System.Drawing.Color.Khaki;
            btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn.IconSize = 32;
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //btn.Location = new System.Drawing.Point(15, 97);
            btn.Name = "btn" + temp;
            btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btn.Size = new System.Drawing.Size(212, 41);
            btn.TabIndex = 22;
            btn.Text = temp;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn.UseVisualStyleBackColor = true;
            panelProduct.Controls.Add(btn);
            btn.Click += (sender, args) =>
            {
                MessageBox.Show(btn.Text);
            };
        }

        private void fProduct_Load(object sender, EventArgs e)
        {
            cbbType.DataSource = _busProdType.loadL_ProdType();
            cbbType.DisplayMember = "ProductType";
            cbbType.ValueMember = "ProductType_ID";

            cbbSupplier.DataSource = _busSupplier.loadL_Supp();
            cbbSupplier.DisplayMember = "Supp_Name";
            cbbSupplier.ValueMember = "Supp_ID";

            cbbOrigin.DataSource=_busOrigin._loadL_Ori();
            cbbOrigin.DisplayMember = "Origin";
            cbbOrigin.ValueMember = "Ori_ID";

            cbbDiscount.DataSource = _busDiscount._loadL_Discount();
            cbbDiscount.DisplayMember = "Dis_Money";
            cbbDiscount.ValueMember = "Dis_ID";

            cboGoodsReceipt.DataSource = _busGR.loadL_GR();
            cboGoodsReceipt.DisplayMember = "GR_ID";

            dgvProduct.DataSource = _busProd._loadLProduct();

            foreach (var u in _busProdType.loadL_ProdType())
            {
                addButton(u.ProductType);
            }
        }

       
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProduct.Rows[index];
                txtProductCode.Text = row.Cells[0].Value.ToString();
                txtProductName.Text = row.Cells[1].Value.ToString();
                cbbType.Text = row.Cells[2].Value.ToString();
                cbbSupplier.Text = row.Cells[3].Value.ToString();
                cbbOrigin.Text = row.Cells[4].Value.ToString();
                txtCornerPrice.Text = row.Cells[5].Value.ToString();
                txtSalePrice.Text = row.Cells[6].Value.ToString();
                txtQuantity.Text = row.Cells[7].Value.ToString();
                cbbDiscount.Text=row.Cells[8].Value.ToString();
            }
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            fProductType f = new fProductType();
            f.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            fProductSupplier f = new fProductSupplier();
            f.Show();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            fProductDiscount f = new fProductDiscount();
            f.Show();
        }

        private void btnOrigin_Click_1(object sender, EventArgs e)
        {
            fProductOrigin f = new fProductOrigin();
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtSalePrice.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            DTO_Product1 Prod = new DTO_Product1()
            {
                Prod_ID = txtProductCode.Text,
                ProdName = txtProductName.Text,
                ProdType_ID = (int)cbbType.SelectedValue,
                Supp_ID = (int)cbbSupplier.SelectedValue,
                Ori_ID = (int)cbbOrigin.SelectedValue,
                Prod_Quantity = int.Parse(txtQuantity.Text),
                GR_ID = cboGoodsReceipt.Text,
                Prirce=decimal.Parse(txtSalePrice.Text),
                Dis_ID=cbbDiscount.SelectedValue.ToString(),
            };

            if (_busProd.AddProd(Prod))
            {
                fProduct_Load(sender, e);
                MessageBox.Show(DTO_Contants.THEM_THANH_CONG);
            }
            else
            {
                MessageBox.Show(DTO_Contants.THEM_THAT_BAI);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductCode.Text))
            {
                MessageBox.Show(DTO_Contants.VUI_LONG_CHON);
                return;
            }

            DTO_ProductAllIfo Prod = new DTO_ProductAllIfo()
            {
                Prod_ID = txtProductCode.Text
            };

            if (_busProd.DeleteProd(Prod))
            {
                fProduct_Load(sender, e);
                MessageBox.Show(DTO_Contants.XOA_THANH_CONG);
            }
            else
            {
                MessageBox.Show(DTO_Contants.XOA_KTHANH_CONG);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtSalePrice.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show(DTO_Contants.NHAP_THONG_TIN);
                return;
            }

            DTO_Product1 Prod = new DTO_Product1()
            {
                Prod_ID = txtProductCode.Text,
                ProdName = txtProductName.Text,
                ProdType_ID = (int)cbbType.SelectedValue,
                Supp_ID = (int)cbbSupplier.SelectedValue,
                Ori_ID = (int)cbbOrigin.SelectedValue,
                Prod_Quantity = int.Parse(txtQuantity.Text),
                GR_ID = cboGoodsReceipt.Text,
                Prirce = decimal.Parse(txtSalePrice.Text),
                Dis_ID = cbbDiscount.SelectedValue.ToString(),
            };

            if (_busProd.UpdateProd(Prod))
            {
                fProduct_Load(sender, e);
                MessageBox.Show(DTO_Contants.SUA_THANG_CONG);
            }
            else
            {
                MessageBox.Show(DTO_Contants.SUA_KTHANH_CONG);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = _busProd._searchProd(txtSearch.Text);
        }
    }
}
