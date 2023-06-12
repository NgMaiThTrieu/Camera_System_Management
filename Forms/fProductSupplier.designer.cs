namespace Camera_System_Management.Forms
{
    partial class fProductSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvProductSupplier = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSupplierInformation = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtSupplierCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.txtSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.colSupplierCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSupplier)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 611);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 321);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvProductSupplier);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.panel5.Size = new System.Drawing.Size(1186, 321);
            this.panel5.TabIndex = 0;
            // 
            // dgvProductSupplier
            // 
            this.dgvProductSupplier.AllowUserToAddRows = false;
            this.dgvProductSupplier.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvProductSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductSupplier.BackgroundColor = System.Drawing.Color.Black;
            this.dgvProductSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductSupplier.ColumnHeadersHeight = 40;
            this.dgvProductSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSupplierCode,
            this.colSupplier});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductSupplier.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductSupplier.EnableHeadersVisualStyles = false;
            this.dgvProductSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvProductSupplier.Location = new System.Drawing.Point(13, 0);
            this.dgvProductSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductSupplier.Name = "dgvProductSupplier";
            this.dgvProductSupplier.ReadOnly = true;
            this.dgvProductSupplier.RowHeadersVisible = false;
            this.dgvProductSupplier.RowHeadersWidth = 51;
            this.dgvProductSupplier.RowTemplate.Height = 30;
            this.dgvProductSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductSupplier.Size = new System.Drawing.Size(1160, 321);
            this.dgvProductSupplier.TabIndex = 14;
            this.dgvProductSupplier.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvProductSupplier.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvProductSupplier.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductSupplier.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductSupplier.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductSupplier.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductSupplier.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvProductSupplier.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvProductSupplier.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Khaki;
            this.dgvProductSupplier.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductSupplier.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dgvProductSupplier.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductSupplier.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProductSupplier.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProductSupplier.ThemeStyle.ReadOnly = true;
            this.dgvProductSupplier.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvProductSupplier.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductSupplier.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvProductSupplier.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductSupplier.ThemeStyle.RowsStyle.Height = 30;
            this.dgvProductSupplier.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvProductSupplier.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductSupplier_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtSupplierCode);
            this.panel2.Controls.Add(this.lblSupplierCode);
            this.panel2.Controls.Add(this.txtSupplier);
            this.panel2.Controls.Add(this.lblProductSupplier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 395);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.panel2.Size = new System.Drawing.Size(1186, 212);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Controls.Add(this.lblSupplierInformation);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(13, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1160, 49);
            this.panel4.TabIndex = 20;
            // 
            // lblSupplierInformation
            // 
            this.lblSupplierInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSupplierInformation.AutoSize = true;
            this.lblSupplierInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSupplierInformation.Location = new System.Drawing.Point(355, 6);
            this.lblSupplierInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierInformation.Name = "lblSupplierInformation";
            this.lblSupplierInformation.Size = new System.Drawing.Size(256, 31);
            this.lblSupplierInformation.TabIndex = 4;
            this.lblSupplierInformation.Text = "Supplier Information";
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
            this.btnAdd.Location = new System.Drawing.Point(472, 142);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnRemove.Location = new System.Drawing.Point(644, 142);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 62);
            this.btnRemove.TabIndex = 18;
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
            this.btnUpdate.Location = new System.Drawing.Point(883, 142);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(205, 62);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.BackColor = System.Drawing.Color.Black;
            this.txtSupplierCode.BorderColor = System.Drawing.Color.Khaki;
            this.txtSupplierCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierCode.DefaultText = "";
            this.txtSupplierCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupplierCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupplierCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplierCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplierCode.Enabled = false;
            this.txtSupplierCode.FillColor = System.Drawing.Color.Transparent;
            this.txtSupplierCode.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtSupplierCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplierCode.ForeColor = System.Drawing.Color.Khaki;
            this.txtSupplierCode.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtSupplierCode.Location = new System.Drawing.Point(237, 82);
            this.txtSupplierCode.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSupplierCode.MaxLength = 500;
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.PasswordChar = '\0';
            this.txtSupplierCode.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtSupplierCode.PlaceholderText = "supplier code";
            this.txtSupplierCode.SelectedText = "";
            this.txtSupplierCode.Size = new System.Drawing.Size(247, 31);
            this.txtSupplierCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSupplierCode.TabIndex = 16;
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSupplierCode.ForeColor = System.Drawing.Color.Khaki;
            this.lblSupplierCode.Location = new System.Drawing.Point(92, 85);
            this.lblSupplierCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(137, 25);
            this.lblSupplierCode.TabIndex = 15;
            this.lblSupplierCode.Text = "Supplier Code";
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.Black;
            this.txtSupplier.BorderColor = System.Drawing.Color.Khaki;
            this.txtSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplier.DefaultText = "";
            this.txtSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplier.FillColor = System.Drawing.Color.Transparent;
            this.txtSupplier.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplier.ForeColor = System.Drawing.Color.Khaki;
            this.txtSupplier.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtSupplier.Location = new System.Drawing.Point(709, 82);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSupplier.MaxLength = 500;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtSupplier.PlaceholderText = "product origin";
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.Size = new System.Drawing.Size(381, 31);
            this.txtSupplier.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSupplier.TabIndex = 14;
            this.txtSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplier_KeyPress);
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductSupplier.ForeColor = System.Drawing.Color.Khaki;
            this.lblProductSupplier.Location = new System.Drawing.Point(533, 85);
            this.lblProductSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(156, 25);
            this.lblProductSupplier.TabIndex = 13;
            this.lblProductSupplier.Text = "Product Supplier";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 43);
            this.btnClose.TabIndex = 14;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.DataPropertyName = "Supp_ID";
            this.colSupplierCode.HeaderText = "Supplier Code";
            this.colSupplierCode.MinimumWidth = 6;
            this.colSupplierCode.Name = "colSupplierCode";
            this.colSupplierCode.ReadOnly = true;
            // 
            // colSupplier
            // 
            this.colSupplier.DataPropertyName = "Supp_Name";
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.MinimumWidth = 6;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            // 
            // fProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fProductSupplier";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSupplier1";
            this.Load += new System.EventHandler(this.fProductSupplier_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSupplier)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductSupplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSupplierInformation;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplierCode;
        private System.Windows.Forms.Label lblSupplierCode;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplier;
        private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
    }
}