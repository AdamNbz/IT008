namespace Quan_ly_san_the_thao
{
    partial class SportSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Football = new System.Windows.Forms.Button();
            this.btn_Volleyball = new System.Windows.Forms.Button();
            this.btn_Basketball = new System.Windows.Forms.Button();
            this.btn_Badminton = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãy chọn môn thể thao";
            // 
            // btn_Football
            // 
            this.btn_Football.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Football.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Football.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Football.Location = new System.Drawing.Point(172, 302);
            this.btn_Football.Name = "btn_Football";
            this.btn_Football.Size = new System.Drawing.Size(206, 58);
            this.btn_Football.TabIndex = 1;
            this.btn_Football.Text = "BÓNG ĐÁ";
            this.btn_Football.UseVisualStyleBackColor = false;
            this.btn_Football.Click += new System.EventHandler(this.btn_Football_Click);
            // 
            // btn_Volleyball
            // 
            this.btn_Volleyball.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Volleyball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volleyball.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volleyball.Location = new System.Drawing.Point(400, 302);
            this.btn_Volleyball.Name = "btn_Volleyball";
            this.btn_Volleyball.Size = new System.Drawing.Size(206, 58);
            this.btn_Volleyball.TabIndex = 2;
            this.btn_Volleyball.Text = "BÓNG CHUYỀN";
            this.btn_Volleyball.UseVisualStyleBackColor = false;
            this.btn_Volleyball.Click += new System.EventHandler(this.btn_Volleyball_Click);
            // 
            // btn_Basketball
            // 
            this.btn_Basketball.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Basketball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Basketball.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Basketball.Location = new System.Drawing.Point(172, 387);
            this.btn_Basketball.Name = "btn_Basketball";
            this.btn_Basketball.Size = new System.Drawing.Size(206, 58);
            this.btn_Basketball.TabIndex = 3;
            this.btn_Basketball.Text = "BÓNG RỔ";
            this.btn_Basketball.UseVisualStyleBackColor = false;
            this.btn_Basketball.Click += new System.EventHandler(this.btn_Basketball_Click);
            // 
            // btn_Badminton
            // 
            this.btn_Badminton.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Badminton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Badminton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Badminton.Location = new System.Drawing.Point(400, 387);
            this.btn_Badminton.Name = "btn_Badminton";
            this.btn_Badminton.Size = new System.Drawing.Size(206, 58);
            this.btn_Badminton.TabIndex = 4;
            this.btn_Badminton.Text = "CẦU LÔNG";
            this.btn_Badminton.UseVisualStyleBackColor = false;
            this.btn_Badminton.Click += new System.EventHandler(this.btn_Badminton_Click);
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
            this.btn_Close.TabIndex = 21;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // SportSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 611);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Badminton);
            this.Controls.Add(this.btn_Basketball);
            this.Controls.Add(this.btn_Volleyball);
            this.Controls.Add(this.btn_Football);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SportSelection";
            this.Text = "SportSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Football;
        private System.Windows.Forms.Button btn_Volleyball;
        private System.Windows.Forms.Button btn_Basketball;
        private System.Windows.Forms.Button btn_Badminton;
        private System.Windows.Forms.Button btn_Close;
    }
}