namespace PersonalProject
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            LoginLabel = new Label();
            LogoPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.Location = new Point(45, 314);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(639, 61);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.Location = new Point(237, 63);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(271, 248);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPictureBox.TabIndex = 1;
            LogoPictureBox.TabStop = false;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 814);
            Controls.Add(LogoPictureBox);
            Controls.Add(LoginLabel);
            MaximizeBox = false;
            Name = "StartPage";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private PictureBox LogoPictureBox;
    }
}
