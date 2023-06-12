using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camera_System_Management.Forms;
using FontAwesome.Sharp;
using System.Threading;
using DTO;
using BUS;

namespace Camera_System_Management
{
    public partial class fCameraSystemManagement : Form
    {
        private IconButton currentBtn;
        private Button nextBtnAdmin;
        private Button nextBtnUser;
        private Panel leftBorderBtn;
        private Panel rightBorderBtnAdmin;
        //private Panel rightBorderBtnUser;
        private Form currentChildForm;

        private int ImageNumber = 1;
        private BUS_TimeKeeping _timeKeeping = new BUS_TimeKeeping();

        private BUS_Login _login = new BUS_Login();
        public string ID;

        public fCameraSystemManagement(string user)
        {
            InitializeComponent();
            customizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            ID = _login.GetIDByUN(user);

            rightBorderBtnAdmin = new Panel();
            rightBorderBtnAdmin.Size = new Size(5, 40);
            panelChildAdmin.Controls.Add(rightBorderBtnAdmin);

            //rightBorderBtnUser = new Panel();
            //rightBorderBtnUser.Size = new Size(5, 40);
            //panelChildUser.Controls.Add(rightBorderBtnUser);
        }

        private void customizeDesing()
        {
            panelChildAdmin.Visible = false;
            //panelChildUser.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelChildAdmin.Visible == true)
                panelChildAdmin.Visible = false;

            //if (panelChildUser.Visible == true)
            //    panelChildUser.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Black;
                currentBtn.ForeColor = color;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                rightBorderBtnAdmin.Visible = false;
                //rightBorderBtnUser.Visible = false;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Black;
                currentBtn.ForeColor = Color.Khaki;
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Khaki;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ActivateButtonChild(object senderBtn, Color color, Panel BorderBtn, Button nextBtn)
        {
            if (senderBtn != null)
            {
                DisableButtonChild(nextBtn);
                //Button
                nextBtn = (Button)senderBtn;

                nextBtn.BackColor = Color.Black;
                nextBtn.ForeColor = color;


                //Left border button
                BorderBtn.BackColor = color;
                BorderBtn.Location = new Point(33, nextBtn.Location.Y);
                BorderBtn.Visible = true;
                BorderBtn.BringToFront();
            }
        }

        private void DisableButtonChild(Button nextBtn)
        {
            if (nextBtn != null)
            {
                nextBtn.BackColor = Color.Black;
                nextBtn.ForeColor = Color.Khaki;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDeskTop.Controls.Add(childForm);
            panelDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Slider()
        {
            if (ImageNumber == 5)
                ImageNumber = 1;
            SliderPictureBox.ImageLocation = String.Format(@"Images\Image{0}.jpg", ImageNumber);
            ImageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            _timeKeeping.Up(ID);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Khaki;
            lblTitleChildForm.Text = "Home";
            if (currentChildForm != null)
                currentChildForm.Close();
            hideSubMenu();
        }

        //Drag Form
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();

        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelChildAdmin);
            ActivateButton(sender, Color.Khaki);
            OpenChildForm(new fAdmin());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelChildUser);
            hideSubMenu();
            ActivateButton(sender, Color.Khaki);
            OpenChildForm(new fTimeKeeping());
        }

        private void btnCartShopping_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, Color.Khaki);
            OpenChildForm(new fSell());
        }

        private void btnLineChart_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, Color.Khaki);
            OpenChildForm(new fLineChart());
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fCreateAccount());
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTurnover_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            if (MessageBox.Show("Do you really want to exit the program?", "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                f.Show();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fAccount());
        }

        private void btnPersonnel_Click_1(object sender, EventArgs e)
        {
            //hideSubMenu();
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fPersonnel());
        }

        private void btnEmployeeSalary_Click(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fSalary());
        }

        private void btnUpdatePersonneel_Click(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fUpdatePersonnel());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fProduct());
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fStockIn());
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, Color.Khaki);
            OpenChildForm(new fSetting());
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, Color.Khaki);
            OpenChildForm(new fInsurance());
        }

        private void btnSupplier_Click_1(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fSupplier());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fBill());
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fMClient());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fReport());
        }

        private void btnProductDetail_Click(object sender, EventArgs e)
        {
            ActivateButtonChild(sender, Color.Khaki, rightBorderBtnAdmin, nextBtnAdmin);
            OpenChildForm(new fProductDetail());
        }
        
        private void fCameraSystemManagement_Load(object sender, EventArgs e)
        {
           
        }
    }
}
