namespace Quan_ly_san_the_thao
{
    partial class Customer
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.dgv_CustomerList = new System.Windows.Forms.DataGridView();
            this.btn_ChangePW = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(11, 567);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 33);
            this.btn_Search.TabIndex = 24;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deposit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Deposit.Location = new System.Drawing.Point(445, 567);
            this.btn_Deposit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(155, 33);
            this.btn_Deposit.TabIndex = 25;
            this.btn_Deposit.Text = "Nạp tiền";
            this.btn_Deposit.UseVisualStyleBackColor = false;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // dgv_CustomerList
            // 
            this.dgv_CustomerList.AllowUserToAddRows = false;
            this.dgv_CustomerList.AllowUserToDeleteRows = false;
            this.dgv_CustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.TenKH,
            this.Email,
            this.SDT,
            this.SLHoaDon,
            this.TrangThaiRequest});
            this.dgv_CustomerList.Location = new System.Drawing.Point(11, 36);
            this.dgv_CustomerList.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_CustomerList.Name = "dgv_CustomerList";
            this.dgv_CustomerList.ReadOnly = true;
            this.dgv_CustomerList.RowHeadersWidth = 51;
            this.dgv_CustomerList.RowTemplate.Height = 24;
            this.dgv_CustomerList.Size = new System.Drawing.Size(750, 505);
            this.dgv_CustomerList.TabIndex = 15;
            this.dgv_CustomerList.SelectionChanged += new System.EventHandler(this.dgv_CustomerList_SelectionChanged);
            // 
            // btn_ChangePW
            // 
            this.btn_ChangePW.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ChangePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePW.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ChangePW.Location = new System.Drawing.Point(604, 567);
            this.btn_ChangePW.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChangePW.Name = "btn_ChangePW";
            this.btn_ChangePW.Size = new System.Drawing.Size(155, 33);
            this.btn_ChangePW.TabIndex = 25;
            this.btn_ChangePW.Text = "Đổi mật khẩu";
            this.btn_ChangePW.UseVisualStyleBackColor = false;
            this.btn_ChangePW.Click += new System.EventHandler(this.btn_ChangePW_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(140, 575);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(267, 20);
            this.tb_Search.TabIndex = 27;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Close.BackgroundImage = global::Quan_ly_san_the_thao.Properties.Resources._63769;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Location = new System.Drawing.Point(742, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.TabIndex = 26;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SLHoaDon
            // 
            this.SLHoaDon.DataPropertyName = "SLHoaDon";
            this.SLHoaDon.HeaderText = "Số lượng hóa đơn";
            this.SLHoaDon.Name = "SLHoaDon";
            this.SLHoaDon.ReadOnly = true;
            this.SLHoaDon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TrangThaiRequest
            // 
            this.TrangThaiRequest.DataPropertyName = "TrangThaiRequest";
            this.TrangThaiRequest.HeaderText = "Trạng thái yêu cầu";
            this.TrangThaiRequest.Name = "TrangThaiRequest";
            this.TrangThaiRequest.ReadOnly = true;
            this.TrangThaiRequest.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 611);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_ChangePW);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.dgv_CustomerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.DataGridView dgv_CustomerList;
        private System.Windows.Forms.Button btn_ChangePW;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiRequest;
    }
}