namespace Quan_ly_san_the_thao
{
    partial class BillList
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
            this.btn_PrintBill = new System.Windows.Forms.Button();
            this.dgv_BillList = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGHDHLUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHUNGGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SANDAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRIGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANGHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_UpdateStats = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillList)).BeginInit();
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
            // btn_PrintBill
            // 
            this.btn_PrintBill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_PrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintBill.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_PrintBill.Location = new System.Drawing.Point(445, 567);
            this.btn_PrintBill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PrintBill.Name = "btn_PrintBill";
            this.btn_PrintBill.Size = new System.Drawing.Size(155, 33);
            this.btn_PrintBill.TabIndex = 25;
            this.btn_PrintBill.Text = "In Bill";
            this.btn_PrintBill.UseVisualStyleBackColor = false;
            this.btn_PrintBill.Click += new System.EventHandler(this.btn_PrintBill_Click);
            // 
            // dgv_BillList
            // 
            this.dgv_BillList.AllowUserToAddRows = false;
            this.dgv_BillList.AllowUserToDeleteRows = false;
            this.dgv_BillList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BillList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_BillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BillList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.Username,
            this.NGHDHLUC,
            this.KHUNGGIO,
            this.SANDAT,
            this.TRIGIA,
            this.TINHTRANGHD});
            this.dgv_BillList.Location = new System.Drawing.Point(11, 36);
            this.dgv_BillList.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_BillList.Name = "dgv_BillList";
            this.dgv_BillList.ReadOnly = true;
            this.dgv_BillList.RowHeadersWidth = 51;
            this.dgv_BillList.RowTemplate.Height = 24;
            this.dgv_BillList.Size = new System.Drawing.Size(750, 505);
            this.dgv_BillList.TabIndex = 15;
            this.dgv_BillList.SelectionChanged += new System.EventHandler(this.dgv_BillList_SelectionChanged);
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã Hóa đơn";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            this.MAHD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "USERNAME";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NGHDHLUC
            // 
            this.NGHDHLUC.DataPropertyName = "NGHDHLUC";
            this.NGHDHLUC.HeaderText = "Ngày hiệu lực";
            this.NGHDHLUC.Name = "NGHDHLUC";
            this.NGHDHLUC.ReadOnly = true;
            this.NGHDHLUC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KHUNGGIO
            // 
            this.KHUNGGIO.DataPropertyName = "KHUNGGIO";
            this.KHUNGGIO.HeaderText = "Khung giờ dùng sân";
            this.KHUNGGIO.Name = "KHUNGGIO";
            this.KHUNGGIO.ReadOnly = true;
            this.KHUNGGIO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SANDAT
            // 
            this.SANDAT.DataPropertyName = "SANDAT";
            this.SANDAT.HeaderText = "Sân đã đặt";
            this.SANDAT.Name = "SANDAT";
            this.SANDAT.ReadOnly = true;
            this.SANDAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TRIGIA
            // 
            this.TRIGIA.DataPropertyName = "TRIGIA";
            this.TRIGIA.HeaderText = "Giá bill sau khi giảm (nếu có)";
            this.TRIGIA.Name = "TRIGIA";
            this.TRIGIA.ReadOnly = true;
            this.TRIGIA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TINHTRANGHD
            // 
            this.TINHTRANGHD.DataPropertyName = "TINHTRANGHD";
            this.TINHTRANGHD.HeaderText = "Trạng thái đơn";
            this.TINHTRANGHD.Name = "TINHTRANGHD";
            this.TINHTRANGHD.ReadOnly = true;
            this.TINHTRANGHD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_UpdateStats
            // 
            this.btn_UpdateStats.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_UpdateStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateStats.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateStats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_UpdateStats.Location = new System.Drawing.Point(604, 567);
            this.btn_UpdateStats.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UpdateStats.Name = "btn_UpdateStats";
            this.btn_UpdateStats.Size = new System.Drawing.Size(155, 33);
            this.btn_UpdateStats.TabIndex = 25;
            this.btn_UpdateStats.Text = "Cập nhật trạng thái";
            this.btn_UpdateStats.UseVisualStyleBackColor = false;
            this.btn_UpdateStats.Click += new System.EventHandler(this.btn_UpdateStats_Click);
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
            // BillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 611);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_UpdateStats);
            this.Controls.Add(this.btn_PrintBill);
            this.Controls.Add(this.dgv_BillList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillList";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_PrintBill;
        private System.Windows.Forms.DataGridView dgv_BillList;
        private System.Windows.Forms.Button btn_UpdateStats;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGHDHLUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHUNGGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SANDAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRIGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANGHD;
    }
}