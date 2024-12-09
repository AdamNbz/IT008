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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            menuStrip1 = new MenuStrip();
            preferenceMenu = new ToolStripMenuItem();
            AddMenu = new ToolStripMenuItem();
            chỉnhSửaToolStripMenuItem = new ToolStripMenuItem();
            xoáToolStripMenuItem = new ToolStripMenuItem();
            nhậpFileExcelToolStripMenuItem = new ToolStripMenuItem();
            xuấtFileExcelToolStripMenuItem = new ToolStripMenuItem();
            ExitMenu = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            addButton = new ToolStripButton();
            AddLabel = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            searchBox = new ToolStripTextBox();
            searchLabel = new ToolStripLabel();
            EditButton = new ToolStripButton();
            EditLabel = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            DeleteButton = new ToolStripButton();
            DeleteLabel = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            ImportButton = new ToolStripButton();
            ExportButton = new ToolStripButton();
            studentList = new DataGridView();
            ListOrder = new DataGridViewTextBoxColumn();
            studentID = new DataGridViewTextBoxColumn();
            studentName = new DataGridViewTextBoxColumn();
            studentDepartment = new DataGridViewTextBoxColumn();
            studentScore = new DataGridViewTextBoxColumn();
            TrainingPoint = new DataGridViewTextBoxColumn();
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
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1397, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // preferenceMenu
            // 
            preferenceMenu.DropDownItems.AddRange(new ToolStripItem[] { AddMenu, chỉnhSửaToolStripMenuItem, xoáToolStripMenuItem, nhậpFileExcelToolStripMenuItem, xuấtFileExcelToolStripMenuItem, ExitMenu });
            preferenceMenu.Name = "preferenceMenu";
            preferenceMenu.Size = new Size(153, 38);
            preferenceMenu.Text = "Chức Năng";
            // 
            // AddMenu
            // 
            AddMenu.Name = "AddMenu";
            AddMenu.Size = new Size(324, 44);
            AddMenu.Text = "Thêm mới";
            AddMenu.Click += AddMenu_Click;
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            chỉnhSửaToolStripMenuItem.Size = new Size(324, 44);
            chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            chỉnhSửaToolStripMenuItem.Click += chỉnhSửaToolStripMenuItem_Click;
            // 
            // xoáToolStripMenuItem
            // 
            xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            xoáToolStripMenuItem.Size = new Size(324, 44);
            xoáToolStripMenuItem.Text = "Xoá";
            xoáToolStripMenuItem.Click += xoáToolStripMenuItem_Click;
            // 
            // nhậpFileExcelToolStripMenuItem
            // 
            nhậpFileExcelToolStripMenuItem.Name = "nhậpFileExcelToolStripMenuItem";
            nhậpFileExcelToolStripMenuItem.Size = new Size(324, 44);
            nhậpFileExcelToolStripMenuItem.Text = "Nhập File Excel...";
            nhậpFileExcelToolStripMenuItem.Click += nhậpFileExcelToolStripMenuItem_Click;
            // 
            // xuấtFileExcelToolStripMenuItem
            // 
            xuấtFileExcelToolStripMenuItem.Name = "xuấtFileExcelToolStripMenuItem";
            xuấtFileExcelToolStripMenuItem.Size = new Size(324, 44);
            xuấtFileExcelToolStripMenuItem.Text = "Xuất File Excel...";
            xuấtFileExcelToolStripMenuItem.Click += xuấtFileExcelToolStripMenuItem_Click;
            // 
            // ExitMenu
            // 
            ExitMenu.Name = "ExitMenu";
            ExitMenu.Size = new Size(324, 44);
            ExitMenu.Text = "Thoát";
            ExitMenu.Click += ExitMenu_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { addButton, AddLabel, toolStripSeparator1, searchBox, searchLabel, EditButton, EditLabel, toolStripSeparator2, DeleteButton, DeleteLabel, toolStripSeparator3, ImportButton, ExportButton });
            toolStrip1.Location = new Point(0, 46);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 4, 0);
            toolStrip1.Size = new Size(1397, 47);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            addButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            addButton.Image = Properties.Resources.add;
            addButton.ImageTransparentColor = Color.Magenta;
            addButton.Name = "addButton";
            addButton.Size = new Size(46, 41);
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
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // searchBox
            // 
            searchBox.Alignment = ToolStripItemAlignment.Right;
            searchBox.AutoSize = false;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(554, 39);
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchLabel
            // 
            searchLabel.Alignment = ToolStripItemAlignment.Right;
            searchLabel.Font = new Font("Segoe UI", 9F);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(211, 41);
            searchLabel.Text = "Tìm kiếm theo tên";
            // 
            // EditButton
            // 
            EditButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.ImageTransparentColor = Color.Magenta;
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(46, 41);
            EditButton.Text = "Sửa";
            EditButton.Click += EditButton_Click;
            // 
            // EditLabel
            // 
            EditLabel.Font = new Font("Segoe UI", 11.25F);
            EditLabel.Name = "EditLabel";
            EditLabel.Size = new Size(67, 41);
            EditLabel.Text = "Sửa";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 47);
            // 
            // DeleteButton
            // 
            DeleteButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.ImageTransparentColor = Color.Magenta;
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(46, 41);
            DeleteButton.Text = "Xoá";
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DeleteLabel
            // 
            DeleteLabel.Font = new Font("Segoe UI", 11.25F);
            DeleteLabel.Name = "DeleteLabel";
            DeleteLabel.Size = new Size(69, 41);
            DeleteLabel.Text = "Xoá";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 47);
            // 
            // ImportButton
            // 
            ImportButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ImportButton.Image = (Image)resources.GetObject("ImportButton.Image");
            ImportButton.ImageTransparentColor = Color.Magenta;
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(46, 41);
            ImportButton.Text = "Import";
            ImportButton.Click += ImportButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ExportButton.Image = (Image)resources.GetObject("ExportButton.Image");
            ExportButton.ImageTransparentColor = Color.Magenta;
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(46, 41);
            ExportButton.Text = "Export";
            ExportButton.Click += ExportButton_Click;
            // 
            // studentList
            // 
            studentList.AllowUserToAddRows = false;
            studentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentList.Columns.AddRange(new DataGridViewColumn[] { ListOrder, studentID, studentName, studentDepartment, studentScore, TrainingPoint });
            studentList.Dock = DockStyle.Fill;
            studentList.Location = new Point(0, 93);
            studentList.Margin = new Padding(6);
            studentList.Name = "studentList";
            studentList.RowHeadersWidth = 82;
            studentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentList.Size = new Size(1397, 775);
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
            // TrainingPoint
            // 
            TrainingPoint.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TrainingPoint.HeaderText = "ĐRL";
            TrainingPoint.MinimumWidth = 10;
            TrainingPoint.Name = "TrainingPoint";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 868);
            Controls.Add(studentList);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 2, 4, 2);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
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
        private DataGridViewTextBoxColumn TrainingPoint;
        private ToolStripButton EditButton;
        private ToolStripLabel EditLabel;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton DeleteButton;
        private ToolStripLabel DeleteLabel;
        private ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private ToolStripMenuItem xoáToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton ImportButton;
        private ToolStripButton ExportButton;
        private ToolStripMenuItem nhậpFileExcelToolStripMenuItem;
        private ToolStripMenuItem xuấtFileExcelToolStripMenuItem;
    }
}