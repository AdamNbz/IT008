namespace Quan_ly_san_the_thao
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.btn_Return = new System.Windows.Forms.Button();
            this.pb_QR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_EnterMoney = new System.Windows.Forms.TextBox();
            this.btn_50k = new System.Windows.Forms.Button();
            this.btn_100k = new System.Windows.Forms.Button();
            this.btn_200k = new System.Windows.Forms.Button();
            this.btn_1M = new System.Windows.Forms.Button();
            this.btn_2M = new System.Windows.Forms.Button();
            this.btn_500k = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QR)).BeginInit();
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
            this.btn_Return.TabIndex = 1;
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // pb_QR
            // 
            this.pb_QR.Image = ((System.Drawing.Image)(resources.GetObject("pb_QR.Image")));
            this.pb_QR.Location = new System.Drawing.Point(378, 48);
            this.pb_QR.Name = "pb_QR";
            this.pb_QR.Size = new System.Drawing.Size(355, 390);
            this.pb_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_QR.TabIndex = 2;
            this.pb_QR.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số dư: xxx.xxx VNĐ";
            // 
            // tb_EnterMoney
            // 
            this.tb_EnterMoney.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EnterMoney.ForeColor = System.Drawing.Color.LightGray;
            this.tb_EnterMoney.Location = new System.Drawing.Point(16, 95);
            this.tb_EnterMoney.Name = "tb_EnterMoney";
            this.tb_EnterMoney.Size = new System.Drawing.Size(330, 28);
            this.tb_EnterMoney.TabIndex = 4;
            this.tb_EnterMoney.Text = "0đ";
            this.tb_EnterMoney.Enter += new System.EventHandler(this.tb_EnterMoney_Enter);
            this.tb_EnterMoney.MouseLeave += new System.EventHandler(this.tb_EnterMoney_MouseLeave);
            // 
            // btn_50k
            // 
            this.btn_50k.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_50k.Location = new System.Drawing.Point(16, 144);
            this.btn_50k.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.btn_50k.Name = "btn_50k";
            this.btn_50k.Size = new System.Drawing.Size(100, 30);
            this.btn_50k.TabIndex = 5;
            this.btn_50k.Text = "50.000";
            this.btn_50k.UseVisualStyleBackColor = true;
            this.btn_50k.Click += new System.EventHandler(this.btn_Money_Click);
            // 
            // btn_100k
            // 
            this.btn_100k.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_100k.Location = new System.Drawing.Point(131, 144);
            this.btn_100k.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_100k.Name = "btn_100k";
            this.btn_100k.Size = new System.Drawing.Size(100, 30);
            this.btn_100k.TabIndex = 6;
            this.btn_100k.Text = "100.000";
            this.btn_100k.UseVisualStyleBackColor = true;
            // 
            // btn_200k
            // 
            this.btn_200k.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_200k.Location = new System.Drawing.Point(246, 144);
            this.btn_200k.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_200k.Name = "btn_200k";
            this.btn_200k.Size = new System.Drawing.Size(100, 30);
            this.btn_200k.TabIndex = 7;
            this.btn_200k.Text = "200.000";
            this.btn_200k.UseVisualStyleBackColor = true;
            // 
            // btn_1M
            // 
            this.btn_1M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1M.Location = new System.Drawing.Point(131, 190);
            this.btn_1M.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_1M.Name = "btn_1M";
            this.btn_1M.Size = new System.Drawing.Size(100, 30);
            this.btn_1M.TabIndex = 9;
            this.btn_1M.Text = "1.000.000";
            this.btn_1M.UseVisualStyleBackColor = true;
            // 
            // btn_2M
            // 
            this.btn_2M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2M.Location = new System.Drawing.Point(246, 190);
            this.btn_2M.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_2M.Name = "btn_2M";
            this.btn_2M.Size = new System.Drawing.Size(100, 30);
            this.btn_2M.TabIndex = 10;
            this.btn_2M.Text = "2.000.000";
            this.btn_2M.UseVisualStyleBackColor = true;
            // 
            // btn_500k
            // 
            this.btn_500k.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_500k.Location = new System.Drawing.Point(16, 190);
            this.btn_500k.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_500k.Name = "btn_500k";
            this.btn_500k.Size = new System.Drawing.Size(100, 30);
            this.btn_500k.TabIndex = 8;
            this.btn_500k.Text = "500.000";
            this.btn_500k.UseVisualStyleBackColor = true;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.btn_500k);
            this.Controls.Add(this.btn_2M);
            this.Controls.Add(this.btn_1M);
            this.Controls.Add(this.btn_200k);
            this.Controls.Add(this.btn_100k);
            this.Controls.Add(this.btn_50k);
            this.Controls.Add(this.tb_EnterMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_QR);
            this.Controls.Add(this.btn_Return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)(this.pb_QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.PictureBox pb_QR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_EnterMoney;
        private System.Windows.Forms.Button btn_50k;
        private System.Windows.Forms.Button btn_100k;
        private System.Windows.Forms.Button btn_200k;
        private System.Windows.Forms.Button btn_1M;
        private System.Windows.Forms.Button btn_2M;
        private System.Windows.Forms.Button btn_500k;
    }
}