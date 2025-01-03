namespace Quan_ly_san_the_thao
{
    partial class AdminDeposit
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
            this.lb_Input = new System.Windows.Forms.Label();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Input
            // 
            this.lb_Input.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Input.Location = new System.Drawing.Point(50, 88);
            this.lb_Input.Name = "lb_Input";
            this.lb_Input.Size = new System.Drawing.Size(128, 64);
            this.lb_Input.TabIndex = 0;
            this.lb_Input.Text = "Số tiền nạp cho khách hàng:";
            // 
            // tb_Amount
            // 
            this.tb_Amount.Location = new System.Drawing.Point(184, 101);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(207, 20);
            this.tb_Amount.TabIndex = 1;
            // 
            // btn_Finish
            // 
            this.btn_Finish.BackColor = System.Drawing.Color.Lime;
            this.btn_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finish.Location = new System.Drawing.Point(165, 186);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(147, 28);
            this.btn_Finish.TabIndex = 2;
            this.btn_Finish.Text = "Xác nhận nạp";
            this.btn_Finish.UseVisualStyleBackColor = false;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // AdminDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 259);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.tb_Amount);
            this.Controls.Add(this.lb_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDeposit";
            this.Text = "AdminDeposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Input;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Button btn_Finish;
    }
}