using FontAwesome.Sharp;
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
    public partial class fSell : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtnPanelProduct;
        private Panel leftBorderBtnPanelBrand;
        private int countRow, Quantity;
        private double TotalPrice = 0.0;
        public int bID = 1;


        public fSell()
        {
            InitializeComponent();

            leftBorderBtnPanelProduct = new Panel();
            leftBorderBtnPanelProduct.Size = new Size(5, 41);
            panelProduct.Controls.Add(leftBorderBtnPanelProduct);

            leftBorderBtnPanelBrand = new Panel();
            leftBorderBtnPanelBrand.Size = new Size(5, 41);
            panelBrand.Controls.Add(leftBorderBtnPanelBrand);

            dgvProduct.AutoGenerateColumns = false;
            dgvBillDetail.AutoGenerateColumns = false;
        }


        private BUS_Sell _CMSProduct = new BUS_Sell();

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

        private void fCartShopping_Load(object sender, EventArgs e)
        {
            string Temp;
            dgvProduct.DataSource = _CMSProduct.LoadAllBill();
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                Temp = dgvProduct.Rows[i].Cells[0].Value.ToString().Substring(4, dgvProduct.Rows[i].Cells[0].Value.ToString().Length - 4);

                if (bID < int.Parse(Temp))
                {
                    bID = int.Parse(Temp);
                }
            }
            bID++;
            lblInvoiceID.Text = string.Format("BILL{0}", bID < 10 ? "0" + bID.ToString() : bID.ToString());

            cbbPersonnelName.DataSource = _CMSProduct.displayStaff();
            cbbPersonnelName.DisplayMember = "FullName";
            cbbPersonnelName.ValueMember = "ID";

            cbbClientName.DataSource = _CMSProduct.displayClient();
            cbbClientName.DisplayMember = "FullName";
            cbbClientName.ValueMember = "ClientID";

            dgvProduct.DataSource = _CMSProduct.displayListProduct();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProduct.Rows[index];
                lblProductID.Text = row.Cells[0].Value.ToString();
                lblProductName.Text = row.Cells[1].Value.ToString();
                lblDiscounts.Text = row.Cells[4].Value.ToString();
                txtPrice.Text = row.Cells[6].Value.ToString();

                if (nudQuantity.Value != 0)
                    lblProductPrice.Text = row.Cells[6].Value.ToString();

                nudQuantity.Value = 1;

            }
        }

        private void dgvBillDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvBillDetail.Rows[index];
                lblProductID.Text = row.Cells[0].Value.ToString();
                lblProductName.Text = row.Cells[1].Value.ToString();
                nudQuantity.Text = row.Cells[2].Value.ToString();
                lblProductPrice.Text = row.Cells[3].Value.ToString();
                Quantity = Convert.ToInt32(row.Cells[3].Value.ToString());
            }
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelProduct, leftBorderBtnPanelBrand);
            dgvProduct.DataSource = _CMSProduct.displayListProduct();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelProduct, leftBorderBtnPanelBrand);
            string sType = "Body";
            dgvProduct.DataSource = _CMSProduct.displayListProductType(sType);
        }

        private void btnLen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelProduct, leftBorderBtnPanelBrand);
            string sType = "Len";
            dgvProduct.DataSource = _CMSProduct.displayListProductType(sType);
        }

        private void btnFlashLight_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelProduct, leftBorderBtnPanelBrand);
            string sType = "FlashLight";
            dgvProduct.DataSource = _CMSProduct.displayListProductType(sType);
        }

        private void btnBattery_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelProduct, leftBorderBtnPanelBrand);
            string sType = "Battery";
            dgvProduct.DataSource = _CMSProduct.displayListProductType(sType);
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelProduct, leftBorderBtnPanelBrand);
            string sType = "Charge";
            dgvProduct.DataSource = _CMSProduct.displayListProductType(sType);
        }

        private void btnTripod_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelProduct, leftBorderBtnPanelBrand);
            string sType = "Tripod";
            dgvProduct.DataSource = _CMSProduct.displayListProductType(sType);
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelProduct, leftBorderBtnPanelBrand);
            string sType = "Memory";
            dgvProduct.DataSource = _CMSProduct.displayListProductType(sType);
        }

        private void btnBalo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelProduct, leftBorderBtnPanelBrand);
            string sType = "Balo";
            dgvProduct.DataSource = _CMSProduct.displayListProductType(sType);
        }

        private void btnCanon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelBrand, leftBorderBtnPanelProduct);
            string sType = "Canon";
            dgvProduct.DataSource = _CMSProduct.displayListProductSupplier(sType);
        }

        private void btnNikon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelBrand, leftBorderBtnPanelProduct);
            string sType = "Nikon";
            dgvProduct.DataSource = _CMSProduct.displayListProductSupplier(sType);
        }

        private void btnSony_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelBrand, leftBorderBtnPanelProduct);
            string sType = "Sony";
            dgvProduct.DataSource = _CMSProduct.displayListProductSupplier(sType);
        }

        private void btnFujifilm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelBrand, leftBorderBtnPanelProduct);
            string sType = "Fujifilm";
            dgvProduct.DataSource = _CMSProduct.displayListProductSupplier(sType);
        }

        private void btnLibec_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelBrand, leftBorderBtnPanelProduct);
            string sType = "Libec";
            dgvProduct.DataSource = _CMSProduct.displayListProductSupplier(sType);
        }

        private void btnGitzo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelBrand, leftBorderBtnPanelProduct);
            string sType = "Gitzo";
            dgvProduct.DataSource = _CMSProduct.displayListProductSupplier(sType);
        }

        private void btnVanguard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Khaki, leftBorderBtnPanelBrand, leftBorderBtnPanelProduct);
            string sType = "Vanguard";
            dgvProduct.DataSource = _CMSProduct.displayListProductSupplier(sType);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblProductPrice.Text != "" && lblProductID.Text != "ProductID" && lblProductName.Text != "ProductName")
            {
                DTO_Product prod = new DTO_Product()
                {
                    ProductName = lblProductName.Text,
                    ProductQuantity = Convert.ToInt32(nudQuantity.Value)
                };

                if (_CMSProduct.updateQuantityProduct(prod))
                {
                    bID--;
                    fCartShopping_Load(sender, e);

                    countRow = dgvBillDetail.Rows.Add();
                    dgvBillDetail.Rows[countRow].Cells[0].Value = lblProductID.Text;
                    dgvBillDetail.Rows[countRow].Cells[1].Value = lblProductName.Text;
                    dgvBillDetail.Rows[countRow].Cells[2].Value = nudQuantity.Value;
                    dgvBillDetail.Rows[countRow].Cells[3].Value = lblProductPrice.Text;

                    TotalPrice += Convert.ToDouble(lblProductPrice.Text);
                    lblTotalBill.Text = TotalPrice.ToString();

                }
                else
                    MessageBox.Show("The number of products in stock is not enough");
            }
            else
            {
                MessageBox.Show("You have not entered enough data");
            }

            lblProductID.Text = "ProductID";
            lblProductName.Text = "ProductName";
            nudQuantity.Value = 0;
            lblProductPrice.Text = "";
            lblDiscounts.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lblProductPrice.Text != "" && lblProductID.Text != "ProductID" && lblProductName.Text != "ProductName")
            {
                dgvBillDetail.Rows.RemoveAt(this.dgvBillDetail.SelectedRows[0].Index);
                TotalPrice -= Quantity;
                lblTotalBill.Text = TotalPrice.ToString();

                DTO_Product prod = new DTO_Product()
                {
                    ProductName = lblProductName.Text,
                    ProductQuantity = Convert.ToInt32(nudQuantity.Value)
                };

                if (_CMSProduct.updateQuantityProduct1(prod))
                {
                    bID--;
                    fCartShopping_Load(sender, e);
                }
            }

            lblProductID.Text = "ProductID";
            lblProductName.Text = "ProductName";
            nudQuantity.Value = 0;
            lblProductPrice.Text = "";
            lblDiscounts.Text = "";
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProduct.Rows[index];
                string sql = row.Cells[0].Value.ToString();
                fBodyDetail f = new fBodyDetail(sql);
                f.Show();
            }
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lblTotalBill.Text != "")
            {

                DTO_Invoice ivc = new DTO_Invoice()
                {
                    StaffID = cbbPersonnelName.SelectedValue.ToString(),
                    InvoiceID = lblInvoiceID.Text,
                    ClientID = cbbClientName.SelectedValue.ToString(),
                    InvoiceDay = DateTime.Now,
                    TotalPrice = Convert.ToDecimal(lblTotalBill.Text),
                };

                DTO_Client cli = new DTO_Client()
                {
                    ClientID = cbbClientName.SelectedValue.ToString(),
                    AccumulationPoints = Convert.ToInt32(lblTotalBill.Text) / 1000,
                };

                if (_CMSProduct.addBill(ivc) && _CMSProduct.updatePoints(cli))
                {
                    for (int i = 0; i < dgvBillDetail.Rows.Count; i++)
                    {
                        DTO_InvoiceDetails ivcd = new DTO_InvoiceDetails()
                        {
                            InvoiceID = lblInvoiceID.Text,
                            ProductID = dgvBillDetail.Rows[i].Cells[0].Value.ToString(),
                            InvoiceQuantity = Convert.ToInt32(dgvBillDetail.Rows[i].Cells[2].Value.ToString())
                        };

                        _CMSProduct.addInvoiceDetails(ivcd);
                    }
                    MessageBox.Show("Successful Invoice");
                    dgvBillDetail.Rows.Clear();
                    bID++;
                    lblTotalBill.Text = "";
                }
                else
                    MessageBox.Show("Successful Invoice");
            }
            else
            {
                MessageBox.Show("Invoicing failed");
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            fClient f = new fClient();
            f.Show();
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = _CMSProduct.searchProduct(txtSearch.Text);
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {

            if (lblProductID.Text != "ProductID" && nudQuantity.Value != 0)
            {
                int Quantity = Convert.ToInt32(nudQuantity.Value);
                double Price = Convert.ToDouble(txtPrice.Text), Discount;
               
                if (lblDiscounts.Text != "")
                {
                    Discount = Convert.ToDouble(lblDiscounts.Text);
                    double dTotal = Quantity * (Price - (Price * (Discount / 1000)));
                    lblProductPrice.Text = dTotal.ToString();
                }
                else
                {
                    double dTotal = Quantity * Price;
                    lblProductPrice.Text = dTotal.ToString();
                }
            }
            else 
                lblProductPrice.Text = "";
        }
    }
}
