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
            this.lb_CouponCode = new System.Windows.Forms.Label();
            this.lb_Type = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_Value = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lb_Publish = new System.Windows.Forms.Label();
            this.ckb_Publish = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CouponCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDauColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThucColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_Return.Location = new System.Drawing.Point(9, 11);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(21, 23);
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
            this.dgv_Coupon.Location = new System.Drawing.Point(9, 39);
            this.dgv_Coupon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Coupon.Name = "dgv_Coupon";
            this.dgv_Coupon.RowHeadersWidth = 51;
            this.dgv_Coupon.RowTemplate.Height = 24;
            this.dgv_Coupon.Size = new System.Drawing.Size(539, 245);
            this.dgv_Coupon.TabIndex = 3;
            // 
            // lb_CouponCode
            // 
            this.lb_CouponCode.AutoSize = true;
            this.lb_CouponCode.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CouponCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_CouponCode.Location = new System.Drawing.Point(33, 298);
            this.lb_CouponCode.Margin = new System.Windows.Forms.Padding(2, 12, 2, 12);
            this.lb_CouponCode.Name = "lb_CouponCode";
            this.lb_CouponCode.Size = new System.Drawing.Size(106, 17);
            this.lb_CouponCode.TabIndex = 4;
            this.lb_CouponCode.Text = "Mã giảm giá:";
            // 
            // lb_Type
            // 
            this.lb_Type.AutoSize = true;
            this.lb_Type.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Type.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Type.Location = new System.Drawing.Point(325, 301);
            this.lb_Type.Margin = new System.Windows.Forms.Padding(2, 12, 2, 12);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(46, 17);
            this.lb_Type.TabIndex = 5;
            this.lb_Type.Text = "Loại:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 299);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vĩnh viễn",
            "Quà tặng"});
            this.comboBox1.Location = new System.Drawing.Point(398, 301);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lb_Value
            // 
            this.lb_Value.AutoSize = true;
            this.lb_Value.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Value.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Value.Location = new System.Drawing.Point(33, 339);
            this.lb_Value.Margin = new System.Windows.Forms.Padding(2, 12, 2, 12);
            this.lb_Value.Name = "lb_Value";
            this.lb_Value.Size = new System.Drawing.Size(60, 17);
            this.lb_Value.TabIndex = 8;
            this.lb_Value.Text = "Giá trị:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 340);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(457, 391);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(91, 33);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(355, 391);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // lb_Publish
            // 
            this.lb_Publish.AutoSize = true;
            this.lb_Publish.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Publish.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Publish.Location = new System.Drawing.Point(325, 339);
            this.lb_Publish.Margin = new System.Windows.Forms.Padding(2, 12, 2, 12);
            this.lb_Publish.Name = "lb_Publish";
            this.lb_Publish.Size = new System.Drawing.Size(80, 17);
            this.lb_Publish.TabIndex = 12;
            this.lb_Publish.Text = "Công bố:";
            // 
            // ckb_Publish
            // 
            this.ckb_Publish.AutoSize = true;
            this.ckb_Publish.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Publish.Location = new System.Drawing.Point(409, 342);
            this.ckb_Publish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckb_Publish.Name = "ckb_Publish";
            this.ckb_Publish.Size = new System.Drawing.Size(15, 14);
            this.ckb_Publish.TabIndex = 13;
            this.ckb_Publish.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(179, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Xuất báo cáo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(36, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = false;
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
            this.ThoiGianBatDauColumn.Name = "ThoiGianBatDauColumn";
            // 
            // ThoiGianKetThucColumn
            // 
            this.ThoiGianKetThucColumn.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKetThucColumn.Name = "ThoiGianKetThucColumn";
            // 
            // Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 435);
            this.Controls.Add(this.ckb_Publish);
            this.Controls.Add(this.lb_Publish);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lb_Value);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Type);
            this.Controls.Add(this.lb_CouponCode);
            this.Controls.Add(this.dgv_Coupon);
            this.Controls.Add(this.btn_Return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_Value;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lb_Publish;
        private System.Windows.Forms.CheckBox ckb_Publish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouponCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDauColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThucColumn;
    }
}