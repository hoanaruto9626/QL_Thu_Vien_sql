namespace QL_Thu_Vien
{
    partial class fDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gpDangNhap = new Guna.UI2.WinForms.Guna2Panel();
            btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenDN = new Guna.UI2.WinForms.Guna2TextBox();
            btnThoat = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            gpDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // gpDangNhap
            // 
            gpDangNhap.Anchor = AnchorStyles.None;
            gpDangNhap.BackgroundImage = (Image)resources.GetObject("gpDangNhap.BackgroundImage");
            gpDangNhap.Controls.Add(btnDangNhap);
            gpDangNhap.Controls.Add(label1);
            gpDangNhap.Controls.Add(txtMatKhau);
            gpDangNhap.Controls.Add(txtTenDN);
            gpDangNhap.Controls.Add(btnThoat);
            gpDangNhap.CustomizableEdges = customizableEdges8;
            gpDangNhap.ForeColor = SystemColors.ActiveCaptionText;
            gpDangNhap.Location = new Point(383, 175);
            gpDangNhap.Name = "gpDangNhap";
            gpDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges9;
            gpDangNhap.Size = new Size(1124, 681);
            gpDangNhap.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BorderRadius = 18;
            btnDangNhap.CustomizableEdges = customizableEdges1;
            btnDangNhap.DisabledState.BorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDangNhap.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDangNhap.FillColor = Color.FromArgb(128, 128, 255);
            btnDangNhap.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.Black;
            btnDangNhap.Location = new Point(428, 420);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDangNhap.Size = new Size(286, 56);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(452, 159);
            label1.Name = "label1";
            label1.Size = new Size(224, 51);
            label1.TabIndex = 3;
            label1.Text = "Đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderRadius = 18;
            txtMatKhau.CustomizableEdges = customizableEdges3;
            txtMatKhau.DefaultText = "";
            txtMatKhau.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMatKhau.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMatKhau.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMatKhau.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMatKhau.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatKhau.Font = new Font("Segoe UI", 9F);
            txtMatKhau.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatKhau.Location = new Point(428, 333);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.SelectedText = "";
            txtMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMatKhau.Size = new Size(286, 55);
            txtMatKhau.TabIndex = 2;
            // 
            // txtTenDN
            // 
            txtTenDN.BorderRadius = 18;
            txtTenDN.CustomizableEdges = customizableEdges5;
            txtTenDN.DefaultText = "";
            txtTenDN.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenDN.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenDN.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenDN.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenDN.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDN.Font = new Font("Segoe UI", 9F);
            txtTenDN.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDN.Location = new Point(428, 257);
            txtTenDN.Margin = new Padding(3, 4, 3, 4);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.PasswordChar = '\0';
            txtTenDN.PlaceholderText = "Tên đăng nhập";
            txtTenDN.SelectedText = "";
            txtTenDN.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTenDN.Size = new Size(286, 55);
            txtTenDN.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.DisabledState.BorderColor = Color.DarkGray;
            btnThoat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThoat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThoat.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnThoat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThoat.FillColor = Color.White;
            btnThoat.FillColor2 = Color.White;
            btnThoat.Font = new Font("Segoe UI", 9F);
            btnThoat.ForeColor = Color.Transparent;
            btnThoat.Image = Properties.Resources.cancel_50px;
            btnThoat.ImageSize = new Size(62, 62);
            btnThoat.Location = new Point(4, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnThoat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnThoat.Size = new Size(53, 53);
            btnThoat.TabIndex = 0;
            btnThoat.Click += btnThoat_Click;
            // 
            // fDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1942, 1031);
            Controls.Add(gpDangNhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            gpDangNhap.ResumeLayout(false);
            gpDangNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Panel gpDangNhap;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnThoat;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDN;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
    }
}
