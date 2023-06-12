namespace Camera_System_Management.Forms
{
    partial class fLogin_Staff
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
            this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.iconEyeHide = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
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
            this.txbPassword.Location = new System.Drawing.Point(66, 110);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txbPassword.PlaceholderText = "password";
            this.txbPassword.SelectedText = "";
            this.txbPassword.Size = new System.Drawing.Size(431, 38);
            this.txbPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbPassword.TabIndex = 14;
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
            this.txbUserName.Location = new System.Drawing.Point(66, 39);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.PasswordChar = '\0';
            this.txbUserName.PlaceholderForeColor = System.Drawing.Color.LemonChiffon;
            this.txbUserName.PlaceholderText = "username";
            this.txbUserName.SelectedText = "";
            this.txbUserName.Size = new System.Drawing.Size(431, 38);
            this.txbUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbUserName.TabIndex = 13;
            this.txbUserName.Tag = "";
            this.txbUserName.TextChanged += new System.EventHandler(this.txbUserName_TextChanged);
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
            this.btnExit.Location = new System.Drawing.Point(249, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 50);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderColor = System.Drawing.Color.Khaki;
            this.btnLogin.BorderRadius = 6;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLogin.ForeColor = System.Drawing.Color.Khaki;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.Khaki;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.Khaki;
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(377, 226);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 50);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.iconEyeHide.Location = new System.Drawing.Point(467, 114);
            this.iconEyeHide.Name = "iconEyeHide";
            this.iconEyeHide.Size = new System.Drawing.Size(30, 30);
            this.iconEyeHide.TabIndex = 15;
            this.iconEyeHide.UseVisualStyleBackColor = false;
            this.iconEyeHide.Visible = false;
            // 
            // fLogin_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 327);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.iconEyeHide);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Name = "fLogin_Staff";
            this.Text = "fLogin_Staff";
            this.Load += new System.EventHandler(this.fLogin_Staff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconEyeHide;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword;
        private Guna.UI2.WinForms.Guna2TextBox txbUserName;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}