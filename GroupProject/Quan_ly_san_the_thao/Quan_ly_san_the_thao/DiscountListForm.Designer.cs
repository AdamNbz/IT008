namespace Quan_ly_san_the_thao
{
    partial class DiscountListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DanhSachMaGiamGia_dgv = new System.Windows.Forms.DataGridView();
            this.DinhDanhMGG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonApDungColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDauColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThucColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSuDungColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMaGiamGia_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachMaGiamGia_dgv
            // 
            this.DanhSachMaGiamGia_dgv.AllowUserToAddRows = false;
            this.DanhSachMaGiamGia_dgv.AllowUserToDeleteRows = false;
            this.DanhSachMaGiamGia_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DanhSachMaGiamGia_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DanhSachMaGiamGia_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachMaGiamGia_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DinhDanhMGG,
            this.MonApDungColumn,
            this.ThoiGianBatDauColumn,
            this.ThoiGianKetThucColumn,
            this.SoLuongSuDungColumn});
            this.DanhSachMaGiamGia_dgv.Location = new System.Drawing.Point(12, 12);
            this.DanhSachMaGiamGia_dgv.Name = "DanhSachMaGiamGia_dgv";
            this.DanhSachMaGiamGia_dgv.ReadOnly = true;
            this.DanhSachMaGiamGia_dgv.Size = new System.Drawing.Size(586, 426);
            this.DanhSachMaGiamGia_dgv.TabIndex = 0;
            // 
            // DinhDanhMGG
            // 
            this.DinhDanhMGG.HeaderText = "Định danh mã giảm giá";
            this.DinhDanhMGG.Name = "DinhDanhMGG";
            this.DinhDanhMGG.ReadOnly = true;
            // 
            // MonApDungColumn
            // 
            this.MonApDungColumn.HeaderText = "Môn áp dụng";
            this.MonApDungColumn.Name = "MonApDungColumn";
            this.MonApDungColumn.ReadOnly = true;
            // 
            // ThoiGianBatDauColumn
            // 
            this.ThoiGianBatDauColumn.HeaderText = "Thời gian bắt đầu";
            this.ThoiGianBatDauColumn.Name = "ThoiGianBatDauColumn";
            this.ThoiGianBatDauColumn.ReadOnly = true;
            // 
            // ThoiGianKetThucColumn
            // 
            this.ThoiGianKetThucColumn.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKetThucColumn.Name = "ThoiGianKetThucColumn";
            this.ThoiGianKetThucColumn.ReadOnly = true;
            // 
            // SoLuongSuDungColumn
            // 
            this.SoLuongSuDungColumn.HeaderText = "Số lượng sử dụng";
            this.SoLuongSuDungColumn.Name = "SoLuongSuDungColumn";
            this.SoLuongSuDungColumn.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(617, 168);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 51);
            this.button3.TabIndex = 9;
            this.button3.Text = "Tìm kiếm mã giảm giá";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(617, 86);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xếp mã giảm giá";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(617, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm mã giảm giá";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DiscountListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DanhSachMaGiamGia_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscountListForm";
            this.Text = "DiscountListForm";
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMaGiamGia_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DanhSachMaGiamGia_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DinhDanhMGG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonApDungColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDauColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThucColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSuDungColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}