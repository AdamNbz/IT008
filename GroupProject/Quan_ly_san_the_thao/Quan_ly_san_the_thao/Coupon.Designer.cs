namespace Quan_ly_san_the_thao
{
    partial class Coupon
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
            this.btn_Return = new System.Windows.Forms.Button();
            this.dgv_Coupon = new System.Windows.Forms.DataGridView();
            this.CouponCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDauColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThucColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_CouponCode = new System.Windows.Forms.Label();
            this.lb_Type = new System.Windows.Forms.Label();
            this.tb_CouponCode = new System.Windows.Forms.TextBox();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.lb_Value = new System.Windows.Forms.Label();
            this.tb_Value = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lb_Publish = new System.Windows.Forms.Label();
            this.ckb_Publish = new System.Windows.Forms.CheckBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Coupon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Return.Image = global::Quan_ly_san_the_thao.Properties.Resources.back_arrow;
            this.btn_Return.Location = new System.Drawing.Point(12, 14);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(28, 28);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // dgv_Coupon
            // 
            this.dgv_Coupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Coupon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CouponCode,
            this.Type,
            this.Value,
            this.ThoiGianBatDauColumn,
            this.ThoiGianKetThucColumn});
            this.dgv_Coupon.Location = new System.Drawing.Point(12, 48);
            this.dgv_Coupon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Coupon.Name = "dgv_Coupon";
            this.dgv_Coupon.RowHeadersWidth = 51;
            this.dgv_Coupon.RowTemplate.Height = 24;
            this.dgv_Coupon.Size = new System.Drawing.Size(719, 302);
            this.dgv_Coupon.TabIndex = 3;
            // 
            // CouponCode
            // 
            this.CouponCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CouponCode.HeaderText = "Mã giảm giá";
            this.CouponCode.MinimumWidth = 6;
            this.CouponCode.Name = "CouponCode";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Môn thể thao áp dụng";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Giá trị giảm";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            // 
            // ThoiGianBatDauColumn
            // 
            this.ThoiGianBatDauColumn.HeaderText = "Thời gian bắt đầu";
            this.ThoiGianBatDauColumn.MinimumWidth = 6;
            this.ThoiGianBatDauColumn.Name = "ThoiGianBatDauColumn";
            this.ThoiGianBatDauColumn.Width = 125;
            // 
            // ThoiGianKetThucColumn
            // 
            this.ThoiGianKetThucColumn.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKetThucColumn.MinimumWidth = 6;
            this.ThoiGianKetThucColumn.Name = "ThoiGianKetThucColumn";
            this.ThoiGianKetThucColumn.Width = 125;
            // 
            // lb_CouponCode
            // 
            this.lb_CouponCode.AutoSize = true;
            this.lb_CouponCode.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CouponCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_CouponCode.Location = new System.Drawing.Point(44, 367);
            this.lb_CouponCode.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_CouponCode.Name = "lb_CouponCode";
            this.lb_CouponCode.Size = new System.Drawing.Size(131, 20);
            this.lb_CouponCode.TabIndex = 4;
            this.lb_CouponCode.Text = "Mã giảm giá:";
            // 
            // lb_Type
            // 
            this.lb_Type.AutoSize = true;
            this.lb_Type.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Type.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Type.Location = new System.Drawing.Point(433, 370);
            this.lb_Type.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(56, 20);
            this.lb_Type.TabIndex = 5;
            this.lb_Type.Text = "Loại:";
            // 
            // tb_CouponCode
            // 
            this.tb_CouponCode.Location = new System.Drawing.Point(197, 368);
            this.tb_CouponCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CouponCode.Name = "tb_CouponCode";
            this.tb_CouponCode.Size = new System.Drawing.Size(151, 22);
            this.tb_CouponCode.TabIndex = 6;
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "Vĩnh viễn",
            "Quà tặng"});
            this.cb_Type.Location = new System.Drawing.Point(531, 370);
            this.cb_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(151, 24);
            this.cb_Type.TabIndex = 7;
            // 
            // lb_Value
            // 
            this.lb_Value.AutoSize = true;
            this.lb_Value.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Value.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Value.Location = new System.Drawing.Point(44, 417);
            this.lb_Value.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Value.Name = "lb_Value";
            this.lb_Value.Size = new System.Drawing.Size(75, 20);
            this.lb_Value.TabIndex = 8;
            this.lb_Value.Text = "Giá trị:";
            // 
            // tb_Value
            // 
            this.tb_Value.Location = new System.Drawing.Point(197, 418);
            this.tb_Value.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Value.Name = "tb_Value";
            this.tb_Value.Size = new System.Drawing.Size(151, 22);
            this.tb_Value.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(609, 481);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 41);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(473, 481);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(121, 41);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // lb_Publish
            // 
            this.lb_Publish.AutoSize = true;
            this.lb_Publish.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Publish.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Publish.Location = new System.Drawing.Point(433, 417);
            this.lb_Publish.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Publish.Name = "lb_Publish";
            this.lb_Publish.Size = new System.Drawing.Size(94, 20);
            this.lb_Publish.TabIndex = 12;
            this.lb_Publish.Text = "Công bố:";
            // 
            // ckb_Publish
            // 
            this.ckb_Publish.AutoSize = true;
            this.ckb_Publish.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Publish.Location = new System.Drawing.Point(545, 421);
            this.ckb_Publish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_Publish.Name = "ckb_Publish";
            this.ckb_Publish.Size = new System.Drawing.Size(18, 17);
            this.ckb_Publish.TabIndex = 13;
            this.ckb_Publish.UseVisualStyleBackColor = true;
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Export.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Export.Location = new System.Drawing.Point(239, 480);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(207, 41);
            this.btn_Export.TabIndex = 11;
            this.btn_Export.Text = "Xuất báo cáo";
            this.btn_Export.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(48, 480);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 41);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 535);
            this.Controls.Add(this.ckb_Publish);
            this.Controls.Add(this.lb_Publish);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_Value);
            this.Controls.Add(this.lb_Value);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.tb_CouponCode);
            this.Controls.Add(this.lb_Type);
            this.Controls.Add(this.lb_CouponCode);
            this.Controls.Add(this.dgv_Coupon);
            this.Controls.Add(this.btn_Return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Coupon";
            this.Text = "Coupon";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Coupon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.DataGridView dgv_Coupon;
        private System.Windows.Forms.Label lb_CouponCode;
        private System.Windows.Forms.Label lb_Type;
        private System.Windows.Forms.TextBox tb_CouponCode;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.Label lb_Value;
        private System.Windows.Forms.TextBox tb_Value;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lb_Publish;
        private System.Windows.Forms.CheckBox ckb_Publish;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouponCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDauColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThucColumn;
    }
}