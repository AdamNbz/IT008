namespace PersonalProject
{
    partial class AddStudent
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
            idLabel = new Label();
            idBox = new TextBox();
            nameBox = new TextBox();
            nameLabel = new Label();
            majorLabel = new Label();
            scoreLabel = new Label();
            scoreBox = new TextBox();
            exitButton = new Button();
            addButton = new Button();
            majorBox = new ComboBox();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Arial", 14.25F);
            idLabel.Location = new Point(88, 71);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(295, 43);
            idLabel.TabIndex = 0;
            idLabel.Text = "Mã số Sinh Viên";
            // 
            // idBox
            // 
            idBox.Location = new Point(465, 76);
            idBox.Margin = new Padding(6);
            idBox.Name = "idBox";
            idBox.Size = new Size(796, 39);
            idBox.TabIndex = 1;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(465, 171);
            nameBox.Margin = new Padding(6);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(796, 39);
            nameBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 14.25F);
            nameLabel.Location = new Point(88, 166);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(304, 43);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Họ tên Sinh Viên";
            // 
            // majorLabel
            // 
            majorLabel.AutoSize = true;
            majorLabel.Font = new Font("Arial", 14.25F);
            majorLabel.Location = new Point(88, 267);
            majorLabel.Name = "majorLabel";
            majorLabel.Size = new Size(107, 43);
            majorLabel.TabIndex = 5;
            majorLabel.Text = "Khoa";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Arial", 14.25F);
            scoreLabel.Location = new Point(88, 373);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(166, 43);
            scoreLabel.TabIndex = 7;
            scoreLabel.Text = "Điểm TB";
            // 
            // scoreBox
            // 
            scoreBox.Location = new Point(465, 378);
            scoreBox.Margin = new Padding(6);
            scoreBox.Name = "scoreBox";
            scoreBox.Size = new Size(201, 39);
            scoreBox.TabIndex = 8;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 128, 0);
            exitButton.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(1017, 462);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(244, 80);
            exitButton.TabIndex = 9;
            exitButton.Text = "Thoát";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.DarkSeaGreen;
            addButton.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(767, 462);
            addButton.Name = "addButton";
            addButton.Size = new Size(244, 80);
            addButton.TabIndex = 10;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // majorBox
            // 
            majorBox.FormattingEnabled = true;
            majorBox.Items.AddRange(new object[] { "Công nghệ phần mềm", "Khoa học máy tính", "Hệ thống thông tin", "Khoa học & Kỹ thuật thông tin", "Mạng máy tính & Truyền thông dữ liệu", "Kỹ thuật máy tính" });
            majorBox.Location = new Point(465, 272);
            majorBox.Name = "majorBox";
            majorBox.Size = new Size(618, 40);
            majorBox.TabIndex = 11;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 574);
            Controls.Add(majorBox);
            Controls.Add(addButton);
            Controls.Add(exitButton);
            Controls.Add(scoreBox);
            Controls.Add(scoreLabel);
            Controls.Add(majorLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(idLabel);
            Name = "AddForm";
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private TextBox idBox;
        private TextBox nameBox;
        private Label nameLabel;
        private Label majorLabel;
        private Label scoreLabel;
        private TextBox scoreBox;
        private Button exitButton;
        private Button addButton;
        private ComboBox majorBox;
    }
}