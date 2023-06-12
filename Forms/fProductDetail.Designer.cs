namespace Camera_System_Management.Forms
{
    partial class fProductDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProductDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtProductCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtChip = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblChip = new System.Windows.Forms.Label();
            this.txtSensor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSensor = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAutoFocus = new System.Windows.Forms.Label();
            this.txtInternational = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInternational = new System.Windows.Forms.Label();
            this.txtShutterSpeed = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblShutterSpeed = new System.Windows.Forms.Label();
            this.txtVideo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.cbbProductName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 60);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 501);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(33, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 215);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvProductDetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(33, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 214);
            this.panel3.TabIndex = 0;
            // 
            // dgvProductDetail
            // 
            this.dgvProductDetail.AllowUserToAddRows = false;
            this.dgvProductDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvProductDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductDetail.BackgroundColor = System.Drawing.Color.Black;
            this.dgvProductDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductDetail.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductDetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductDetail.EnableHeadersVisualStyles = false;
            this.dgvProductDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvProductDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvProductDetail.Name = "dgvProductDetail";
            this.dgvProductDetail.ReadOnly = true;
            this.dgvProductDetail.RowHeadersVisible = false;
            this.dgvProductDetail.RowTemplate.Height = 30;
            this.dgvProductDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetail.Size = new System.Drawing.Size(918, 214);
            this.dgvProductDetail.TabIndex = 13;
            this.dgvProductDetail.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvProductDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvProductDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductDetail.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvProductDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvProductDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Khaki;
            this.dgvProductDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dgvProductDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProductDetail.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProductDetail.ThemeStyle.ReadOnly = true;
            this.dgvProductDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvProductDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvProductDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductDetail.ThemeStyle.RowsStyle.Height = 30;
            this.dgvProductDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvProductDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(619, 21);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox1.TabIndex = 14;
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
            this.txtSearch.Location = new System.Drawing.Point(342, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtSearch.PlaceholderText = "search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(918, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtChip);
            this.panel4.Controls.Add(this.lblChip);
            this.panel4.Controls.Add(this.txtProductCode);
            this.panel4.Controls.Add(this.lblProductCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.panel4.Size = new System.Drawing.Size(453, 74);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbProductName);
            this.panel5.Controls.Add(this.txtSensor);
            this.panel5.Controls.Add(this.lblSensor);
            this.panel5.Controls.Add(this.lblProductName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(462, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(453, 74);
            this.panel5.TabIndex = 1;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.BackColor = System.Drawing.Color.Black;
            this.txtProductCode.BorderColor = System.Drawing.Color.Khaki;
            this.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductCode.DefaultText = "";
            this.txtProductCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductCode.FillColor = System.Drawing.Color.Transparent;
            this.txtProductCode.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtProductCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductCode.ForeColor = System.Drawing.Color.Khaki;
            this.txtProductCode.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtProductCode.Location = new System.Drawing.Point(136, 3);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProductCode.MaxLength = 500;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PasswordChar = '\0';
            this.txtProductCode.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtProductCode.PlaceholderText = "product code";
            this.txtProductCode.SelectedText = "";
            this.txtProductCode.Size = new System.Drawing.Size(282, 25);
            this.txtProductCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtProductCode.TabIndex = 7;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductCode.ForeColor = System.Drawing.Color.Khaki;
            this.lblProductCode.Location = new System.Drawing.Point(3, 4);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(110, 20);
            this.lblProductCode.TabIndex = 6;
            this.lblProductCode.Text = "Product Code ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.ForeColor = System.Drawing.Color.Khaki;
            this.lblProductName.Location = new System.Drawing.Point(33, 4);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(114, 20);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "Product Name ";
            // 
            // txtChip
            // 
            this.txtChip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChip.BackColor = System.Drawing.Color.Black;
            this.txtChip.BorderColor = System.Drawing.Color.Khaki;
            this.txtChip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChip.DefaultText = "";
            this.txtChip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChip.FillColor = System.Drawing.Color.Transparent;
            this.txtChip.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtChip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtChip.ForeColor = System.Drawing.Color.Khaki;
            this.txtChip.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtChip.Location = new System.Drawing.Point(137, 43);
            this.txtChip.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtChip.MaxLength = 500;
            this.txtChip.Name = "txtChip";
            this.txtChip.PasswordChar = '\0';
            this.txtChip.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtChip.PlaceholderText = "chip";
            this.txtChip.SelectedText = "";
            this.txtChip.Size = new System.Drawing.Size(282, 25);
            this.txtChip.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtChip.TabIndex = 9;
            // 
            // lblChip
            // 
            this.lblChip.AutoSize = true;
            this.lblChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblChip.ForeColor = System.Drawing.Color.Khaki;
            this.lblChip.Location = new System.Drawing.Point(4, 44);
            this.lblChip.Name = "lblChip";
            this.lblChip.Size = new System.Drawing.Size(41, 20);
            this.lblChip.TabIndex = 8;
            this.lblChip.Text = "Chip";
            // 
            // txtSensor
            // 
            this.txtSensor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSensor.BackColor = System.Drawing.Color.Black;
            this.txtSensor.BorderColor = System.Drawing.Color.Khaki;
            this.txtSensor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSensor.DefaultText = "";
            this.txtSensor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSensor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSensor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSensor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSensor.FillColor = System.Drawing.Color.Transparent;
            this.txtSensor.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtSensor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSensor.ForeColor = System.Drawing.Color.Khaki;
            this.txtSensor.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtSensor.Location = new System.Drawing.Point(153, 43);
            this.txtSensor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSensor.MaxLength = 500;
            this.txtSensor.Name = "txtSensor";
            this.txtSensor.PasswordChar = '\0';
            this.txtSensor.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtSensor.PlaceholderText = "sensor";
            this.txtSensor.SelectedText = "";
            this.txtSensor.Size = new System.Drawing.Size(278, 25);
            this.txtSensor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSensor.TabIndex = 11;
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSensor.ForeColor = System.Drawing.Color.Khaki;
            this.lblSensor.Location = new System.Drawing.Point(34, 44);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(60, 20);
            this.lblSensor.TabIndex = 10;
            this.lblSensor.Text = "Sensor";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Controls.Add(this.btnRemove);
            this.panel6.Controls.Add(this.btnUpdate);
            this.panel6.Controls.Add(this.txtVideo);
            this.panel6.Controls.Add(this.lblVideo);
            this.panel6.Controls.Add(this.txtShutterSpeed);
            this.panel6.Controls.Add(this.lblShutterSpeed);
            this.panel6.Controls.Add(this.txtInternational);
            this.panel6.Controls.Add(this.lblInternational);
            this.panel6.Controls.Add(this.guna2TextBox1);
            this.panel6.Controls.Add(this.lblAutoFocus);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(918, 135);
            this.panel6.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox1.BackColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Khaki;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Khaki;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.guna2TextBox1.Location = new System.Drawing.Point(140, 9);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox1.MaxLength = 500;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.guna2TextBox1.PlaceholderText = "auto focus";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(753, 25);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 11;
            // 
            // lblAutoFocus
            // 
            this.lblAutoFocus.AutoSize = true;
            this.lblAutoFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAutoFocus.ForeColor = System.Drawing.Color.Khaki;
            this.lblAutoFocus.Location = new System.Drawing.Point(7, 10);
            this.lblAutoFocus.Name = "lblAutoFocus";
            this.lblAutoFocus.Size = new System.Drawing.Size(91, 20);
            this.lblAutoFocus.TabIndex = 10;
            this.lblAutoFocus.Text = "Auto Focus";
            // 
            // txtInternational
            // 
            this.txtInternational.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInternational.BackColor = System.Drawing.Color.Black;
            this.txtInternational.BorderColor = System.Drawing.Color.Khaki;
            this.txtInternational.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInternational.DefaultText = "";
            this.txtInternational.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInternational.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInternational.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInternational.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInternational.FillColor = System.Drawing.Color.Transparent;
            this.txtInternational.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtInternational.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInternational.ForeColor = System.Drawing.Color.Khaki;
            this.txtInternational.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtInternational.Location = new System.Drawing.Point(139, 49);
            this.txtInternational.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInternational.MaxLength = 500;
            this.txtInternational.Name = "txtInternational";
            this.txtInternational.PasswordChar = '\0';
            this.txtInternational.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtInternational.PlaceholderText = "international";
            this.txtInternational.SelectedText = "";
            this.txtInternational.Size = new System.Drawing.Size(753, 25);
            this.txtInternational.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtInternational.TabIndex = 13;
            // 
            // lblInternational
            // 
            this.lblInternational.AutoSize = true;
            this.lblInternational.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInternational.ForeColor = System.Drawing.Color.Khaki;
            this.lblInternational.Location = new System.Drawing.Point(6, 50);
            this.lblInternational.Name = "lblInternational";
            this.lblInternational.Size = new System.Drawing.Size(98, 20);
            this.lblInternational.TabIndex = 12;
            this.lblInternational.Text = "International";
            // 
            // txtShutterSpeed
            // 
            this.txtShutterSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShutterSpeed.BackColor = System.Drawing.Color.Black;
            this.txtShutterSpeed.BorderColor = System.Drawing.Color.Khaki;
            this.txtShutterSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShutterSpeed.DefaultText = "";
            this.txtShutterSpeed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtShutterSpeed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtShutterSpeed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShutterSpeed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShutterSpeed.FillColor = System.Drawing.Color.Transparent;
            this.txtShutterSpeed.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtShutterSpeed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtShutterSpeed.ForeColor = System.Drawing.Color.Khaki;
            this.txtShutterSpeed.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtShutterSpeed.Location = new System.Drawing.Point(139, 89);
            this.txtShutterSpeed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtShutterSpeed.MaxLength = 500;
            this.txtShutterSpeed.Name = "txtShutterSpeed";
            this.txtShutterSpeed.PasswordChar = '\0';
            this.txtShutterSpeed.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtShutterSpeed.PlaceholderText = "shutter speed";
            this.txtShutterSpeed.SelectedText = "";
            this.txtShutterSpeed.Size = new System.Drawing.Size(753, 25);
            this.txtShutterSpeed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtShutterSpeed.TabIndex = 15;
            // 
            // lblShutterSpeed
            // 
            this.lblShutterSpeed.AutoSize = true;
            this.lblShutterSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblShutterSpeed.ForeColor = System.Drawing.Color.Khaki;
            this.lblShutterSpeed.Location = new System.Drawing.Point(6, 90);
            this.lblShutterSpeed.Name = "lblShutterSpeed";
            this.lblShutterSpeed.Size = new System.Drawing.Size(113, 20);
            this.lblShutterSpeed.TabIndex = 14;
            this.lblShutterSpeed.Text = "Shutter Speed";
            // 
            // txtVideo
            // 
            this.txtVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVideo.BackColor = System.Drawing.Color.Black;
            this.txtVideo.BorderColor = System.Drawing.Color.Khaki;
            this.txtVideo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVideo.DefaultText = "";
            this.txtVideo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVideo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVideo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVideo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVideo.FillColor = System.Drawing.Color.Transparent;
            this.txtVideo.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtVideo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtVideo.ForeColor = System.Drawing.Color.Khaki;
            this.txtVideo.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtVideo.Location = new System.Drawing.Point(139, 129);
            this.txtVideo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtVideo.MaxLength = 500;
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.PasswordChar = '\0';
            this.txtVideo.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtVideo.PlaceholderText = "video";
            this.txtVideo.SelectedText = "";
            this.txtVideo.Size = new System.Drawing.Size(753, 25);
            this.txtVideo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtVideo.TabIndex = 17;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVideo.ForeColor = System.Drawing.Color.Khaki;
            this.lblVideo.Location = new System.Drawing.Point(6, 130);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(50, 20);
            this.lblVideo.TabIndex = 16;
            this.lblVideo.Text = "Video";
            // 
            // cbbProductName
            // 
            this.cbbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbProductName.BackColor = System.Drawing.Color.Transparent;
            this.cbbProductName.BorderColor = System.Drawing.Color.Khaki;
            this.cbbProductName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbProductName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbProductName.DropDownHeight = 300;
            this.cbbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProductName.FillColor = System.Drawing.Color.Black;
            this.cbbProductName.FocusedColor = System.Drawing.Color.Gold;
            this.cbbProductName.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.cbbProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbProductName.ForeColor = System.Drawing.Color.Khaki;
            this.cbbProductName.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.cbbProductName.IntegralHeight = false;
            this.cbbProductName.ItemHeight = 20;
            this.cbbProductName.Location = new System.Drawing.Point(153, 3);
            this.cbbProductName.Name = "cbbProductName";
            this.cbbProductName.Size = new System.Drawing.Size(276, 26);
            this.cbbProductName.StartIndex = 0;
            this.cbbProductName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbProductName.TabIndex = 32;
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
            this.btnAdd.Font = new System.Drawing.Font("ROG Fonts", 16F);
            this.btnAdd.ForeColor = System.Drawing.Color.Khaki;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(469, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
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
            this.btnRemove.Font = new System.Drawing.Font("ROG Fonts", 16F);
            this.btnRemove.ForeColor = System.Drawing.Color.Khaki;
            this.btnRemove.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnRemove.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnRemove.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(580, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 50);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove";
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
            this.btnUpdate.Font = new System.Drawing.Font("ROG Fonts", 16F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Khaki;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(741, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 50);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            // 
            // fProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "fProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Detail";
            this.Load += new System.EventHandler(this.fProductDetail_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductDetail;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private Guna.UI2.WinForms.Guna2TextBox txtSensor;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.Label lblProductName;
        private Guna.UI2.WinForms.Guna2TextBox txtChip;
        private System.Windows.Forms.Label lblChip;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label lblAutoFocus;
        private Guna.UI2.WinForms.Guna2TextBox txtVideo;
        private System.Windows.Forms.Label lblVideo;
        private Guna.UI2.WinForms.Guna2TextBox txtShutterSpeed;
        private System.Windows.Forms.Label lblShutterSpeed;
        private Guna.UI2.WinForms.Guna2TextBox txtInternational;
        private System.Windows.Forms.Label lblInternational;
        private Guna.UI2.WinForms.Guna2ComboBox cbbProductName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}