namespace Quan_ly_san_the_thao
{
    partial class PriceAdjustment
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
            this.lb_PriceAdjustment = new System.Windows.Forms.Label();
            this.tb_Evening = new System.Windows.Forms.TextBox();
            this.lb_Evening = new System.Windows.Forms.Label();
            this.tb_Afternoon = new System.Windows.Forms.TextBox();
            this.tb_Morning = new System.Windows.Forms.TextBox();
            this.lb_Afternoon = new System.Windows.Forms.Label();
            this.lb_Morning = new System.Windows.Forms.Label();
            this.btn_SaveChange = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_FieldType = new System.Windows.Forms.Label();
            this.cb_FieldType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_PriceAdjustment
            // 
            this.lb_PriceAdjustment.AutoSize = true;
            this.lb_PriceAdjustment.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PriceAdjustment.Location = new System.Drawing.Point(269, 137);
            this.lb_PriceAdjustment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PriceAdjustment.Name = "lb_PriceAdjustment";
            this.lb_PriceAdjustment.Size = new System.Drawing.Size(228, 32);
            this.lb_PriceAdjustment.TabIndex = 17;
            this.lb_PriceAdjustment.Text = "Điều chỉnh giá";
            this.lb_PriceAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Evening
            // 
            this.tb_Evening.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Evening.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Evening.Location = new System.Drawing.Point(310, 358);
            this.tb_Evening.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Evening.Name = "tb_Evening";
            this.tb_Evening.Size = new System.Drawing.Size(225, 24);
            this.tb_Evening.TabIndex = 32;
            this.tb_Evening.Text = "0";
            this.tb_Evening.Enter += new System.EventHandler(this.Price_Enter);
            this.tb_Evening.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // lb_Evening
            // 
            this.lb_Evening.AutoSize = true;
            this.lb_Evening.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Evening.Location = new System.Drawing.Point(242, 360);
            this.lb_Evening.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_Evening.Name = "lb_Evening";
            this.lb_Evening.Size = new System.Drawing.Size(35, 17);
            this.lb_Evening.TabIndex = 31;
            this.lb_Evening.Text = "Tối:";
            // 
            // tb_Afternoon
            // 
            this.tb_Afternoon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Afternoon.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Afternoon.Location = new System.Drawing.Point(310, 317);
            this.tb_Afternoon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Afternoon.Name = "tb_Afternoon";
            this.tb_Afternoon.Size = new System.Drawing.Size(225, 24);
            this.tb_Afternoon.TabIndex = 30;
            this.tb_Afternoon.Text = "0";
            this.tb_Afternoon.Enter += new System.EventHandler(this.Price_Enter);
            this.tb_Afternoon.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // tb_Morning
            // 
            this.tb_Morning.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Morning.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Morning.Location = new System.Drawing.Point(310, 277);
            this.tb_Morning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Morning.Name = "tb_Morning";
            this.tb_Morning.Size = new System.Drawing.Size(225, 24);
            this.tb_Morning.TabIndex = 29;
            this.tb_Morning.Text = "0";
            this.tb_Morning.Enter += new System.EventHandler(this.Price_Enter);
            this.tb_Morning.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // lb_Afternoon
            // 
            this.lb_Afternoon.AutoSize = true;
            this.lb_Afternoon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Afternoon.Location = new System.Drawing.Point(224, 320);
            this.lb_Afternoon.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_Afternoon.Name = "lb_Afternoon";
            this.lb_Afternoon.Size = new System.Drawing.Size(53, 17);
            this.lb_Afternoon.TabIndex = 28;
            this.lb_Afternoon.Text = "Chiều:";
            // 
            // lb_Morning
            // 
            this.lb_Morning.AutoSize = true;
            this.lb_Morning.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Morning.Location = new System.Drawing.Point(227, 279);
            this.lb_Morning.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_Morning.Name = "lb_Morning";
            this.lb_Morning.Size = new System.Drawing.Size(50, 17);
            this.lb_Morning.TabIndex = 27;
            this.lb_Morning.Text = "Sáng:";
            // 
            // btn_SaveChange
            // 
            this.btn_SaveChange.BackColor = System.Drawing.Color.Lime;
            this.btn_SaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveChange.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChange.Location = new System.Drawing.Point(259, 463);
            this.btn_SaveChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SaveChange.Name = "btn_SaveChange";
            this.btn_SaveChange.Size = new System.Drawing.Size(243, 40);
            this.btn_SaveChange.TabIndex = 33;
            this.btn_SaveChange.Text = "Lưu thay đổi";
            this.btn_SaveChange.UseVisualStyleBackColor = false;
            this.btn_SaveChange.Click += new System.EventHandler(this.btn_SaveChange_Click);
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
            this.btn_Close.TabIndex = 35;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_FieldType
            // 
            this.lb_FieldType.AutoSize = true;
            this.lb_FieldType.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FieldType.Location = new System.Drawing.Point(205, 238);
            this.lb_FieldType.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_FieldType.Name = "lb_FieldType";
            this.lb_FieldType.Size = new System.Drawing.Size(72, 17);
            this.lb_FieldType.TabIndex = 36;
            this.lb_FieldType.Text = "Loại sân:";
            // 
            // cb_FieldType
            // 
            this.cb_FieldType.FormattingEnabled = true;
            this.cb_FieldType.Items.AddRange(new object[] {
            "Sân 1",
            "Sân 2",
            "Sân 3"});
            this.cb_FieldType.Location = new System.Drawing.Point(310, 238);
            this.cb_FieldType.Name = "cb_FieldType";
            this.cb_FieldType.Size = new System.Drawing.Size(225, 21);
            this.cb_FieldType.TabIndex = 37;
            this.cb_FieldType.SelectedIndexChanged += new System.EventHandler(this.cb_FieldType_SelectedIndexChanged);
            // 
            // PriceAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 611);
            this.Controls.Add(this.cb_FieldType);
            this.Controls.Add(this.lb_FieldType);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_SaveChange);
            this.Controls.Add(this.tb_Evening);
            this.Controls.Add(this.lb_Evening);
            this.Controls.Add(this.tb_Afternoon);
            this.Controls.Add(this.tb_Morning);
            this.Controls.Add(this.lb_Afternoon);
            this.Controls.Add(this.lb_Morning);
            this.Controls.Add(this.lb_PriceAdjustment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PriceAdjustment";
            this.Text = "PriceAdjustment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PriceAdjustment;
        private System.Windows.Forms.TextBox tb_Evening;
        private System.Windows.Forms.Label lb_Evening;
        private System.Windows.Forms.TextBox tb_Afternoon;
        private System.Windows.Forms.TextBox tb_Morning;
        private System.Windows.Forms.Label lb_Afternoon;
        private System.Windows.Forms.Label lb_Morning;
        private System.Windows.Forms.Button btn_SaveChange;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lb_FieldType;
        private System.Windows.Forms.ComboBox cb_FieldType;
    }
}