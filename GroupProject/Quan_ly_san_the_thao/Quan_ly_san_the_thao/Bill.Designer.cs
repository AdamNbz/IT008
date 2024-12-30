namespace Quan_ly_san_the_thao
{
    partial class Bill
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
            this.dgv_Bill = new System.Windows.Forms.DataGridView();
            this.lb_Bill = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lb_BillCode = new System.Windows.Forms.Label();
            this.lb_Fullname = new System.Windows.Forms.Label();
            this.tb_Fullname = new System.Windows.Forms.TextBox();
            this.lb_Date = new System.Windows.Forms.Label();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.lb_Value = new System.Windows.Forms.Label();
            this.tb_Value = new System.Windows.Forms.TextBox();
            this.lb_Discount = new System.Windows.Forms.Label();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.lb_Payment = new System.Windows.Forms.Label();
            this.tb_Payment = new System.Windows.Forms.TextBox();
            this.lb_Status = new System.Windows.Forms.Label();
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.lb_Field = new System.Windows.Forms.Label();
            this.tb_Field = new System.Windows.Forms.TextBox();
            this.lb_FieldNum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).BeginInit();
            this.SuspendLayout();
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
            this.btn_Return.TabIndex = 4;
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // dgv_Bill
            // 
            this.dgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillCode,
            this.Fullname,
            this.Date,
            this.Value,
            this.Discount,
            this.Payment,
            this.Field,
            this.FieldNum,
            this.Status});
            this.dgv_Bill.Location = new System.Drawing.Point(12, 48);
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.RowHeadersWidth = 51;
            this.dgv_Bill.RowTemplate.Height = 24;
            this.dgv_Bill.Size = new System.Drawing.Size(1047, 301);
            this.dgv_Bill.TabIndex = 5;
            // 
            // lb_Bill
            // 
            this.lb_Bill.AutoSize = true;
            this.lb_Bill.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Bill.Location = new System.Drawing.Point(404, 9);
            this.lb_Bill.Name = "lb_Bill";
            this.lb_Bill.Size = new System.Drawing.Size(316, 34);
            this.lb_Bill.TabIndex = 22;
            this.lb_Bill.Text = "Danh sách hóa đơn";
            // 
            // tb_Username
            // 
            this.tb_Username.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Username.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(212, 362);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.ReadOnly = true;
            this.tb_Username.Size = new System.Drawing.Size(150, 28);
            this.tb_Username.TabIndex = 24;
            // 
            // lb_BillCode
            // 
            this.lb_BillCode.AutoSize = true;
            this.lb_BillCode.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BillCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_BillCode.Location = new System.Drawing.Point(80, 365);
            this.lb_BillCode.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_BillCode.Name = "lb_BillCode";
            this.lb_BillCode.Size = new System.Drawing.Size(126, 20);
            this.lb_BillCode.TabIndex = 23;
            this.lb_BillCode.Text = "Mã hóa đơn:";
            // 
            // lb_Fullname
            // 
            this.lb_Fullname.AutoSize = true;
            this.lb_Fullname.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fullname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Fullname.Location = new System.Drawing.Point(96, 415);
            this.lb_Fullname.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Fullname.Name = "lb_Fullname";
            this.lb_Fullname.Size = new System.Drawing.Size(110, 20);
            this.lb_Fullname.TabIndex = 25;
            this.lb_Fullname.Text = "Người đặt:";
            // 
            // tb_Fullname
            // 
            this.tb_Fullname.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Fullname.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fullname.Location = new System.Drawing.Point(212, 412);
            this.tb_Fullname.Name = "tb_Fullname";
            this.tb_Fullname.ReadOnly = true;
            this.tb_Fullname.Size = new System.Drawing.Size(289, 28);
            this.tb_Fullname.TabIndex = 26;
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Date.Location = new System.Drawing.Point(683, 365);
            this.lb_Date.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(101, 20);
            this.lb_Date.TabIndex = 27;
            this.lb_Date.Text = "Ngày đặt:";
            // 
            // tb_Date
            // 
            this.tb_Date.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Date.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Date.Location = new System.Drawing.Point(790, 362);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.ReadOnly = true;
            this.tb_Date.Size = new System.Drawing.Size(175, 28);
            this.tb_Date.TabIndex = 28;
            // 
            // lb_Value
            // 
            this.lb_Value.AutoSize = true;
            this.lb_Value.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Value.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Value.Location = new System.Drawing.Point(705, 415);
            this.lb_Value.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Value.Name = "lb_Value";
            this.lb_Value.Size = new System.Drawing.Size(77, 20);
            this.lb_Value.TabIndex = 29;
            this.lb_Value.Text = "Trị giá:";
            // 
            // tb_Value
            // 
            this.tb_Value.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Value.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Value.Location = new System.Drawing.Point(788, 412);
            this.tb_Value.Name = "tb_Value";
            this.tb_Value.ReadOnly = true;
            this.tb_Value.Size = new System.Drawing.Size(175, 28);
            this.tb_Value.TabIndex = 30;
            // 
            // lb_Discount
            // 
            this.lb_Discount.AutoSize = true;
            this.lb_Discount.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Discount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Discount.Location = new System.Drawing.Point(106, 465);
            this.lb_Discount.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Discount.Name = "lb_Discount";
            this.lb_Discount.Size = new System.Drawing.Size(100, 20);
            this.lb_Discount.TabIndex = 31;
            this.lb_Discount.Text = "Giảm giá:";
            // 
            // tb_Discount
            // 
            this.tb_Discount.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Discount.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(212, 462);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.ReadOnly = true;
            this.tb_Discount.Size = new System.Drawing.Size(150, 28);
            this.tb_Discount.TabIndex = 32;
            // 
            // lb_Payment
            // 
            this.lb_Payment.AutoSize = true;
            this.lb_Payment.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Payment.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Payment.Location = new System.Drawing.Point(536, 465);
            this.lb_Payment.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Payment.Name = "lb_Payment";
            this.lb_Payment.Size = new System.Drawing.Size(248, 20);
            this.lb_Payment.TabIndex = 33;
            this.lb_Payment.Text = "Phương thức thanh toán:";
            // 
            // tb_Payment
            // 
            this.tb_Payment.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Payment.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Payment.Location = new System.Drawing.Point(788, 462);
            this.tb_Payment.Name = "tb_Payment";
            this.tb_Payment.ReadOnly = true;
            this.tb_Payment.Size = new System.Drawing.Size(175, 28);
            this.tb_Payment.TabIndex = 34;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Status.Location = new System.Drawing.Point(669, 515);
            this.lb_Status.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(115, 20);
            this.lb_Status.TabIndex = 35;
            this.lb_Status.Text = "Tình trạng:";
            // 
            // tb_Status
            // 
            this.tb_Status.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Status.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Status.Location = new System.Drawing.Point(790, 512);
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.ReadOnly = true;
            this.tb_Status.Size = new System.Drawing.Size(175, 28);
            this.tb_Status.TabIndex = 36;
            // 
            // lb_Field
            // 
            this.lb_Field.AutoSize = true;
            this.lb_Field.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Field.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Field.Location = new System.Drawing.Point(111, 515);
            this.lb_Field.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_Field.Name = "lb_Field";
            this.lb_Field.Size = new System.Drawing.Size(95, 20);
            this.lb_Field.TabIndex = 37;
            this.lb_Field.Text = "Loại sân:";
            // 
            // tb_Field
            // 
            this.tb_Field.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Field.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Field.Location = new System.Drawing.Point(210, 512);
            this.tb_Field.Name = "tb_Field";
            this.tb_Field.ReadOnly = true;
            this.tb_Field.Size = new System.Drawing.Size(152, 28);
            this.tb_Field.TabIndex = 38;
            // 
            // lb_FieldNum
            // 
            this.lb_FieldNum.AutoSize = true;
            this.lb_FieldNum.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FieldNum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_FieldNum.Location = new System.Drawing.Point(397, 515);
            this.lb_FieldNum.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_FieldNum.Name = "lb_FieldNum";
            this.lb_FieldNum.Size = new System.Drawing.Size(79, 20);
            this.lb_FieldNum.TabIndex = 39;
            this.lb_FieldNum.Text = "Số sân:";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(482, 512);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(152, 28);
            this.textBox1.TabIndex = 40;
            // 
            // BillCode
            // 
            this.BillCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillCode.HeaderText = "Mã hóa đơn";
            this.BillCode.MinimumWidth = 6;
            this.BillCode.Name = "BillCode";
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fullname.FillWeight = 200F;
            this.Fullname.HeaderText = "Người đặt";
            this.Fullname.MinimumWidth = 6;
            this.Fullname.Name = "Fullname";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Ngày đặt";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Trị giá";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.HeaderText = "Giảm giá";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            // 
            // Payment
            // 
            this.Payment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Payment.HeaderText = "Phương thức thanh toán";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            // 
            // Field
            // 
            this.Field.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Field.HeaderText = "Loại sân";
            this.Field.MinimumWidth = 6;
            this.Field.Name = "Field";
            // 
            // FieldNum
            // 
            this.FieldNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldNum.FillWeight = 50F;
            this.FieldNum.HeaderText = "Số sân";
            this.FieldNum.MinimumWidth = 6;
            this.FieldNum.Name = "FieldNum";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.FillWeight = 125F;
            this.Status.HeaderText = "Tình trạng";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 563);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_FieldNum);
            this.Controls.Add(this.tb_Field);
            this.Controls.Add(this.lb_Field);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.tb_Payment);
            this.Controls.Add(this.lb_Payment);
            this.Controls.Add(this.tb_Discount);
            this.Controls.Add(this.lb_Discount);
            this.Controls.Add(this.tb_Value);
            this.Controls.Add(this.lb_Value);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.tb_Fullname);
            this.Controls.Add(this.lb_Fullname);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lb_BillCode);
            this.Controls.Add(this.lb_Bill);
            this.Controls.Add(this.dgv_Bill);
            this.Controls.Add(this.btn_Return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.DataGridView dgv_Bill;
        private System.Windows.Forms.Label lb_Bill;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lb_BillCode;
        private System.Windows.Forms.Label lb_Fullname;
        private System.Windows.Forms.TextBox tb_Fullname;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.Label lb_Value;
        private System.Windows.Forms.TextBox tb_Value;
        private System.Windows.Forms.Label lb_Discount;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label lb_Payment;
        private System.Windows.Forms.TextBox tb_Payment;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.Label lb_Field;
        private System.Windows.Forms.TextBox tb_Field;
        private System.Windows.Forms.Label lb_FieldNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox textBox1;
    }
}