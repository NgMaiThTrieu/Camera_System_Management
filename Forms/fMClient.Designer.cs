namespace Camera_System_Management.Forms
{
    partial class fMClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbAccumulatedPoints = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpDate = new Guna.UI2.WinForms.Guna2Button();
            this.txtFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtNumberPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberPhone = new System.Windows.Forms.Label();
            this.txtCustomerCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.panelCustomerInformation = new System.Windows.Forms.Panel();
            this.lblCustomerInformation = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvClient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colClientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccumulationPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelCustomerInformation.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(30, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 40);
            this.panel2.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Khaki;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Khaki;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(594, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.BackColor = System.Drawing.Color.Black;
            this.txtSearch.BorderColor = System.Drawing.Color.Khaki;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.Transparent;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.Khaki;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtSearch.Location = new System.Drawing.Point(317, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtSearch.PlaceholderText = "search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbAccumulatedPoints);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 40);
            this.panel1.TabIndex = 2;
            // 
            // cbbAccumulatedPoints
            // 
            this.cbbAccumulatedPoints.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbAccumulatedPoints.BackColor = System.Drawing.Color.Transparent;
            this.cbbAccumulatedPoints.BorderColor = System.Drawing.Color.Khaki;
            this.cbbAccumulatedPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbAccumulatedPoints.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbAccumulatedPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAccumulatedPoints.FillColor = System.Drawing.Color.Black;
            this.cbbAccumulatedPoints.FocusedColor = System.Drawing.Color.Gold;
            this.cbbAccumulatedPoints.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.cbbAccumulatedPoints.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbAccumulatedPoints.ForeColor = System.Drawing.Color.Khaki;
            this.cbbAccumulatedPoints.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.cbbAccumulatedPoints.ItemHeight = 20;
            this.cbbAccumulatedPoints.Items.AddRange(new object[] {
            "All",
            "1000",
            "2000",
            "5000",
            "10000"});
            this.cbbAccumulatedPoints.Location = new System.Drawing.Point(672, 6);
            this.cbbAccumulatedPoints.Name = "cbbAccumulatedPoints";
            this.cbbAccumulatedPoints.Size = new System.Drawing.Size(250, 26);
            this.cbbAccumulatedPoints.StartIndex = 0;
            this.cbbAccumulatedPoints.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbAccumulatedPoints.TabIndex = 18;
            this.cbbAccumulatedPoints.SelectedIndexChanged += new System.EventHandler(this.cbbAccumulatedPoints_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 421);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 213);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(918, 205);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Camera_System_Management.Properties.Resources.canon_3_copy3;
            this.pictureBox1.Location = new System.Drawing.Point(462, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panelCustomerInformation);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 199);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Controls.Add(this.btnUpDate);
            this.panel4.Controls.Add(this.txtFullname);
            this.panel4.Controls.Add(this.lblCustomerName);
            this.panel4.Controls.Add(this.txtNumberPhone);
            this.panel4.Controls.Add(this.lblNumberPhone);
            this.panel4.Controls.Add(this.txtCustomerCode);
            this.panel4.Controls.Add(this.lblCustomerCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel4.Size = new System.Drawing.Size(453, 164);
            this.panel4.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Animated = true;
            this.btnRemove.BackColor = System.Drawing.Color.Black;
            this.btnRemove.BorderColor = System.Drawing.Color.Khaki;
            this.btnRemove.BorderRadius = 6;
            this.btnRemove.BorderThickness = 2;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.Transparent;
            this.btnRemove.Font = new System.Drawing.Font("ROG Fonts", 15F);
            this.btnRemove.ForeColor = System.Drawing.Color.Khaki;
            this.btnRemove.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnRemove.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnRemove.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(141, 101);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(140, 60);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpDate.Animated = true;
            this.btnUpDate.BackColor = System.Drawing.Color.Black;
            this.btnUpDate.BorderColor = System.Drawing.Color.Khaki;
            this.btnUpDate.BorderRadius = 6;
            this.btnUpDate.BorderThickness = 2;
            this.btnUpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpDate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpDate.Font = new System.Drawing.Font("ROG Fonts", 15F);
            this.btnUpDate.ForeColor = System.Drawing.Color.Khaki;
            this.btnUpDate.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnUpDate.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnUpDate.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUpDate.Location = new System.Drawing.Point(291, 101);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(140, 60);
            this.btnUpDate.TabIndex = 16;
            this.btnUpDate.Text = "Update";
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullname.BackColor = System.Drawing.Color.Black;
            this.txtFullname.BorderColor = System.Drawing.Color.Khaki;
            this.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullname.DefaultText = "";
            this.txtFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname.FillColor = System.Drawing.Color.Transparent;
            this.txtFullname.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullname.ForeColor = System.Drawing.Color.Khaki;
            this.txtFullname.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtFullname.Location = new System.Drawing.Point(148, 46);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFullname.MaxLength = 500;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.PasswordChar = '\0';
            this.txtFullname.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtFullname.PlaceholderText = "full name";
            this.txtFullname.SelectedText = "";
            this.txtFullname.Size = new System.Drawing.Size(280, 25);
            this.txtFullname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtFullname.TabIndex = 11;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.Khaki;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 48);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(128, 20);
            this.lblCustomerName.TabIndex = 10;
            this.lblCustomerName.Text = "CustomerName :";
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberPhone.BackColor = System.Drawing.Color.Black;
            this.txtNumberPhone.BorderColor = System.Drawing.Color.Khaki;
            this.txtNumberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberPhone.DefaultText = "";
            this.txtNumberPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhone.FillColor = System.Drawing.Color.Transparent;
            this.txtNumberPhone.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtNumberPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumberPhone.ForeColor = System.Drawing.Color.Khaki;
            this.txtNumberPhone.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtNumberPhone.Location = new System.Drawing.Point(148, 81);
            this.txtNumberPhone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNumberPhone.MaxLength = 500;
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.PasswordChar = '\0';
            this.txtNumberPhone.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtNumberPhone.PlaceholderText = "number phone";
            this.txtNumberPhone.SelectedText = "";
            this.txtNumberPhone.Size = new System.Drawing.Size(280, 25);
            this.txtNumberPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNumberPhone.TabIndex = 9;
            // 
            // lblNumberPhone
            // 
            this.lblNumberPhone.AutoSize = true;
            this.lblNumberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberPhone.ForeColor = System.Drawing.Color.Khaki;
            this.lblNumberPhone.Location = new System.Drawing.Point(12, 83);
            this.lblNumberPhone.Name = "lblNumberPhone";
            this.lblNumberPhone.Size = new System.Drawing.Size(123, 20);
            this.lblNumberPhone.TabIndex = 8;
            this.lblNumberPhone.Text = "Number Phone :";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerCode.BackColor = System.Drawing.Color.Black;
            this.txtCustomerCode.BorderColor = System.Drawing.Color.Khaki;
            this.txtCustomerCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerCode.DefaultText = "";
            this.txtCustomerCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerCode.FillColor = System.Drawing.Color.Transparent;
            this.txtCustomerCode.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtCustomerCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCustomerCode.ForeColor = System.Drawing.Color.Khaki;
            this.txtCustomerCode.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtCustomerCode.Location = new System.Drawing.Point(148, 11);
            this.txtCustomerCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCustomerCode.MaxLength = 500;
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.PasswordChar = '\0';
            this.txtCustomerCode.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtCustomerCode.PlaceholderText = "customer code";
            this.txtCustomerCode.SelectedText = "";
            this.txtCustomerCode.Size = new System.Drawing.Size(280, 25);
            this.txtCustomerCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCustomerCode.TabIndex = 7;
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCustomerCode.ForeColor = System.Drawing.Color.Khaki;
            this.lblCustomerCode.Location = new System.Drawing.Point(12, 13);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(128, 20);
            this.lblCustomerCode.TabIndex = 6;
            this.lblCustomerCode.Text = "Customer Code :";
            // 
            // panelCustomerInformation
            // 
            this.panelCustomerInformation.BackColor = System.Drawing.Color.Khaki;
            this.panelCustomerInformation.Controls.Add(this.lblCustomerInformation);
            this.panelCustomerInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerInformation.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerInformation.Name = "panelCustomerInformation";
            this.panelCustomerInformation.Size = new System.Drawing.Size(453, 35);
            this.panelCustomerInformation.TabIndex = 1;
            // 
            // lblCustomerInformation
            // 
            this.lblCustomerInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerInformation.AutoSize = true;
            this.lblCustomerInformation.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInformation.Location = new System.Drawing.Point(56, 5);
            this.lblCustomerInformation.Name = "lblCustomerInformation";
            this.lblCustomerInformation.Size = new System.Drawing.Size(346, 25);
            this.lblCustomerInformation.TabIndex = 0;
            this.lblCustomerInformation.Text = "Customer Information";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvClient);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(918, 204);
            this.panel5.TabIndex = 15;
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.BackgroundColor = System.Drawing.Color.Black;
            this.dgvClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClient.ColumnHeadersHeight = 40;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClientCode,
            this.colFullName,
            this.colNumberPhone,
            this.colAccumulationPoints});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClient.EnableHeadersVisualStyles = false;
            this.dgvClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvClient.Location = new System.Drawing.Point(0, 0);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowTemplate.Height = 30;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(918, 204);
            this.dgvClient.TabIndex = 16;
            this.dgvClient.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClient.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvClient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvClient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Khaki;
            this.dgvClient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dgvClient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClient.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvClient.ThemeStyle.ReadOnly = true;
            this.dgvClient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvClient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvClient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClient.ThemeStyle.RowsStyle.Height = 30;
            this.dgvClient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvClient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellClick);
            // 
            // colClientCode
            // 
            this.colClientCode.DataPropertyName = "ClientID";
            this.colClientCode.HeaderText = "Client Code";
            this.colClientCode.Name = "colClientCode";
            this.colClientCode.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "Full Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colNumberPhone
            // 
            this.colNumberPhone.DataPropertyName = "NumberPhone";
            this.colNumberPhone.HeaderText = "Number Phone";
            this.colNumberPhone.Name = "colNumberPhone";
            this.colNumberPhone.ReadOnly = true;
            // 
            // colAccumulationPoints
            // 
            this.colAccumulationPoints.DataPropertyName = "AccumulationPoints";
            this.colAccumulationPoints.HeaderText = "Accumulation Points";
            this.colAccumulationPoints.Name = "colAccumulationPoints";
            this.colAccumulationPoints.ReadOnly = true;
            // 
            // fMClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "fMClient";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelCustomerInformation.ResumeLayout(false);
            this.panelCustomerInformation.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbAccumulatedPoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelCustomerInformation;
        private System.Windows.Forms.Label lblCustomerInformation;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtFullname;
        private System.Windows.Forms.Label lblCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberPhone;
        private System.Windows.Forms.Label lblNumberPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerCode;
        private System.Windows.Forms.Label lblCustomerCode;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpDate;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccumulationPoints;
    }
}