namespace Camera_System_Management.Forms
{
    partial class fProductOrigin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvProductOrigin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOriginInformation = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtOriginCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOriginCode = new System.Windows.Forms.Label();
            this.txtOriginName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProductOrigin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.colOriginCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrigin)).BeginInit();
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
            this.tableLayoutPanel1.TabIndex = 16;
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
            this.panel5.Controls.Add(this.dgvProductOrigin);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.panel5.Size = new System.Drawing.Size(1186, 321);
            this.panel5.TabIndex = 0;
            // 
            // dgvProductOrigin
            // 
            this.dgvProductOrigin.AllowUserToAddRows = false;
            this.dgvProductOrigin.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvProductOrigin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProductOrigin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductOrigin.BackgroundColor = System.Drawing.Color.Black;
            this.dgvProductOrigin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductOrigin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductOrigin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductOrigin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProductOrigin.ColumnHeadersHeight = 40;
            this.dgvProductOrigin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOriginCode,
            this.colOrigin});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductOrigin.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProductOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductOrigin.EnableHeadersVisualStyles = false;
            this.dgvProductOrigin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvProductOrigin.Location = new System.Drawing.Point(13, 0);
            this.dgvProductOrigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductOrigin.Name = "dgvProductOrigin";
            this.dgvProductOrigin.ReadOnly = true;
            this.dgvProductOrigin.RowHeadersVisible = false;
            this.dgvProductOrigin.RowHeadersWidth = 51;
            this.dgvProductOrigin.RowTemplate.Height = 30;
            this.dgvProductOrigin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductOrigin.Size = new System.Drawing.Size(1160, 321);
            this.dgvProductOrigin.TabIndex = 14;
            this.dgvProductOrigin.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvProductOrigin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvProductOrigin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductOrigin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductOrigin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductOrigin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductOrigin.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvProductOrigin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvProductOrigin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Khaki;
            this.dgvProductOrigin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductOrigin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.dgvProductOrigin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductOrigin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProductOrigin.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProductOrigin.ThemeStyle.ReadOnly = true;
            this.dgvProductOrigin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvProductOrigin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductOrigin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvProductOrigin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductOrigin.ThemeStyle.RowsStyle.Height = 30;
            this.dgvProductOrigin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvProductOrigin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductOrigin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductOrigin_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtOriginCode);
            this.panel2.Controls.Add(this.lblOriginCode);
            this.panel2.Controls.Add(this.txtOriginName);
            this.panel2.Controls.Add(this.lblProductOrigin);
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
            this.panel4.Controls.Add(this.lblOriginInformation);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(13, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1160, 49);
            this.panel4.TabIndex = 20;
            // 
            // lblOriginInformation
            // 
            this.lblOriginInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOriginInformation.AutoSize = true;
            this.lblOriginInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblOriginInformation.Location = new System.Drawing.Point(384, 6);
            this.lblOriginInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOriginInformation.Name = "lblOriginInformation";
            this.lblOriginInformation.Size = new System.Drawing.Size(229, 31);
            this.lblOriginInformation.TabIndex = 4;
            this.lblOriginInformation.Text = "Origin Information";
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
            // txtOriginCode
            // 
            this.txtOriginCode.BackColor = System.Drawing.Color.Black;
            this.txtOriginCode.BorderColor = System.Drawing.Color.Khaki;
            this.txtOriginCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOriginCode.DefaultText = "";
            this.txtOriginCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOriginCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOriginCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOriginCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOriginCode.Enabled = false;
            this.txtOriginCode.FillColor = System.Drawing.Color.Transparent;
            this.txtOriginCode.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtOriginCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOriginCode.ForeColor = System.Drawing.Color.Khaki;
            this.txtOriginCode.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtOriginCode.Location = new System.Drawing.Point(237, 82);
            this.txtOriginCode.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtOriginCode.MaxLength = 500;
            this.txtOriginCode.Name = "txtOriginCode";
            this.txtOriginCode.PasswordChar = '\0';
            this.txtOriginCode.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtOriginCode.PlaceholderText = "origin code";
            this.txtOriginCode.SelectedText = "";
            this.txtOriginCode.Size = new System.Drawing.Size(277, 31);
            this.txtOriginCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtOriginCode.TabIndex = 16;
            // 
            // lblOriginCode
            // 
            this.lblOriginCode.AutoSize = true;
            this.lblOriginCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOriginCode.ForeColor = System.Drawing.Color.Khaki;
            this.lblOriginCode.Location = new System.Drawing.Point(92, 85);
            this.lblOriginCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOriginCode.Name = "lblOriginCode";
            this.lblOriginCode.Size = new System.Drawing.Size(117, 25);
            this.lblOriginCode.TabIndex = 15;
            this.lblOriginCode.Text = "Origin Code";
            // 
            // txtOriginName
            // 
            this.txtOriginName.BackColor = System.Drawing.Color.Black;
            this.txtOriginName.BorderColor = System.Drawing.Color.Khaki;
            this.txtOriginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOriginName.DefaultText = "";
            this.txtOriginName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOriginName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOriginName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOriginName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOriginName.FillColor = System.Drawing.Color.Transparent;
            this.txtOriginName.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtOriginName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOriginName.ForeColor = System.Drawing.Color.Khaki;
            this.txtOriginName.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txtOriginName.Location = new System.Drawing.Point(709, 82);
            this.txtOriginName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtOriginName.MaxLength = 500;
            this.txtOriginName.Name = "txtOriginName";
            this.txtOriginName.PasswordChar = '\0';
            this.txtOriginName.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txtOriginName.PlaceholderText = "product origin";
            this.txtOriginName.SelectedText = "";
            this.txtOriginName.Size = new System.Drawing.Size(381, 31);
            this.txtOriginName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtOriginName.TabIndex = 14;
            this.txtOriginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOriginName_KeyPress);
            // 
            // lblProductOrigin
            // 
            this.lblProductOrigin.AutoSize = true;
            this.lblProductOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductOrigin.ForeColor = System.Drawing.Color.Khaki;
            this.lblProductOrigin.Location = new System.Drawing.Point(560, 85);
            this.lblProductOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductOrigin.Name = "lblProductOrigin";
            this.lblProductOrigin.Size = new System.Drawing.Size(136, 25);
            this.lblProductOrigin.TabIndex = 13;
            this.lblProductOrigin.Text = "Product Origin";
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
            // colOriginCode
            // 
            this.colOriginCode.DataPropertyName = "Ori_ID";
            this.colOriginCode.HeaderText = "Origin Code";
            this.colOriginCode.MinimumWidth = 6;
            this.colOriginCode.Name = "colOriginCode";
            this.colOriginCode.ReadOnly = true;
            // 
            // colOrigin
            // 
            this.colOrigin.DataPropertyName = "Origin";
            this.colOrigin.HeaderText = "Origin";
            this.colOrigin.MinimumWidth = 6;
            this.colOrigin.Name = "colOrigin";
            this.colOrigin.ReadOnly = true;
            // 
            // fProductOrigin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fProductOrigin";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fProductOrigin";
            this.Load += new System.EventHandler(this.fProductOrigin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrigin)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductOrigin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblOriginInformation;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtOriginCode;
        private System.Windows.Forms.Label lblOriginCode;
        private Guna.UI2.WinForms.Guna2TextBox txtOriginName;
        private System.Windows.Forms.Label lblProductOrigin;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOriginCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigin;
    }
}