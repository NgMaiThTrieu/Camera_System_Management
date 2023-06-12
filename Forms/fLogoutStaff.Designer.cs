namespace Camera_System_Management.Forms
{
    partial class fLogoutStaff
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
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconEyeHide = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.BorderColor = System.Drawing.Color.Khaki;
            this.btnExit.BorderRadius = 6;
            this.btnExit.BorderThickness = 2;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Khaki;
            this.btnExit.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(256, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 50);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BorderColor = System.Drawing.Color.Khaki;
            this.btnLogout.BorderRadius = 6;
            this.btnLogout.BorderThickness = 2;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLogout.ForeColor = System.Drawing.Color.Khaki;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(388, 232);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 50);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Animated = true;
            this.txbPassword.BorderColor = System.Drawing.Color.Khaki;
            this.txbPassword.BorderThickness = 3;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.DefaultText = "";
            this.txbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.FillColor = System.Drawing.Color.Transparent;
            this.txbPassword.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbPassword.ForeColor = System.Drawing.Color.Khaki;
            this.txbPassword.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txbPassword.Location = new System.Drawing.Point(77, 116);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txbPassword.PlaceholderText = "password";
            this.txbPassword.SelectedText = "";
            this.txbPassword.Size = new System.Drawing.Size(431, 38);
            this.txbPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbPassword.TabIndex = 19;
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.Black;
            this.txbUserName.BorderColor = System.Drawing.Color.Khaki;
            this.txbUserName.BorderThickness = 3;
            this.txbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUserName.DefaultText = "";
            this.txbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUserName.FillColor = System.Drawing.Color.Transparent;
            this.txbUserName.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txbUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbUserName.ForeColor = System.Drawing.Color.Khaki;
            this.txbUserName.HoverState.BorderColor = System.Drawing.Color.Gold;
            this.txbUserName.Location = new System.Drawing.Point(77, 45);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.PasswordChar = '\0';
            this.txbUserName.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txbUserName.PlaceholderText = "username";
            this.txbUserName.SelectedText = "";
            this.txbUserName.Size = new System.Drawing.Size(431, 38);
            this.txbUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbUserName.TabIndex = 18;
            this.txbUserName.Tag = "";
            // 
            // iconEyeHide
            // 
            this.iconEyeHide.BackColor = System.Drawing.Color.Black;
            this.iconEyeHide.FlatAppearance.BorderSize = 0;
            this.iconEyeHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEyeHide.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconEyeHide.IconColor = System.Drawing.Color.Khaki;
            this.iconEyeHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEyeHide.IconSize = 25;
            this.iconEyeHide.Location = new System.Drawing.Point(478, 120);
            this.iconEyeHide.Name = "iconEyeHide";
            this.iconEyeHide.Size = new System.Drawing.Size(30, 30);
            this.iconEyeHide.TabIndex = 20;
            this.iconEyeHide.UseVisualStyleBackColor = false;
            this.iconEyeHide.Visible = false;
            // 
            // fLogoutStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 327);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.iconEyeHide);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Name = "fLogoutStaff";
            this.Text = "fLogoutStaff";
            this.Load += new System.EventHandler(this.fLogoutStaff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private FontAwesome.Sharp.IconButton iconEyeHide;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword;
        private Guna.UI2.WinForms.Guna2TextBox txbUserName;
    }
}