namespace Quan_ly_san_the_thao
{
    partial class MainMenu
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
            this.pn_Main = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_SelectField = new System.Windows.Forms.Button();
            this.pn_settingSubmenu = new System.Windows.Forms.Panel();
            this.btn_Donate = new System.Windows.Forms.Button();
            this.btn_ChangePW = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.pn_ShortInfo = new System.Windows.Forms.Panel();
            this.lb_Balance = new System.Windows.Forms.Label();
            this.lb_Hello = new System.Windows.Forms.Label();
            this.pn_SubmenuForm = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pn_Main.SuspendLayout();
            this.pn_settingSubmenu.SuspendLayout();
            this.pn_ShortInfo.SuspendLayout();
            this.pn_SubmenuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Main
            // 
            this.pn_Main.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_Main.Controls.Add(this.btn_Logout);
            this.pn_Main.Controls.Add(this.btn_SelectField);
            this.pn_Main.Controls.Add(this.pn_settingSubmenu);
            this.pn_Main.Controls.Add(this.btn_Settings);
            this.pn_Main.Controls.Add(this.pn_ShortInfo);
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Main.Location = new System.Drawing.Point(0, 0);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(174, 611);
            this.pn_Main.TabIndex = 8;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Logout.Location = new System.Drawing.Point(0, 352);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Logout.Size = new System.Drawing.Size(174, 50);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_SelectField
            // 
            this.btn_SelectField.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SelectField.FlatAppearance.BorderSize = 0;
            this.btn_SelectField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectField.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectField.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_SelectField.Location = new System.Drawing.Point(0, 302);
            this.btn_SelectField.Name = "btn_SelectField";
            this.btn_SelectField.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_SelectField.Size = new System.Drawing.Size(174, 50);
            this.btn_SelectField.TabIndex = 2;
            this.btn_SelectField.Text = "Đặt sân";
            this.btn_SelectField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SelectField.UseVisualStyleBackColor = true;
            this.btn_SelectField.Click += new System.EventHandler(this.btn_SelectField_Click);
            // 
            // pn_settingSubmenu
            // 
            this.pn_settingSubmenu.Controls.Add(this.btn_Donate);
            this.pn_settingSubmenu.Controls.Add(this.btn_ChangePW);
            this.pn_settingSubmenu.Controls.Add(this.btn_Profile);
            this.pn_settingSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_settingSubmenu.Location = new System.Drawing.Point(0, 150);
            this.pn_settingSubmenu.Name = "pn_settingSubmenu";
            this.pn_settingSubmenu.Size = new System.Drawing.Size(174, 152);
            this.pn_settingSubmenu.TabIndex = 1;
            // 
            // btn_Donate
            // 
            this.btn_Donate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Donate.FlatAppearance.BorderSize = 0;
            this.btn_Donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Donate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Donate.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Donate.Location = new System.Drawing.Point(0, 100);
            this.btn_Donate.Name = "btn_Donate";
            this.btn_Donate.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Donate.Size = new System.Drawing.Size(174, 50);
            this.btn_Donate.TabIndex = 2;
            this.btn_Donate.Text = "Nạp tiền";
            this.btn_Donate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Donate.UseVisualStyleBackColor = true;
            this.btn_Donate.Click += new System.EventHandler(this.btn_Donate_Click);
            // 
            // btn_ChangePW
            // 
            this.btn_ChangePW.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChangePW.FlatAppearance.BorderSize = 0;
            this.btn_ChangePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePW.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePW.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_ChangePW.Location = new System.Drawing.Point(0, 50);
            this.btn_ChangePW.Name = "btn_ChangePW";
            this.btn_ChangePW.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_ChangePW.Size = new System.Drawing.Size(174, 50);
            this.btn_ChangePW.TabIndex = 1;
            this.btn_ChangePW.Text = "Đổi mật khẩu";
            this.btn_ChangePW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangePW.UseVisualStyleBackColor = true;
            this.btn_ChangePW.Click += new System.EventHandler(this.btn_ChangePW_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Profile.Location = new System.Drawing.Point(0, 0);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Profile.Size = new System.Drawing.Size(174, 50);
            this.btn_Profile.TabIndex = 0;
            this.btn_Profile.Text = "Thông tin cá nhân";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Settings.Location = new System.Drawing.Point(0, 100);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Settings.Size = new System.Drawing.Size(174, 50);
            this.btn_Settings.TabIndex = 0;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // pn_ShortInfo
            // 
            this.pn_ShortInfo.Controls.Add(this.lb_Balance);
            this.pn_ShortInfo.Controls.Add(this.lb_Hello);
            this.pn_ShortInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_ShortInfo.Location = new System.Drawing.Point(0, 0);
            this.pn_ShortInfo.Name = "pn_ShortInfo";
            this.pn_ShortInfo.Size = new System.Drawing.Size(174, 100);
            this.pn_ShortInfo.TabIndex = 0;
            // 
            // lb_Balance
            // 
            this.lb_Balance.AutoSize = true;
            this.lb_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Balance.Location = new System.Drawing.Point(3, 31);
            this.lb_Balance.Name = "lb_Balance";
            this.lb_Balance.Size = new System.Drawing.Size(118, 13);
            this.lb_Balance.TabIndex = 1;
            this.lb_Balance.Text = "Số dư: xxx.xxx VND";
            this.lb_Balance.TextChanged += new System.EventHandler(this.UserLoggedIn_TextChanged);
            // 
            // lb_Hello
            // 
            this.lb_Hello.AutoSize = true;
            this.lb_Hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hello.Location = new System.Drawing.Point(3, 9);
            this.lb_Hello.Name = "lb_Hello";
            this.lb_Hello.Size = new System.Drawing.Size(170, 13);
            this.lb_Hello.TabIndex = 0;
            this.lb_Hello.Text = "Xin chào, [Tên khách hàng]!";
            this.lb_Hello.TextChanged += new System.EventHandler(this.UserLoggedIn_TextChanged);
            // 
            // pn_SubmenuForm
            // 
            this.pn_SubmenuForm.BackgroundImage = global::Quan_ly_san_the_thao.Properties.Resources.wallpaperflare_com_wallpaper;
            this.pn_SubmenuForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_SubmenuForm.Controls.Add(this.btn_Close);
            this.pn_SubmenuForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_SubmenuForm.Location = new System.Drawing.Point(174, 0);
            this.pn_SubmenuForm.Name = "pn_SubmenuForm";
            this.pn_SubmenuForm.Size = new System.Drawing.Size(770, 611);
            this.pn_SubmenuForm.TabIndex = 4;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Close.BackgroundImage = global::Quan_ly_san_the_thao.Properties.Resources._63769;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Close.Location = new System.Drawing.Point(742, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.TabIndex = 21;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 611);
            this.Controls.Add(this.pn_SubmenuForm);
            this.Controls.Add(this.pn_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.pn_Main.ResumeLayout(false);
            this.pn_settingSubmenu.ResumeLayout(false);
            this.pn_ShortInfo.ResumeLayout(false);
            this.pn_ShortInfo.PerformLayout();
            this.pn_SubmenuForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel pn_ShortInfo;
        private System.Windows.Forms.Panel pn_settingSubmenu;
        private System.Windows.Forms.Button btn_Donate;
        private System.Windows.Forms.Button btn_ChangePW;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Button btn_SelectField;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lb_Balance;
        private System.Windows.Forms.Label lb_Hello;
        private System.Windows.Forms.Panel pn_SubmenuForm;
        private System.Windows.Forms.Button btn_Close;
    }
}