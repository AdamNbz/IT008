namespace Quan_ly_san_the_thao
{
    partial class AdministratorForm
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
            System.Windows.Forms.Button btn_Bill;
            System.Windows.Forms.Button btn_Customer;
            System.Windows.Forms.Button btn_Coupon;
            this.lb_Hello = new System.Windows.Forms.Label();
            this.lb_Balance = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.pn_ShortInfo = new System.Windows.Forms.Panel();
            this.lb_Role = new System.Windows.Forms.Label();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.lb_Greeting = new System.Windows.Forms.Label();
            btn_Bill = new System.Windows.Forms.Button();
            btn_Customer = new System.Windows.Forms.Button();
            btn_Coupon = new System.Windows.Forms.Button();
            this.pn_ShortInfo.SuspendLayout();
            this.pn_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Bill
            // 
            btn_Bill.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Bill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Bill.Location = new System.Drawing.Point(924, 324);
            btn_Bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Bill.Name = "btn_Bill";
            btn_Bill.Size = new System.Drawing.Size(175, 63);
            btn_Bill.TabIndex = 13;
            btn_Bill.Text = "Hóa đơn";
            btn_Bill.UseVisualStyleBackColor = true;
            // 
            // btn_Customer
            // 
            btn_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Customer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btn_Customer.Location = new System.Drawing.Point(726, 324);
            btn_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Customer.Name = "btn_Customer";
            btn_Customer.Size = new System.Drawing.Size(175, 63);
            btn_Customer.TabIndex = 12;
            btn_Customer.Text = "Khách hàng";
            btn_Customer.UseVisualStyleBackColor = true;
            // 
            // btn_Coupon
            // 
            btn_Coupon.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Coupon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btn_Coupon.Location = new System.Drawing.Point(521, 324);
            btn_Coupon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Coupon.Name = "btn_Coupon";
            btn_Coupon.Size = new System.Drawing.Size(175, 63);
            btn_Coupon.TabIndex = 11;
            btn_Coupon.Text = "Mã giảm giá";
            btn_Coupon.UseVisualStyleBackColor = true;
            // 
            // lb_Hello
            // 
            this.lb_Hello.AutoSize = true;
            this.lb_Hello.Location = new System.Drawing.Point(4, 11);
            this.lb_Hello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Hello.Name = "lb_Hello";
            this.lb_Hello.Size = new System.Drawing.Size(171, 16);
            this.lb_Hello.TabIndex = 0;
            this.lb_Hello.Text = "Xin chào, [Tên khách hàng]!";
            // 
            // lb_Balance
            // 
            this.lb_Balance.AutoSize = true;
            this.lb_Balance.Location = new System.Drawing.Point(4, 38);
            this.lb_Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Balance.Name = "lb_Balance";
            this.lb_Balance.Size = new System.Drawing.Size(119, 16);
            this.lb_Balance.TabIndex = 1;
            this.lb_Balance.Text = "Số dư: xxx.xxx VND";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Logout.Location = new System.Drawing.Point(0, 185);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_Logout.Size = new System.Drawing.Size(232, 62);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // btn_Profile
            // 
            this.btn_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Profile.Location = new System.Drawing.Point(0, 123);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_Profile.Size = new System.Drawing.Size(232, 62);
            this.btn_Profile.TabIndex = 0;
            this.btn_Profile.Text = "Thông tin cá nhân";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.UseVisualStyleBackColor = true;
            // 
            // pn_ShortInfo
            // 
            this.pn_ShortInfo.Controls.Add(this.lb_Role);
            this.pn_ShortInfo.Controls.Add(this.lb_Balance);
            this.pn_ShortInfo.Controls.Add(this.lb_Hello);
            this.pn_ShortInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_ShortInfo.Location = new System.Drawing.Point(0, 0);
            this.pn_ShortInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pn_ShortInfo.Name = "pn_ShortInfo";
            this.pn_ShortInfo.Size = new System.Drawing.Size(232, 123);
            this.pn_ShortInfo.TabIndex = 0;
            // 
            // lb_Role
            // 
            this.lb_Role.AutoSize = true;
            this.lb_Role.Location = new System.Drawing.Point(4, 66);
            this.lb_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(95, 16);
            this.lb_Role.TabIndex = 2;
            this.lb_Role.Text = "Vai trò: [vai trò]";
            // 
            // pn_Main
            // 
            this.pn_Main.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_Main.Controls.Add(this.btn_Logout);
            this.pn_Main.Controls.Add(this.btn_Profile);
            this.pn_Main.Controls.Add(this.pn_ShortInfo);
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Main.Location = new System.Drawing.Point(0, 0);
            this.pn_Main.Margin = new System.Windows.Forms.Padding(4);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(232, 752);
            this.pn_Main.TabIndex = 15;
            // 
            // lb_Greeting
            // 
            this.lb_Greeting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Greeting.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_Greeting.Location = new System.Drawing.Point(415, 214);
            this.lb_Greeting.Name = "lb_Greeting";
            this.lb_Greeting.Size = new System.Drawing.Size(796, 89);
            this.lb_Greeting.TabIndex = 9;
            this.lb_Greeting.Text = "CHÀO MỪNG [TÊN KHÁCH HÀNG]";
            this.lb_Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 752);
            this.Controls.Add(btn_Bill);
            this.Controls.Add(btn_Customer);
            this.Controls.Add(btn_Coupon);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.lb_Greeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.pn_ShortInfo.ResumeLayout(false);
            this.pn_ShortInfo.PerformLayout();
            this.pn_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Hello;
        private System.Windows.Forms.Label lb_Balance;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Panel pn_ShortInfo;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.Label lb_Greeting;
        private System.Windows.Forms.Label lb_Role;
    }
}