namespace Camera_System_Management.Forms
{
    partial class fProductDiscount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvDiscount = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscountID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiscountID = new System.Windows.Forms.Label();
            this.dtpLastDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFirstDay = new System.Windows.Forms.Label();
            this.dtpFirstDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblLastDay = new System.Windows.Forms.Label();
            this.panelSalaryInformation = new System.Windows.Forms.Panel();
            this.lblDiscountInformation = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.colDis_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDis_Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDis_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icpicSearch = new FontAwesome.Sharp.IconPictureBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbFillter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSalaryInformation.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icpicSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 734);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 395);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvDiscount);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.panel5.Size = new System.Drawing.Size(1186, 395);
            this.panel5.TabIndex = 0;
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToAddRows = false;
            this.dgvDiscount.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvDiscount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscount.BackgroundColor = System.Drawing.Color.Black;
            this.dgvDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiscount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiscount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDiscount.ColumnHeadersHeight = 40;
            this.dgvDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDis_ID,
            this.colDis_Money,
            this.colFirstDay,
            this.colLastDay,
            this.colDis_Status});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscount.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiscount.EnableHeadersVisualStyles = false;
            this.dgvDiscount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDiscount.Location = new System.Drawing.Point(13, 0);
            this.dgvDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.RowHeadersVisible = false;
            this.dgvDiscount.RowHeadersWidth = 51;
            this.dgvDiscount.RowTemplate.Height = 30;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(1160, 395);
            this.dgvDiscount.TabIndex = 14;
            this.dgvDiscount.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiscount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiscount.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvDiscount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDiscount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Khaki;
            this.dgvDiscount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiscount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dgvDiscount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDiscount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDiscount.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDiscount.ThemeStyle.ReadOnly = true;
            this.dgvDiscount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvDiscount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiscount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvDiscount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiscount.ThemeStyle.RowsStyle.Height = 30;
            this.dgvDiscount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvDiscount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDiscount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscount_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.lblDiscount);
            this.panel2.Controls.Add(this.txtDiscountID);
            this.panel2.Controls.Add(this.lblDiscountID);
            this.panel2.Controls.Add(this.dtpLastDay);
            this.panel2.Controls.Add(this.lblFirstDay);
            this.panel2.Controls.Add(this.dtpFirstDay);
            this.panel2.Controls.Add(this.lblLastDay);
            this.panel2.Controls.Add(this.panelSalaryInformation);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 469);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.panel2.Size = new System.Drawing.Size(1186, 261);
            this.panel2.TabIndex = 1;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.BackColor = System.Drawing.Color.Black;
            this.txtDiscount.BorderColor = System.Drawing.Color.Khaki;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FillColor = System.Drawing.Color.Transparent;
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiscount.ForeColor = System.Drawing.Color.Khaki;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtDiscount.Location = new System.Drawing.Point(756, 69);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(7);
            this.txtDiscount.MaxLength = 2;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtDiscount.PlaceholderText = "discount ";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(352, 31);
            this.txtDiscount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDiscount.TabIndex = 24;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiscount.ForeColor = System.Drawing.Color.Khaki;
            this.lblDiscount.Location = new System.Drawing.Point(623, 71);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(88, 25);
            this.lblDiscount.TabIndex = 23;
            this.lblDiscount.Text = "Discount";
            // 
            // txtDiscountID
            // 
            this.txtDiscountID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscountID.BackColor = System.Drawing.Color.Black;
            this.txtDiscountID.BorderColor = System.Drawing.Color.Khaki;
            this.txtDiscountID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountID.DefaultText = "";
            this.txtDiscountID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscountID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscountID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscountID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscountID.FillColor = System.Drawing.Color.Transparent;
            this.txtDiscountID.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtDiscountID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiscountID.ForeColor = System.Drawing.Color.Khaki;
            this.txtDiscountID.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtDiscountID.Location = new System.Drawing.Point(193, 69);
            this.txtDiscountID.Margin = new System.Windows.Forms.Padding(7);
            this.txtDiscountID.MaxLength = 255;
            this.txtDiscountID.Name = "txtDiscountID";
            this.txtDiscountID.PasswordChar = '\0';
            this.txtDiscountID.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtDiscountID.PlaceholderText = "discount id";
            this.txtDiscountID.SelectedText = "";
            this.txtDiscountID.Size = new System.Drawing.Size(352, 31);
            this.txtDiscountID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDiscountID.TabIndex = 22;
            // 
            // lblDiscountID
            // 
            this.lblDiscountID.AutoSize = true;
            this.lblDiscountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiscountID.ForeColor = System.Drawing.Color.Khaki;
            this.lblDiscountID.Location = new System.Drawing.Point(60, 71);
            this.lblDiscountID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountID.Name = "lblDiscountID";
            this.lblDiscountID.Size = new System.Drawing.Size(112, 25);
            this.lblDiscountID.TabIndex = 21;
            this.lblDiscountID.Text = "Discount ID";
            // 
            // dtpLastDay
            // 
            this.dtpLastDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpLastDay.BackColor = System.Drawing.Color.Transparent;
            this.dtpLastDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dtpLastDay.BorderColor = System.Drawing.Color.Khaki;
            this.dtpLastDay.BorderThickness = 1;
            this.dtpLastDay.Checked = true;
            this.dtpLastDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpLastDay.FillColor = System.Drawing.Color.Black;
            this.dtpLastDay.FocusedColor = System.Drawing.Color.Khaki;
            this.dtpLastDay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpLastDay.ForeColor = System.Drawing.Color.Khaki;
            this.dtpLastDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastDay.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.dtpLastDay.IndicateFocus = true;
            this.dtpLastDay.Location = new System.Drawing.Point(756, 118);
            this.dtpLastDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLastDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpLastDay.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpLastDay.Name = "dtpLastDay";
            this.dtpLastDay.Size = new System.Drawing.Size(352, 31);
            this.dtpLastDay.TabIndex = 28;
            this.dtpLastDay.UseTransparentBackground = true;
            this.dtpLastDay.Value = new System.DateTime(2022, 7, 12, 0, 0, 0, 0);
            // 
            // lblFirstDay
            // 
            this.lblFirstDay.AutoSize = true;
            this.lblFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstDay.ForeColor = System.Drawing.Color.Khaki;
            this.lblFirstDay.Location = new System.Drawing.Point(60, 121);
            this.lblFirstDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstDay.Name = "lblFirstDay";
            this.lblFirstDay.Size = new System.Drawing.Size(89, 25);
            this.lblFirstDay.TabIndex = 25;
            this.lblFirstDay.Text = "First Day";
            // 
            // dtpFirstDay
            // 
            this.dtpFirstDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFirstDay.BackColor = System.Drawing.Color.Transparent;
            this.dtpFirstDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dtpFirstDay.BorderColor = System.Drawing.Color.Khaki;
            this.dtpFirstDay.BorderThickness = 1;
            this.dtpFirstDay.Checked = true;
            this.dtpFirstDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFirstDay.FillColor = System.Drawing.Color.Black;
            this.dtpFirstDay.FocusedColor = System.Drawing.Color.Khaki;
            this.dtpFirstDay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFirstDay.ForeColor = System.Drawing.Color.Khaki;
            this.dtpFirstDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFirstDay.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.dtpFirstDay.IndicateFocus = true;
            this.dtpFirstDay.Location = new System.Drawing.Point(193, 118);
            this.dtpFirstDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFirstDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFirstDay.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFirstDay.Name = "dtpFirstDay";
            this.dtpFirstDay.Size = new System.Drawing.Size(352, 31);
            this.dtpFirstDay.TabIndex = 27;
            this.dtpFirstDay.UseTransparentBackground = true;
            this.dtpFirstDay.Value = new System.DateTime(2022, 7, 12, 0, 0, 0, 0);
            // 
            // lblLastDay
            // 
            this.lblLastDay.AutoSize = true;
            this.lblLastDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastDay.ForeColor = System.Drawing.Color.Khaki;
            this.lblLastDay.Location = new System.Drawing.Point(623, 121);
            this.lblLastDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastDay.Name = "lblLastDay";
            this.lblLastDay.Size = new System.Drawing.Size(89, 25);
            this.lblLastDay.TabIndex = 26;
            this.lblLastDay.Text = "Last Day";
            // 
            // panelSalaryInformation
            // 
            this.panelSalaryInformation.BackColor = System.Drawing.Color.Khaki;
            this.panelSalaryInformation.Controls.Add(this.lblDiscountInformation);
            this.panelSalaryInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalaryInformation.Location = new System.Drawing.Point(13, 0);
            this.panelSalaryInformation.Margin = new System.Windows.Forms.Padding(4);
            this.panelSalaryInformation.Name = "panelSalaryInformation";
            this.panelSalaryInformation.Size = new System.Drawing.Size(1160, 43);
            this.panelSalaryInformation.TabIndex = 20;
            // 
            // lblDiscountInformation
            // 
            this.lblDiscountInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscountInformation.AutoSize = true;
            this.lblDiscountInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountInformation.Location = new System.Drawing.Point(365, 6);
            this.lblDiscountInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountInformation.Name = "lblDiscountInformation";
            this.lblDiscountInformation.Size = new System.Drawing.Size(264, 31);
            this.lblDiscountInformation.TabIndex = 0;
            this.lblDiscountInformation.Text = "Discount Information";
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
            this.btnAdd.Location = new System.Drawing.Point(444, 195);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 62);
            this.btnAdd.TabIndex = 19;
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
            this.btnRemove.Location = new System.Drawing.Point(801, 195);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(307, 62);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Change status";
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
            this.btnUpdate.Location = new System.Drawing.Point(588, 195);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(205, 62);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.cbbFillter);
            this.panel3.Controls.Add(this.icpicSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1186, 54);
            this.panel3.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnClose.HoverState.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconColor = System.Drawing.Color.Khaki;
            this.btnClose.Location = new System.Drawing.Point(1132, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 43);
            this.btnClose.TabIndex = 14;
            // 
            // colDis_ID
            // 
            this.colDis_ID.DataPropertyName = "Dis_ID";
            this.colDis_ID.HeaderText = "Discount ID";
            this.colDis_ID.MinimumWidth = 6;
            this.colDis_ID.Name = "colDis_ID";
            this.colDis_ID.ReadOnly = true;
            // 
            // colDis_Money
            // 
            this.colDis_Money.DataPropertyName = "Dis_Money";
            this.colDis_Money.HeaderText = "Discount";
            this.colDis_Money.MinimumWidth = 6;
            this.colDis_Money.Name = "colDis_Money";
            this.colDis_Money.ReadOnly = true;
            // 
            // colFirstDay
            // 
            this.colFirstDay.DataPropertyName = "FirstDay";
            this.colFirstDay.HeaderText = "First Day";
            this.colFirstDay.MinimumWidth = 6;
            this.colFirstDay.Name = "colFirstDay";
            this.colFirstDay.ReadOnly = true;
            // 
            // colLastDay
            // 
            this.colLastDay.DataPropertyName = "LastDay";
            this.colLastDay.HeaderText = "Last Day";
            this.colLastDay.MinimumWidth = 6;
            this.colLastDay.Name = "colLastDay";
            this.colLastDay.ReadOnly = true;
            // 
            // colDis_Status
            // 
            this.colDis_Status.DataPropertyName = "Dis_Status";
            this.colDis_Status.HeaderText = "Status";
            this.colDis_Status.MinimumWidth = 6;
            this.colDis_Status.Name = "colDis_Status";
            this.colDis_Status.ReadOnly = true;
            // 
            // icpicSearch
            // 
            this.icpicSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icpicSearch.BackColor = System.Drawing.Color.Transparent;
            this.icpicSearch.ForeColor = System.Drawing.Color.Khaki;
            this.icpicSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.icpicSearch.IconColor = System.Drawing.Color.Khaki;
            this.icpicSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icpicSearch.IconSize = 25;
            this.icpicSearch.Location = new System.Drawing.Point(762, 16);
            this.icpicSearch.Margin = new System.Windows.Forms.Padding(4);
            this.icpicSearch.Name = "icpicSearch";
            this.icpicSearch.Size = new System.Drawing.Size(27, 25);
            this.icpicSearch.TabIndex = 16;
            this.icpicSearch.TabStop = false;
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
            this.txtSearch.Location = new System.Drawing.Point(393, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtSearch.PlaceholderText = "search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(400, 37);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbbFillter
            // 
            this.cbbFillter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFillter.BackColor = System.Drawing.Color.Transparent;
            this.cbbFillter.BorderColor = System.Drawing.Color.Khaki;
            this.cbbFillter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbFillter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbFillter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFillter.FillColor = System.Drawing.Color.Black;
            this.cbbFillter.FocusedColor = System.Drawing.Color.Gold;
            this.cbbFillter.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.cbbFillter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbFillter.ForeColor = System.Drawing.Color.Khaki;
            this.cbbFillter.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.cbbFillter.ItemHeight = 20;
            this.cbbFillter.Items.AddRange(new object[] {
            "none",
            "up",
            "down"});
            this.cbbFillter.Location = new System.Drawing.Point(1008, 20);
            this.cbbFillter.Margin = new System.Windows.Forms.Padding(4);
            this.cbbFillter.Name = "cbbFillter";
            this.cbbFillter.Size = new System.Drawing.Size(116, 26);
            this.cbbFillter.StartIndex = 0;
            this.cbbFillter.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbFillter.TabIndex = 18;
            this.cbbFillter.SelectedIndexChanged += new System.EventHandler(this.cbbSupplier_SelectedIndexChanged);
            // 
            // fProductDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1200, 738);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fProductDiscount";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fProductDiscount";
            this.Load += new System.EventHandler(this.fProductDiscount_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSalaryInformation.ResumeLayout(false);
            this.panelSalaryInformation.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icpicSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiscount;
        private System.Windows.Forms.Panel panelSalaryInformation;
        private System.Windows.Forms.Label lblDiscountInformation;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscountID;
        private System.Windows.Forms.Label lblDiscountID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpLastDay;
        private System.Windows.Forms.Label lblFirstDay;
        private System.Windows.Forms.Label lblLastDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDis_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDis_Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDis_Status;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFirstDay;
        private FontAwesome.Sharp.IconPictureBox icpicSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFillter;
    }
}