namespace QL_Thu_Vien
{
    partial class fManager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManager));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnThoat = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tbDauSach = new TabPage();
            tbDocGia = new TabPage();
            tbPhieuMuon = new TabPage();
            tabPage4 = new TabPage();
            tbTacGia = new TabPage();
            tbSachTacGia = new TabPage();
            tbNgonNgu = new TabPage();
            tbViTri = new TabPage();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dauSach1 = new UserControls.DauSach();
            guna2TabControl1.SuspendLayout();
            tbDauSach.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.DisabledState.BorderColor = Color.DarkGray;
            btnThoat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThoat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThoat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThoat.FillColor = Color.White;
            btnThoat.Font = new Font("Segoe UI", 9F);
            btnThoat.ForeColor = Color.White;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageSize = new Size(63, 63);
            btnThoat.Location = new Point(1856, 12);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThoat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnThoat.Size = new Size(58, 54);
            btnThoat.TabIndex = 0;
            btnThoat.Click += btnThoat_Click;
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Alignment = TabAlignment.Left;
            guna2TabControl1.Controls.Add(tbDauSach);
            guna2TabControl1.Controls.Add(tbDocGia);
            guna2TabControl1.Controls.Add(tbPhieuMuon);
            guna2TabControl1.Controls.Add(tabPage4);
            guna2TabControl1.Controls.Add(tbTacGia);
            guna2TabControl1.Controls.Add(tbSachTacGia);
            guna2TabControl1.Controls.Add(tbNgonNgu);
            guna2TabControl1.Controls.Add(tbViTri);
            guna2TabControl1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TabControl1.ItemSize = new Size(270, 110);
            guna2TabControl1.Location = new Point(-7, 128);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.ShowToolTips = true;
            guna2TabControl1.Size = new Size(1937, 972);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            guna2TabControl1.TabButtonSize = new Size(270, 110);
            guna2TabControl1.TabIndex = 1;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(128, 128, 255);
            guna2TabControl1.Tag = "";
            // 
            // tbDauSach
            // 
            tbDauSach.BackColor = Color.AliceBlue;
            tbDauSach.Controls.Add(dauSach1);
            tbDauSach.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbDauSach.ForeColor = Color.FromArgb(192, 192, 255);
            tbDauSach.Location = new Point(274, 4);
            tbDauSach.Name = "tbDauSach";
            tbDauSach.Padding = new Padding(3);
            tbDauSach.Size = new Size(1659, 964);
            tbDauSach.TabIndex = 0;
            tbDauSach.Text = "Đầu sách";
            tbDauSach.Click += tbDauSach_Click;
            // 
            // tbDocGia
            // 
            tbDocGia.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbDocGia.Location = new Point(274, 4);
            tbDocGia.Name = "tbDocGia";
            tbDocGia.Padding = new Padding(3);
            tbDocGia.Size = new Size(1659, 964);
            tbDocGia.TabIndex = 1;
            tbDocGia.Text = "Độc giả";
            tbDocGia.UseVisualStyleBackColor = true;
            // 
            // tbPhieuMuon
            // 
            tbPhieuMuon.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPhieuMuon.Location = new Point(274, 4);
            tbPhieuMuon.Name = "tbPhieuMuon";
            tbPhieuMuon.Padding = new Padding(3);
            tbPhieuMuon.Size = new Size(1659, 964);
            tbPhieuMuon.TabIndex = 2;
            tbPhieuMuon.Text = "Phiếu mượn";
            tbPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(274, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1659, 964);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Đăng ký";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbTacGia
            // 
            tbTacGia.Location = new Point(274, 4);
            tbTacGia.Name = "tbTacGia";
            tbTacGia.Padding = new Padding(3);
            tbTacGia.Size = new Size(1659, 964);
            tbTacGia.TabIndex = 4;
            tbTacGia.Text = "Tác giả";
            tbTacGia.UseVisualStyleBackColor = true;
            // 
            // tbSachTacGia
            // 
            tbSachTacGia.Location = new Point(274, 4);
            tbSachTacGia.Name = "tbSachTacGia";
            tbSachTacGia.Padding = new Padding(3);
            tbSachTacGia.Size = new Size(1659, 964);
            tbSachTacGia.TabIndex = 5;
            tbSachTacGia.Text = "Sách tác giả";
            tbSachTacGia.UseVisualStyleBackColor = true;
            // 
            // tbNgonNgu
            // 
            tbNgonNgu.Location = new Point(274, 4);
            tbNgonNgu.Name = "tbNgonNgu";
            tbNgonNgu.Padding = new Padding(3);
            tbNgonNgu.Size = new Size(1659, 964);
            tbNgonNgu.TabIndex = 6;
            tbNgonNgu.Text = "Ngôn ngữ";
            tbNgonNgu.UseVisualStyleBackColor = true;
            // 
            // tbViTri
            // 
            tbViTri.Location = new Point(274, 4);
            tbViTri.Name = "tbViTri";
            tbViTri.Padding = new Padding(3);
            tbViTri.Size = new Size(1659, 964);
            tbViTri.TabIndex = 7;
            tbViTri.Text = "Vị trí";
            tbViTri.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(341, 90);
            label1.TabIndex = 2;
            label1.Text = "Thư Viện";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // dauSach1
            // 
            dauSach1.Location = new Point(0, 0);
            dauSach1.Name = "dauSach1";
            dauSach1.Size = new Size(1653, 958);
            dauSach1.TabIndex = 0;
            // 
            // fManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1942, 1102);
            Controls.Add(label1);
            Controls.Add(guna2TabControl1);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fManager";
            Text = "Manager";
            Load += Manager_Load;
            guna2TabControl1.ResumeLayout(false);
            tbDauSach.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnThoat;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tbDauSach;
        private TabPage tbDocGia;
        private Label label1;
        private TabPage tbPhieuMuon;
        private TabPage tabPage4;
        private TabPage tbTacGia;
        private TabPage tbSachTacGia;
        private TabPage tbNgonNgu;
        private TabPage tbViTri;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UserControls.DauSach dauSach1;
    }
}