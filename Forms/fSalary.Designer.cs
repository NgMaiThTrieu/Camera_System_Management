namespace Camera_System_Management.Forms
{
    partial class fSalary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panelLeftInformation = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtSalaryDeduction = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBasicSaraly = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblMouth = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbFullName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbMouth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblSalaryDeduction = new System.Windows.Forms.Label();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.panelSalaryInformation = new System.Windows.Forms.Panel();
            this.lblSalarynformation = new System.Windows.Forms.Label();
            this.panelSalary = new System.Windows.Forms.Panel();
            this.dgvSalary = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSarary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnAssi = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panelLeftInformation.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelSalaryInformation.SuspendLayout();
            this.panelSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(1241, 783);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelLeftInformation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSalary, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 643);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnAssi);
            this.panel16.Controls.Add(this.btnAdd);
            this.panel16.Controls.Add(this.btnRemove);
            this.panel16.Controls.Add(this.btnUpdate);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 581);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.panel16.Size = new System.Drawing.Size(1175, 59);
            this.panel16.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Animated = true;
            this.btnAdd.BorderColor = System.Drawing.Color.Khaki;
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAdd.ForeColor = System.Drawing.Color.Khaki;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(690, -8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Animated = true;
            this.btnRemove.BorderColor = System.Drawing.Color.Khaki;
            this.btnRemove.BorderRadius = 6;
            this.btnRemove.BorderThickness = 2;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.Transparent;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRemove.ForeColor = System.Drawing.Color.Khaki;
            this.btnRemove.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnRemove.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnRemove.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(801, -8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 50);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Animated = true;
            this.btnUpdate.BorderColor = System.Drawing.Color.Khaki;
            this.btnUpdate.BorderRadius = 6;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Khaki;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(960, -8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 50);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            // 
            // panelLeftInformation
            // 
            this.panelLeftInformation.Controls.Add(this.tableLayoutPanel2);
            this.panelLeftInformation.Controls.Add(this.panelSalaryInformation);
            this.panelLeftInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftInformation.Location = new System.Drawing.Point(3, 324);
            this.panelLeftInformation.Name = "panelLeftInformation";
            this.panelLeftInformation.Size = new System.Drawing.Size(1175, 251);
            this.panelLeftInformation.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel8, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1175, 216);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.txtSalaryDeduction);
            this.panel8.Controls.Add(this.txtBasicSaraly);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(766, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.panel8.Size = new System.Drawing.Size(406, 210);
            this.panel8.TabIndex = 4;
            // 
            // txtSalaryDeduction
            // 
            this.txtSalaryDeduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalaryDeduction.BackColor = System.Drawing.Color.Black;
            this.txtSalaryDeduction.BorderColor = System.Drawing.Color.Khaki;
            this.txtSalaryDeduction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalaryDeduction.DefaultText = "";
            this.txtSalaryDeduction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalaryDeduction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalaryDeduction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalaryDeduction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalaryDeduction.FillColor = System.Drawing.Color.Transparent;
            this.txtSalaryDeduction.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtSalaryDeduction.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSalaryDeduction.ForeColor = System.Drawing.Color.Khaki;
            this.txtSalaryDeduction.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtSalaryDeduction.Location = new System.Drawing.Point(5, 70);
            this.txtSalaryDeduction.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSalaryDeduction.MaxLength = 10;
            this.txtSalaryDeduction.Name = "txtSalaryDeduction";
            this.txtSalaryDeduction.PasswordChar = '\0';
            this.txtSalaryDeduction.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtSalaryDeduction.PlaceholderText = "salary deduction";
            this.txtSalaryDeduction.SelectedText = "";
            this.txtSalaryDeduction.Size = new System.Drawing.Size(346, 25);
            this.txtSalaryDeduction.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSalaryDeduction.TabIndex = 76;
            // 
            // txtBasicSaraly
            // 
            this.txtBasicSaraly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBasicSaraly.BackColor = System.Drawing.Color.Black;
            this.txtBasicSaraly.BorderColor = System.Drawing.Color.Khaki;
            this.txtBasicSaraly.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBasicSaraly.DefaultText = "";
            this.txtBasicSaraly.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBasicSaraly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBasicSaraly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBasicSaraly.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBasicSaraly.FillColor = System.Drawing.Color.Transparent;
            this.txtBasicSaraly.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtBasicSaraly.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBasicSaraly.ForeColor = System.Drawing.Color.Khaki;
            this.txtBasicSaraly.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtBasicSaraly.Location = new System.Drawing.Point(5, 29);
            this.txtBasicSaraly.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBasicSaraly.MaxLength = 10;
            this.txtBasicSaraly.Name = "txtBasicSaraly";
            this.txtBasicSaraly.PasswordChar = '\0';
            this.txtBasicSaraly.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtBasicSaraly.PlaceholderText = "basic salary";
            this.txtBasicSaraly.SelectedText = "";
            this.txtBasicSaraly.Size = new System.Drawing.Size(346, 25);
            this.txtBasicSaraly.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtBasicSaraly.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lblFullName);
            this.panel3.Controls.Add(this.lblMouth);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(170, 210);
            this.panel3.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFullName.ForeColor = System.Drawing.Color.Khaki;
            this.lblFullName.Location = new System.Drawing.Point(55, 30);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(88, 20);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name :";
            // 
            // lblMouth
            // 
            this.lblMouth.AutoSize = true;
            this.lblMouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMouth.ForeColor = System.Drawing.Color.Khaki;
            this.lblMouth.Location = new System.Drawing.Point(55, 70);
            this.lblMouth.Name = "lblMouth";
            this.lblMouth.Size = new System.Drawing.Size(62, 20);
            this.lblMouth.TabIndex = 41;
            this.lblMouth.Text = "Mouth :";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.cbbFullName);
            this.panel4.Controls.Add(this.cbbMouth);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(179, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.panel4.Size = new System.Drawing.Size(405, 210);
            this.panel4.TabIndex = 2;
            // 
            // cbbFullName
            // 
            this.cbbFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFullName.BackColor = System.Drawing.Color.Transparent;
            this.cbbFullName.BorderColor = System.Drawing.Color.Khaki;
            this.cbbFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbFullName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbFullName.DropDownHeight = 250;
            this.cbbFullName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFullName.FillColor = System.Drawing.Color.Black;
            this.cbbFullName.FocusedColor = System.Drawing.Color.Gold;
            this.cbbFullName.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.cbbFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbFullName.ForeColor = System.Drawing.Color.Khaki;
            this.cbbFullName.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.cbbFullName.IntegralHeight = false;
            this.cbbFullName.ItemHeight = 20;
            this.cbbFullName.Items.AddRange(new object[] {
            "Hồ Khánh Duy",
            "Bùi Khánh Duy",
            "Nguyễn Mai Thiên Triệu"});
            this.cbbFullName.Location = new System.Drawing.Point(5, 29);
            this.cbbFullName.Name = "cbbFullName";
            this.cbbFullName.Size = new System.Drawing.Size(347, 26);
            this.cbbFullName.StartIndex = 0;
            this.cbbFullName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbFullName.TabIndex = 60;
            // 
            // cbbMouth
            // 
            this.cbbMouth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbMouth.BackColor = System.Drawing.Color.Transparent;
            this.cbbMouth.BorderColor = System.Drawing.Color.Khaki;
            this.cbbMouth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMouth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMouth.DropDownHeight = 250;
            this.cbbMouth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMouth.FillColor = System.Drawing.Color.Black;
            this.cbbMouth.FocusedColor = System.Drawing.Color.Gold;
            this.cbbMouth.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.cbbMouth.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbMouth.ForeColor = System.Drawing.Color.Khaki;
            this.cbbMouth.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.cbbMouth.IntegralHeight = false;
            this.cbbMouth.ItemHeight = 20;
            this.cbbMouth.Items.AddRange(new object[] {
            "January",
            "Ferbuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbbMouth.Location = new System.Drawing.Point(5, 70);
            this.cbbMouth.Name = "cbbMouth";
            this.cbbMouth.Size = new System.Drawing.Size(347, 26);
            this.cbbMouth.StartIndex = 0;
            this.cbbMouth.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbMouth.TabIndex = 54;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.lblSalaryDeduction);
            this.panel7.Controls.Add(this.lblBasicSalary);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(590, 3);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(170, 210);
            this.panel7.TabIndex = 3;
            // 
            // lblSalaryDeduction
            // 
            this.lblSalaryDeduction.AutoSize = true;
            this.lblSalaryDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSalaryDeduction.ForeColor = System.Drawing.Color.Khaki;
            this.lblSalaryDeduction.Location = new System.Drawing.Point(55, 70);
            this.lblSalaryDeduction.Name = "lblSalaryDeduction";
            this.lblSalaryDeduction.Size = new System.Drawing.Size(134, 20);
            this.lblSalaryDeduction.TabIndex = 88;
            this.lblSalaryDeduction.Text = "Salary Deduction:";
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBasicSalary.ForeColor = System.Drawing.Color.Khaki;
            this.lblBasicSalary.Location = new System.Drawing.Point(55, 30);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(104, 20);
            this.lblBasicSalary.TabIndex = 87;
            this.lblBasicSalary.Text = "Basic Salary :";
            // 
            // panelSalaryInformation
            // 
            this.panelSalaryInformation.BackColor = System.Drawing.Color.Khaki;
            this.panelSalaryInformation.Controls.Add(this.lblSalarynformation);
            this.panelSalaryInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalaryInformation.Location = new System.Drawing.Point(0, 0);
            this.panelSalaryInformation.Name = "panelSalaryInformation";
            this.panelSalaryInformation.Size = new System.Drawing.Size(1175, 35);
            this.panelSalaryInformation.TabIndex = 0;
            // 
            // lblSalarynformation
            // 
            this.lblSalarynformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalarynformation.AutoSize = true;
            this.lblSalarynformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarynformation.Location = new System.Drawing.Point(430, 5);
            this.lblSalarynformation.Name = "lblSalarynformation";
            this.lblSalarynformation.Size = new System.Drawing.Size(185, 25);
            this.lblSalarynformation.TabIndex = 0;
            this.lblSalarynformation.Text = "Salary Information";
            // 
            // panelSalary
            // 
            this.panelSalary.BackColor = System.Drawing.Color.Transparent;
            this.panelSalary.Controls.Add(this.dgvSalary);
            this.panelSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSalary.Location = new System.Drawing.Point(3, 3);
            this.panelSalary.Name = "panelSalary";
            this.panelSalary.Size = new System.Drawing.Size(1175, 315);
            this.panelSalary.TabIndex = 14;
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvSalary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.BackgroundColor = System.Drawing.Color.Black;
            this.dgvSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalary.CausesValidation = false;
            this.dgvSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalary.ColumnHeadersHeight = 40;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffID,
            this.colMonth,
            this.colSarary});
            this.dgvSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalary.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalary.EnableHeadersVisualStyles = false;
            this.dgvSalary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvSalary.Location = new System.Drawing.Point(0, 0);
            this.dgvSalary.MaximumSize = new System.Drawing.Size(0, 400);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersVisible = false;
            this.dgvSalary.RowTemplate.Height = 30;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(1175, 315);
            this.dgvSalary.TabIndex = 13;
            this.dgvSalary.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvSalary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvSalary.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSalary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSalary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSalary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSalary.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvSalary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvSalary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Khaki;
            this.dgvSalary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalary.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dgvSalary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSalary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSalary.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSalary.ThemeStyle.ReadOnly = true;
            this.dgvSalary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvSalary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalary.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvSalary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSalary.ThemeStyle.RowsStyle.Height = 30;
            this.dgvSalary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvSalary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellClick);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.Controls.Add(this.iconPictureBox1);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(30, 30);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1181, 80);
            this.panelSearch.TabIndex = 17;
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
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.ForeColor = System.Drawing.Color.Khaki;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtSearch.Location = new System.Drawing.Point(452, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtSearch.PlaceholderText = "search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // colStaffID
            // 
            this.colStaffID.DataPropertyName = "StaffID";
            this.colStaffID.HeaderText = "Staff ID";
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.ReadOnly = true;
            // 
            // colMonth
            // 
            this.colMonth.DataPropertyName = "Month";
            this.colMonth.HeaderText = "Month";
            this.colMonth.Name = "colMonth";
            this.colMonth.ReadOnly = true;
            // 
            // colSarary
            // 
            this.colSarary.DataPropertyName = "Sarary";
            this.colSarary.HeaderText = "Sarary";
            this.colSarary.Name = "colSarary";
            this.colSarary.ReadOnly = true;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(729, 36);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnAssi
            // 
            this.btnAssi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssi.Animated = true;
            this.btnAssi.BorderColor = System.Drawing.Color.Khaki;
            this.btnAssi.BorderRadius = 6;
            this.btnAssi.BorderThickness = 2;
            this.btnAssi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAssi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAssi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAssi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAssi.FillColor = System.Drawing.Color.Transparent;
            this.btnAssi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAssi.ForeColor = System.Drawing.Color.Khaki;
            this.btnAssi.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnAssi.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnAssi.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAssi.Location = new System.Drawing.Point(469, -8);
            this.btnAssi.Name = "btnAssi";
            this.btnAssi.Size = new System.Drawing.Size(100, 50);
            this.btnAssi.TabIndex = 8;
            this.btnAssi.Text = "Add";
            this.btnAssi.Click += new System.EventHandler(this.btnAssi_Click);
            // 
            // fSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1241, 783);
            this.Controls.Add(this.panel1);
            this.Name = "fSalary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.fSalary_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panelLeftInformation.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelSalaryInformation.ResumeLayout(false);
            this.panelSalaryInformation.PerformLayout();
            this.panelSalary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel panelSalary;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSalary;
        private System.Windows.Forms.Panel panelLeftInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMouth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtBasicSaraly;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblMouth;
        private System.Windows.Forms.Panel panelSalaryInformation;
        private System.Windows.Forms.Label lblSalarynformation;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtSalaryDeduction;
        private System.Windows.Forms.Label lblSalaryDeduction;
        private System.Windows.Forms.Panel panel16;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSarary;
        private Guna.UI2.WinForms.Guna2Button btnAssi;
    }
}