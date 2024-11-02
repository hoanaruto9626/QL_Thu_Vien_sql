namespace QL_Thu_Vien
{
    partial class fsinhvien
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
            groupBox1 = new GroupBox();
            lbTuoi = new Label();
            cbMaLop = new ComboBox();
            dateNamSinh = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtSDT = new TextBox();
            txtTenSV = new TextBox();
            txtMaSV = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnSkip = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvSinhVien = new DataGridView();
            label1 = new Label();
            btnGioiTinh = new Label();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdNu);
            groupBox1.Controls.Add(rdNam);
            groupBox1.Controls.Add(btnGioiTinh);
            groupBox1.Controls.Add(lbTuoi);
            groupBox1.Controls.Add(cbMaLop);
            groupBox1.Controls.Add(dateNamSinh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenSV);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(62, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1003, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // lbTuoi
            // 
            lbTuoi.AutoSize = true;
            lbTuoi.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbTuoi.Location = new Point(850, 74);
            lbTuoi.Name = "lbTuoi";
            lbTuoi.Size = new Size(0, 23);
            lbTuoi.TabIndex = 43;
            // 
            // cbMaLop
            // 
            cbMaLop.FormattingEnabled = true;
            cbMaLop.Location = new Point(479, 69);
            cbMaLop.Name = "cbMaLop";
            cbMaLop.Size = new Size(233, 28);
            cbMaLop.TabIndex = 42;
            // 
            // dateNamSinh
            // 
            dateNamSinh.CustomFormat = "dd/MM/yyyy";
            dateNamSinh.Format = DateTimePickerFormat.Custom;
            dateNamSinh.Location = new Point(850, 25);
            dateNamSinh.Name = "dateNamSinh";
            dateNamSinh.Size = new Size(127, 27);
            dateNamSinh.TabIndex = 41;
            dateNamSinh.ValueChanged += dateNamSinh_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(740, 72);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 39;
            label4.Text = "Tuổi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(740, 28);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 38;
            label5.Text = "Năm sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(370, 72);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 36;
            label3.Text = "Mã lớp";
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Times New Roman", 9F);
            txtSDT.Location = new Point(104, 72);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(228, 25);
            txtSDT.TabIndex = 35;
            // 
            // txtTenSV
            // 
            txtTenSV.BorderStyle = BorderStyle.FixedSingle;
            txtTenSV.Font = new Font("Times New Roman", 9F);
            txtTenSV.Location = new Point(479, 26);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(233, 25);
            txtTenSV.TabIndex = 34;
            // 
            // txtMaSV
            // 
            txtMaSV.BorderStyle = BorderStyle.FixedSingle;
            txtMaSV.Font = new Font("Times New Roman", 9F);
            txtMaSV.Location = new Point(104, 26);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(228, 25);
            txtMaSV.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(13, 72);
            label8.Name = "label8";
            label8.Size = new Size(48, 23);
            label8.TabIndex = 32;
            label8.Text = "SDT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(370, 28);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 31;
            label6.Text = "Tên SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 28);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 30;
            label2.Text = "Mã SV";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnSkip);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(62, 551);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 70);
            panel1.TabIndex = 18;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.PaleVioletRed;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(893, 24);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Đóng";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnDong_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.PaleVioletRed;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(772, 24);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnLuu_Click;
            // 
            // btnSkip
            // 
            btnSkip.BackColor = Color.PaleVioletRed;
            btnSkip.FlatStyle = FlatStyle.Popup;
            btnSkip.Location = new Point(652, 24);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(94, 29);
            btnSkip.TabIndex = 3;
            btnSkip.Text = "Bỏ qua";
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += btnBoQua_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.HotPink;
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.Location = new Point(286, 24);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 2;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnXoa_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.HotPink;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Location = new Point(156, 24);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnSua_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.HotPink;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(30, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnThem_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(62, 276);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(1003, 269);
            dgvSinhVien.TabIndex = 17;
            dgvSinhVien.Click += dgvSinhVien_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Fuchsia;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(385, 32);
            label1.Name = "label1";
            label1.Size = new Size(389, 51);
            label1.TabIndex = 19;
            label1.Text = "Danh sách sinh viên";
            // 
            // btnGioiTinh
            // 
            btnGioiTinh.AutoSize = true;
            btnGioiTinh.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnGioiTinh.Location = new Point(13, 112);
            btnGioiTinh.Name = "btnGioiTinh";
            btnGioiTinh.Size = new Size(85, 23);
            btnGioiTinh.TabIndex = 44;
            btnGioiTinh.Text = "Giới tính";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            rdNam.Location = new Point(118, 111);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(70, 27);
            rdNam.TabIndex = 45;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            rdNu.Location = new Point(219, 112);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(57, 27);
            rdNu.TabIndex = 46;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // fsinhvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 706);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dgvSinhVien);
            Controls.Add(groupBox1);
            Name = "fsinhvien";
            Text = "Sinh viên";
            Load += fsinhvien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Button btnExit;
        private Button btnSave;
        private Button btnSkip;
        private Button btnDel;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvSinhVien;
        private Label label1;
        private TextBox txtSDT;
        private TextBox txtTenSV;
        private TextBox txtMaSV;
        private Label label8;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateNamSinh;
        private ComboBox cbMaLop;
        private Label lbTuoi;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private Label btnGioiTinh;
    }
}