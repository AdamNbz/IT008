namespace Quan_ly_san_the_thao
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.lb_Fullname = new System.Windows.Forms.Label();
            this.tb_Fullname = new System.Windows.Forms.TextBox();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.lb_Username = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.tb_Gender = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Request = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb_Cancel = new System.Windows.Forms.PictureBox();
            this.pb_Tick = new System.Windows.Forms.PictureBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.lb_Customer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Tick)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Fullname,
            this.Phone,
            this.Email,
            this.Gender,
            this.Note});
            this.dgv_Customer.Location = new System.Drawing.Point(12, 48);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.RowHeadersWidth = 51;
            this.dgv_Customer.RowTemplate.Height = 24;
            this.dgv_Customer.Size = new System.Drawing.Size(776, 301);
            this.dgv_Customer.TabIndex = 4;
            // 
            // lb_Fullname
            // 
            this.lb_Fullname.AutoSize = true;
            this.lb_Fullname.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fullname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Fullname.Location = new System.Drawing.Point(44, 416);
            this.lb_Fullname.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Fullname.Name = "lb_Fullname";
            this.lb_Fullname.Size = new System.Drawing.Size(79, 20);
            this.lb_Fullname.TabIndex = 5;
            this.lb_Fullname.Text = "Họ tên:";
            // 
            // tb_Fullname
            // 
            this.tb_Fullname.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Fullname.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fullname.Location = new System.Drawing.Point(129, 413);
            this.tb_Fullname.Name = "tb_Fullname";
            this.tb_Fullname.ReadOnly = true;
            this.tb_Fullname.Size = new System.Drawing.Size(289, 28);
            this.tb_Fullname.TabIndex = 7;
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Phone.Location = new System.Drawing.Point(443, 366);
            this.lb_Phone.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(142, 20);
            this.lb_Phone.TabIndex = 8;
            this.lb_Phone.Text = "Số điện thoại:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Phone.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(591, 363);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.ReadOnly = true;
            this.tb_Phone.Size = new System.Drawing.Size(145, 28);
            this.tb_Phone.TabIndex = 9;
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Username.Location = new System.Drawing.Point(44, 366);
            this.lb_Username.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(157, 20);
            this.lb_Username.TabIndex = 10;
            this.lb_Username.Text = "Tên đăng nhập:";
            // 
            // tb_Username
            // 
            this.tb_Username.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Username.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(207, 363);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.ReadOnly = true;
            this.tb_Username.Size = new System.Drawing.Size(211, 28);
            this.tb_Username.TabIndex = 11;
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Gender.Location = new System.Drawing.Point(487, 416);
            this.lb_Gender.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(98, 20);
            this.lb_Gender.TabIndex = 12;
            this.lb_Gender.Text = "Giới tính:";
            // 
            // tb_Gender
            // 
            this.tb_Gender.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Gender.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Gender.Location = new System.Drawing.Point(591, 413);
            this.tb_Gender.Name = "tb_Gender";
            this.tb_Gender.ReadOnly = true;
            this.tb_Gender.Size = new System.Drawing.Size(145, 28);
            this.tb_Gender.TabIndex = 13;
            // 
            // lb_Email
            // 
            this.lb_Email.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Email.Location = new System.Drawing.Point(44, 466);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(79, 20);
            this.lb_Email.TabIndex = 14;
            this.lb_Email.Text = "Email:";
            // 
            // tb_Email
            // 
            this.tb_Email.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Email.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(129, 466);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.ReadOnly = true;
            this.tb_Email.Size = new System.Drawing.Size(289, 28);
            this.tb_Email.TabIndex = 15;
            // 
            // lb_Request
            // 
            this.lb_Request.AutoSize = true;
            this.lb_Request.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Request.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Request.Location = new System.Drawing.Point(44, 516);
            this.lb_Request.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Request.Name = "lb_Request";
            this.lb_Request.Size = new System.Drawing.Size(222, 20);
            this.lb_Request.TabIndex = 16;
            this.lb_Request.Text = "Yêu cầu đổi mật khẩu:";
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.FillWeight = 150F;
            this.Username.HeaderText = "Tên đăng nhập";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fullname.FillWeight = 200F;
            this.Fullname.HeaderText = "Họ tên";
            this.Fullname.MinimumWidth = 6;
            this.Fullname.Name = "Fullname";
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.FillWeight = 200F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.HeaderText = "Ghi chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            // 
            // pb_Cancel
            // 
            this.pb_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("pb_Cancel.Image")));
            this.pb_Cancel.Location = new System.Drawing.Point(317, 511);
            this.pb_Cancel.Name = "pb_Cancel";
            this.pb_Cancel.Size = new System.Drawing.Size(30, 30);
            this.pb_Cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Cancel.TabIndex = 20;
            this.pb_Cancel.TabStop = false;
            // 
            // pb_Tick
            // 
            this.pb_Tick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Tick.Image = ((System.Drawing.Image)(resources.GetObject("pb_Tick.Image")));
            this.pb_Tick.Location = new System.Drawing.Point(281, 511);
            this.pb_Tick.Name = "pb_Tick";
            this.pb_Tick.Size = new System.Drawing.Size(30, 30);
            this.pb_Tick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Tick.TabIndex = 19;
            this.pb_Tick.TabStop = false;
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Return.Image = global::Quan_ly_san_the_thao.Properties.Resources.back_arrow;
            this.btn_Return.Location = new System.Drawing.Point(12, 13);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(28, 28);
            this.btn_Return.TabIndex = 3;
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // lb_Customer
            // 
            this.lb_Customer.AutoSize = true;
            this.lb_Customer.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Customer.Location = new System.Drawing.Point(213, 9);
            this.lb_Customer.Name = "lb_Customer";
            this.lb_Customer.Size = new System.Drawing.Size(372, 34);
            this.lb_Customer.TabIndex = 21;
            this.lb_Customer.Text = "Danh sách khách hàng";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.lb_Customer);
            this.Controls.Add(this.pb_Cancel);
            this.Controls.Add(this.pb_Tick);
            this.Controls.Add(this.lb_Request);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.tb_Gender);
            this.Controls.Add(this.lb_Gender);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.tb_Fullname);
            this.Controls.Add(this.lb_Fullname);
            this.Controls.Add(this.dgv_Customer);
            this.Controls.Add(this.btn_Return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Tick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.Label lb_Fullname;
        private System.Windows.Forms.TextBox tb_Fullname;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.TextBox tb_Gender;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_Request;
        private System.Windows.Forms.PictureBox pb_Tick;
        private System.Windows.Forms.PictureBox pb_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Label lb_Customer;
    }
}