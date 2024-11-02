namespace QL_Thu_Vien
{
    partial class fMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnDangXuat = new ToolStripMenuItem();
            mnThoat = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            mnSach = new ToolStripMenuItem();
            mnLop = new ToolStripMenuItem();
            mnSinhVien = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            mnPhieuMuon = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold);
            label1.Location = new Point(288, 124);
            label1.Name = "label1";
            label1.Size = new Size(219, 51);
            label1.TabIndex = 0;
            label1.Text = "Phần mềm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold);
            label2.Location = new Point(240, 199);
            label2.Name = "label2";
            label2.Size = new Size(333, 51);
            label2.TabIndex = 1;
            label2.Text = "Quản lý thư viện";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, helpToolStripMenuItem, helpToolStripMenuItem1, reportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(822, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnDangXuat, mnThoat });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnDangXuat
            // 
            mnDangXuat.Name = "mnDangXuat";
            mnDangXuat.Size = new Size(160, 26);
            mnDangXuat.Text = "Đăng xuất";
            mnDangXuat.Click += mnDangXuat_Click;
            // 
            // mnThoat
            // 
            mnThoat.Name = "mnThoat";
            mnThoat.Size = new Size(160, 26);
            mnThoat.Text = "Thoát";
            mnThoat.Click += mnThoat_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnSach, mnLop, mnSinhVien });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "&Danh mục";
            // 
            // mnSach
            // 
            mnSach.Name = "mnSach";
            mnSach.Size = new Size(151, 26);
            mnSach.Text = "Sách";
            mnSach.Click += mnSach_Click;
            // 
            // mnLop
            // 
            mnLop.Name = "mnLop";
            mnLop.Size = new Size(151, 26);
            mnLop.Text = "Lớp";
            mnLop.Click += mnLop_Click;
            // 
            // mnSinhVien
            // 
            mnSinhVien.Name = "mnSinhVien";
            mnSinhVien.Size = new Size(151, 26);
            mnSinhVien.Text = "Sinh viên";
            mnSinhVien.Click += mnSinhVien_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnPhieuMuon });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(102, 24);
            helpToolStripMenuItem.Text = "Phiếu mượn";
            // 
            // mnPhieuMuon
            // 
            mnPhieuMuon.Name = "mnPhieuMuon";
            mnPhieuMuon.Size = new Size(224, 26);
            mnPhieuMuon.Text = "Phiếu mượn";
            mnPhieuMuon.Click += mnPhieuMuon_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(55, 24);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(68, 24);
            reportToolStripMenuItem.Text = "Report";
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(822, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnDangXuat;
        private ToolStripMenuItem mnThoat;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem mnSach;
        private ToolStripMenuItem mnLop;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem mnSinhVien;
        private ToolStripMenuItem mnPhieuMuon;
    }
}