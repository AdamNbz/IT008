using System.Windows.Forms;

namespace PersonalProject
{
    partial class MainPage
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
            menuStrip1 = new MenuStrip();
            preferenceMenu = new ToolStripMenuItem();
            AddMenu = new ToolStripMenuItem();
            ExitMenu = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            addButton = new ToolStripButton();
            AddLabel = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            searchBox = new ToolStripTextBox();
            searchLabel = new ToolStripLabel();
            studentList = new DataGridView();
            ListOrder = new DataGridViewTextBoxColumn();
            studentID = new DataGridViewTextBoxColumn();
            studentName = new DataGridViewTextBoxColumn();
            studentDepartment = new DataGridViewTextBoxColumn();
            studentScore = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentList).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { preferenceMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(752, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // preferenceMenu
            // 
            preferenceMenu.DropDownItems.AddRange(new ToolStripItem[] { AddMenu, ExitMenu });
            preferenceMenu.Name = "preferenceMenu";
            preferenceMenu.Size = new Size(79, 20);
            preferenceMenu.Text = "Chức Năng";
            // 
            // AddMenu
            // 
            AddMenu.Name = "AddMenu";
            AddMenu.Size = new Size(128, 22);
            AddMenu.Text = "Thêm mới";
            AddMenu.Click += AddMenu_Click;
            // 
            // ExitMenu
            // 
            ExitMenu.Name = "ExitMenu";
            ExitMenu.Size = new Size(128, 22);
            ExitMenu.Text = "Thoát";
            ExitMenu.Click += ExitMenu_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { addButton, AddLabel, toolStripSeparator1, searchBox, searchLabel });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(752, 44);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            addButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            addButton.Image = Properties.Resources.add;
            addButton.ImageTransparentColor = Color.Magenta;
            addButton.Name = "addButton";
            addButton.Size = new Size(36, 41);
            addButton.Text = "Thêm mới";
            addButton.Click += addButton_Click;
            // 
            // AddLabel
            // 
            AddLabel.AutoSize = false;
            AddLabel.Font = new Font("Segoe UI", 11.25F);
            AddLabel.Name = "AddLabel";
            AddLabel.Size = new Size(153, 41);
            AddLabel.Text = "Thêm Mới";
            AddLabel.Click += addLabel_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 44);
            // 
            // searchBox
            // 
            searchBox.Alignment = ToolStripItemAlignment.Right;
            searchBox.AutoSize = false;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(300, 23);
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchLabel
            // 
            searchLabel.Alignment = ToolStripItemAlignment.Right;
            searchLabel.Font = new Font("Segoe UI", 9F);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(103, 41);
            searchLabel.Text = "Tìm kiếm theo tên";
            // 
            // studentList
            // 
            studentList.AllowUserToAddRows = false;
            studentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentList.Columns.AddRange(new DataGridViewColumn[] { ListOrder, studentID, studentName, studentDepartment, studentScore });
            studentList.Dock = DockStyle.Fill;
            studentList.Location = new Point(0, 68);
            studentList.Name = "studentList";
            studentList.RowHeadersWidth = 82;
            studentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentList.Size = new Size(752, 339);
            studentList.TabIndex = 2;
            // 
            // ListOrder
            // 
            ListOrder.HeaderText = "Số TT";
            ListOrder.MinimumWidth = 10;
            ListOrder.Name = "ListOrder";
            ListOrder.ReadOnly = true;
            ListOrder.Width = 60;
            // 
            // studentID
            // 
            studentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentID.HeaderText = "MSSV";
            studentID.MinimumWidth = 10;
            studentID.Name = "studentID";
            studentID.ReadOnly = true;
            // 
            // studentName
            // 
            studentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentName.HeaderText = "Họ Tên Sinh Viên";
            studentName.MinimumWidth = 10;
            studentName.Name = "studentName";
            studentName.ReadOnly = true;
            // 
            // studentDepartment
            // 
            studentDepartment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentDepartment.HeaderText = "Khoa";
            studentDepartment.MinimumWidth = 10;
            studentDepartment.Name = "studentDepartment";
            studentDepartment.ReadOnly = true;
            // 
            // studentScore
            // 
            studentScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentScore.HeaderText = "Điểm TB";
            studentScore.MinimumWidth = 10;
            studentScore.Name = "studentScore";
            studentScore.ReadOnly = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 407);
            Controls.Add(studentList);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainPage";
            Text = "Quản Lý Sinh Viên";
            FormClosed += FormClosed_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem preferenceMenu;
        private ToolStripMenuItem AddMenu;
        private ToolStripMenuItem ExitMenu;
        private ToolStrip toolStrip1;
        private ToolStripButton addButton;
        private ToolStripLabel AddLabel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox searchBox;
        private ToolStripLabel searchLabel;
        private DataGridView studentList;
        private DataGridViewTextBoxColumn ListOrder;
        private DataGridViewTextBoxColumn studentID;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn studentDepartment;
        private DataGridViewTextBoxColumn studentScore;
    }
}