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
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            LoginButton = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.Location = new Point(63, 380);
            LoginLabel.Margin = new Padding(4, 0, 4, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(639, 61);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
            LogoPictureBox.Location = new Point(236, 81);
            LogoPictureBox.Margin = new Padding(4, 2, 4, 2);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(271, 247);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPictureBox.TabIndex = 1;
            LogoPictureBox.TabStop = false;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(63, 531);
            usernameBox.Margin = new Padding(6);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(611, 39);
            usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(63, 678);
            passwordBox.Margin = new Padding(6);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(611, 39);
            passwordBox.TabIndex = 4;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(63, 478);
            usernameLabel.Margin = new Padding(6, 0, 6, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(258, 44);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Tên đăng nhập";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(63, 625);
            passwordLabel.Margin = new Padding(6, 0, 6, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(173, 44);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Mật khẩu";
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(63, 794);
            LoginButton.Margin = new Padding(6);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(290, 94);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Đăng nhập";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(384, 794);
            ExitButton.Margin = new Padding(6);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(293, 94);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Thoát";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 949);
            Controls.Add(ExitButton);
            Controls.Add(LoginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(LogoPictureBox);
            Controls.Add(LoginLabel);
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "StartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Enter += LoginButton_Click;
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private PictureBox LogoPictureBox;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button LoginButton;
        private Button ExitButton;
    }
}
