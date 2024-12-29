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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.CouponCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btn_Return.TabIndex = 2;
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CouponCode,
            this.Type,
            this.Value,
            this.Publish});
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 301);
            this.dataGridView1.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vĩnh viễn",
            "Quà tặng"});
            this.comboBox1.Location = new System.Drawing.Point(530, 370);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 7;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 418);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Add.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(667, 482);
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
            this.btn_Delete.Location = new System.Drawing.Point(530, 482);
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
            this.ckb_Publish.Location = new System.Drawing.Point(533, 418);
            this.ckb_Publish.Name = "ckb_Publish";
            this.ckb_Publish.Size = new System.Drawing.Size(18, 17);
            this.ckb_Publish.TabIndex = 13;
            this.ckb_Publish.UseVisualStyleBackColor = true;
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
            this.Type.HeaderText = "Loại";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Giá trị";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            // 
            // Publish
            // 
            this.Publish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Publish.HeaderText = "Công bố";
            this.Publish.MinimumWidth = 6;
            this.Publish.Name = "Publish";
            // 
            // Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.ckb_Publish);
            this.Controls.Add(this.lb_Publish);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lb_Value);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Type);
            this.Controls.Add(this.lb_CouponCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Coupon";
            this.Text = "Coupon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_CouponCode;
        private System.Windows.Forms.Label lb_Type;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_Value;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lb_Publish;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouponCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publish;
        private System.Windows.Forms.CheckBox ckb_Publish;
    }
}