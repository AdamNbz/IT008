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
            this.btn_Return = new System.Windows.Forms.Button();
            this.tb_Evening = new System.Windows.Forms.TextBox();
            this.lb_Evening = new System.Windows.Forms.Label();
            this.tb_Afternoon = new System.Windows.Forms.TextBox();
            this.tb_Morning = new System.Windows.Forms.TextBox();
            this.lb_Afternoon = new System.Windows.Forms.Label();
            this.lb_Morning = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_SaveChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_PriceAdjustment
            // 
            this.lb_PriceAdjustment.AutoSize = true;
            this.lb_PriceAdjustment.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PriceAdjustment.Location = new System.Drawing.Point(280, 40);
            this.lb_PriceAdjustment.Name = "lb_PriceAdjustment";
            this.lb_PriceAdjustment.Size = new System.Drawing.Size(242, 34);
            this.lb_PriceAdjustment.TabIndex = 17;
            this.lb_PriceAdjustment.Text = "Điều chỉnh giá";
            this.lb_PriceAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Return.TabIndex = 26;
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // tb_Evening
            // 
            this.tb_Evening.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Evening.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Evening.Location = new System.Drawing.Point(302, 220);
            this.tb_Evening.Name = "tb_Evening";
            this.tb_Evening.Size = new System.Drawing.Size(299, 28);
            this.tb_Evening.TabIndex = 32;
            this.tb_Evening.Text = "0đ";
            this.tb_Evening.Enter += new System.EventHandler(this.Price_Enter);
            this.tb_Evening.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // lb_Evening
            // 
            this.lb_Evening.AutoSize = true;
            this.lb_Evening.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Evening.Location = new System.Drawing.Point(210, 223);
            this.lb_Evening.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_Evening.Name = "lb_Evening";
            this.lb_Evening.Size = new System.Drawing.Size(42, 20);
            this.lb_Evening.TabIndex = 31;
            this.lb_Evening.Text = "Tối:";
            // 
            // tb_Afternoon
            // 
            this.tb_Afternoon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Afternoon.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Afternoon.Location = new System.Drawing.Point(302, 170);
            this.tb_Afternoon.Name = "tb_Afternoon";
            this.tb_Afternoon.Size = new System.Drawing.Size(299, 28);
            this.tb_Afternoon.TabIndex = 30;
            this.tb_Afternoon.Text = "0đ";
            this.tb_Afternoon.Enter += new System.EventHandler(this.Price_Enter);
            this.tb_Afternoon.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // tb_Morning
            // 
            this.tb_Morning.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Morning.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Morning.Location = new System.Drawing.Point(302, 120);
            this.tb_Morning.Name = "tb_Morning";
            this.tb_Morning.Size = new System.Drawing.Size(299, 28);
            this.tb_Morning.TabIndex = 29;
            this.tb_Morning.Text = "0đ";
            this.tb_Morning.Enter += new System.EventHandler(this.Price_Enter);
            this.tb_Morning.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // lb_Afternoon
            // 
            this.lb_Afternoon.AutoSize = true;
            this.lb_Afternoon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Afternoon.Location = new System.Drawing.Point(186, 173);
            this.lb_Afternoon.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_Afternoon.Name = "lb_Afternoon";
            this.lb_Afternoon.Size = new System.Drawing.Size(66, 20);
            this.lb_Afternoon.TabIndex = 28;
            this.lb_Afternoon.Text = "Chiều:";
            // 
            // lb_Morning
            // 
            this.lb_Morning.AutoSize = true;
            this.lb_Morning.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Morning.Location = new System.Drawing.Point(191, 123);
            this.lb_Morning.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_Morning.Name = "lb_Morning";
            this.lb_Morning.Size = new System.Drawing.Size(61, 20);
            this.lb_Morning.TabIndex = 27;
            this.lb_Morning.Text = "Sáng:";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Tomato;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(232, 339);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(324, 38);
            this.btn_Back.TabIndex = 34;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // btn_SaveChange
            // 
            this.btn_SaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveChange.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChange.Location = new System.Drawing.Point(232, 284);
            this.btn_SaveChange.Name = "btn_SaveChange";
            this.btn_SaveChange.Size = new System.Drawing.Size(324, 49);
            this.btn_SaveChange.TabIndex = 33;
            this.btn_SaveChange.Text = "Lưu thay đổi";
            this.btn_SaveChange.UseVisualStyleBackColor = true;
            // 
            // PriceAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_SaveChange);
            this.Controls.Add(this.tb_Evening);
            this.Controls.Add(this.lb_Evening);
            this.Controls.Add(this.tb_Afternoon);
            this.Controls.Add(this.tb_Morning);
            this.Controls.Add(this.lb_Afternoon);
            this.Controls.Add(this.lb_Morning);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lb_PriceAdjustment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PriceAdjustment";
            this.Text = "PriceAdjustment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PriceAdjustment;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.TextBox tb_Evening;
        private System.Windows.Forms.Label lb_Evening;
        private System.Windows.Forms.TextBox tb_Afternoon;
        private System.Windows.Forms.TextBox tb_Morning;
        private System.Windows.Forms.Label lb_Afternoon;
        private System.Windows.Forms.Label lb_Morning;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_SaveChange;
    }
}