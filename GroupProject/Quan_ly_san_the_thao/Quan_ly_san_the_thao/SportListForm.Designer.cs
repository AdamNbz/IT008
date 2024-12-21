namespace Quan_ly_san_the_thao
{
    partial class SportListForm
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
            this.lb_Greeting = new System.Windows.Forms.Label();
            this.lb_ChooseSport = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.pn_ShortInfo = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pn_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Greeting
            // 
            this.lb_Greeting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Greeting.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_Greeting.Location = new System.Drawing.Point(276, 174);
            this.lb_Greeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Greeting.Name = "lb_Greeting";
            this.lb_Greeting.Size = new System.Drawing.Size(597, 72);
            this.lb_Greeting.TabIndex = 2;
            this.lb_Greeting.Text = "CHÀO MỪNG [TÊN KHÁCH HÀNG]";
            this.lb_Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Greeting.TextChanged += new System.EventHandler(this.lb_Greeting_TextChanged);
            this.lb_Greeting.Resize += new System.EventHandler(this.lb_Greeting_Resize);
            // 
            // lb_ChooseSport
            // 
            this.lb_ChooseSport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ChooseSport.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_ChooseSport.Location = new System.Drawing.Point(276, 306);
            this.lb_ChooseSport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ChooseSport.Name = "lb_ChooseSport";
            this.lb_ChooseSport.Size = new System.Drawing.Size(597, 44);
            this.lb_ChooseSport.TabIndex = 3;
            this.lb_ChooseSport.Text = "Xin vui lòng chọn môn";
            this.lb_ChooseSport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(282, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cầu lông";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(436, 380);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bóng rổ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(733, 380);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "Bóng đá";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(584, 380);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 51);
            this.button3.TabIndex = 6;
            this.button3.Text = "Bóng chuyền";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pn_Main
            // 
            this.pn_Main.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_Main.Controls.Add(this.button5);
            this.pn_Main.Controls.Add(this.pn_ShortInfo);
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Main.Location = new System.Drawing.Point(0, 0);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(174, 611);
            this.pn_Main.TabIndex = 8;
            // 
            // pn_ShortInfo
            // 
            this.pn_ShortInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_ShortInfo.Location = new System.Drawing.Point(0, 0);
            this.pn_ShortInfo.Name = "pn_ShortInfo";
            this.pn_ShortInfo.Size = new System.Drawing.Size(174, 100);
            this.pn_ShortInfo.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 47);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // SportListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 611);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_ChooseSport);
            this.Controls.Add(this.lb_Greeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SportListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SportListForm_FormClosing);
            this.pn_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_Greeting;
        private System.Windows.Forms.Label lb_ChooseSport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pn_ShortInfo;
    }
}