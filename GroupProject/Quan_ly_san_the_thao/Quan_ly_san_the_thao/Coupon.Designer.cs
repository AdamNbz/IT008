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
            this.dgv_CouponList = new System.Windows.Forms.DataGridView();
            this.lb_CouponCode = new System.Windows.Forms.Label();
            this.tb_CouponCode = new System.Windows.Forms.TextBox();
            this.lb_Value = new System.Windows.Forms.Label();
            this.tb_Value = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_EndTime = new System.Windows.Forms.Label();
            this.tb_Time = new System.Windows.Forms.TextBox();
            this.tb_SearchCoupon = new System.Windows.Forms.TextBox();
            this.CouponCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CouponList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CouponList
            // 
            this.dgv_CouponList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CouponList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CouponCode,
            this.Value,
            this.AvailableTime});
            this.dgv_CouponList.Location = new System.Drawing.Point(9, 39);
            this.dgv_CouponList.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_CouponList.Name = "dgv_CouponList";
            this.dgv_CouponList.RowHeadersWidth = 51;
            this.dgv_CouponList.RowTemplate.Height = 24;
            this.dgv_CouponList.Size = new System.Drawing.Size(750, 406);
            this.dgv_CouponList.TabIndex = 3;
            // 
            // lb_CouponCode
            // 
            this.lb_CouponCode.AutoSize = true;
            this.lb_CouponCode.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CouponCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_CouponCode.Location = new System.Drawing.Point(11, 463);
            this.lb_CouponCode.Margin = new System.Windows.Forms.Padding(2, 12, 2, 12);
            this.lb_CouponCode.Name = "lb_CouponCode";
            this.lb_CouponCode.Size = new System.Drawing.Size(106, 17);
            this.lb_CouponCode.TabIndex = 4;
            this.lb_CouponCode.Text = "Mã giảm giá:";
            // 
            // tb_CouponCode
            // 
            this.tb_CouponCode.Location = new System.Drawing.Point(126, 463);
            this.tb_CouponCode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_CouponCode.Name = "tb_CouponCode";
            this.tb_CouponCode.Size = new System.Drawing.Size(114, 20);
            this.tb_CouponCode.TabIndex = 6;
            // 
            // lb_Value
            // 
            this.lb_Value.AutoSize = true;
            this.lb_Value.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Value.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Value.Location = new System.Drawing.Point(57, 504);
            this.lb_Value.Margin = new System.Windows.Forms.Padding(2, 12, 2, 12);
            this.lb_Value.Name = "lb_Value";
            this.lb_Value.Size = new System.Drawing.Size(60, 17);
            this.lb_Value.TabIndex = 8;
            this.lb_Value.Text = "Giá trị:";
            // 
            // tb_Value
            // 
            this.tb_Value.Location = new System.Drawing.Point(126, 504);
            this.tb_Value.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Value.Name = "tb_Value";
            this.tb_Value.Size = new System.Drawing.Size(114, 20);
            this.tb_Value.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(668, 554);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(91, 33);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(573, 554);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 33);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(9, 554);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 33);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.btn_Close.TabIndex = 22;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_EndTime
            // 
            this.lb_EndTime.AutoSize = true;
            this.lb_EndTime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EndTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_EndTime.Location = new System.Drawing.Point(422, 463);
            this.lb_EndTime.Margin = new System.Windows.Forms.Padding(2, 12, 2, 12);
            this.lb_EndTime.Name = "lb_EndTime";
            this.lb_EndTime.Size = new System.Drawing.Size(152, 17);
            this.lb_EndTime.TabIndex = 24;
            this.lb_EndTime.Text = "Thời gian hiệu lực:";
            // 
            // tb_Time
            // 
            this.tb_Time.Location = new System.Drawing.Point(578, 463);
            this.tb_Time.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Time.Name = "tb_Time";
            this.tb_Time.Size = new System.Drawing.Size(180, 20);
            this.tb_Time.TabIndex = 26;
            // 
            // tb_SearchCoupon
            // 
            this.tb_SearchCoupon.Location = new System.Drawing.Point(147, 562);
            this.tb_SearchCoupon.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SearchCoupon.Name = "tb_SearchCoupon";
            this.tb_SearchCoupon.Size = new System.Drawing.Size(258, 20);
            this.tb_SearchCoupon.TabIndex = 27;
            // 
            // CouponCode
            // 
            this.CouponCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CouponCode.DataPropertyName = "MAGIAMGIA";
            this.CouponCode.HeaderText = "Mã giảm giá";
            this.CouponCode.MinimumWidth = 6;
            this.CouponCode.Name = "CouponCode";
            this.CouponCode.ReadOnly = true;
            this.CouponCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.DataPropertyName = "HESO";
            this.Value.HeaderText = "Giá trị giảm";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AvailableTime
            // 
            this.AvailableTime.DataPropertyName = "TGHIEULUC";
            this.AvailableTime.HeaderText = "Thời gian hiệu lực";
            this.AvailableTime.MinimumWidth = 6;
            this.AvailableTime.Name = "AvailableTime";
            this.AvailableTime.ReadOnly = true;
            this.AvailableTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AvailableTime.Width = 125;
            // 
            // Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 611);
            this.Controls.Add(this.tb_SearchCoupon);
            this.Controls.Add(this.tb_Time);
            this.Controls.Add(this.lb_EndTime);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_Value);
            this.Controls.Add(this.lb_Value);
            this.Controls.Add(this.tb_CouponCode);
            this.Controls.Add(this.lb_CouponCode);
            this.Controls.Add(this.dgv_CouponList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Coupon";
            this.Text = "Coupon";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CouponList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_CouponList;
        private System.Windows.Forms.Label lb_CouponCode;
        private System.Windows.Forms.TextBox tb_CouponCode;
        private System.Windows.Forms.Label lb_Value;
        private System.Windows.Forms.TextBox tb_Value;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lb_EndTime;
        private System.Windows.Forms.TextBox tb_Time;
        private System.Windows.Forms.TextBox tb_SearchCoupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouponCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableTime;
    }
}