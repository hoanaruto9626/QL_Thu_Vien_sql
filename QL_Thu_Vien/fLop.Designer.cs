namespace QL_Thu_Vien
{
    partial class fLop
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
            panel1 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnSkip = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvDSLop = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTenLop = new TextBox();
            txtKhoa = new TextBox();
            txtMaLop = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSLop).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnSkip);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(59, 460);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 70);
            panel1.TabIndex = 33;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkTurquoise;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(690, 24);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Đóng";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnDong_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkTurquoise;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(569, 24);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnLuu_Click;
            // 
            // btnSkip
            // 
            btnSkip.BackColor = Color.DarkTurquoise;
            btnSkip.FlatStyle = FlatStyle.Popup;
            btnSkip.Location = new Point(447, 24);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(94, 29);
            btnSkip.TabIndex = 3;
            btnSkip.Text = "Bỏ qua";
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += btnBoQua_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Aqua;
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.Location = new Point(257, 24);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 2;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnXoa_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Aqua;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Location = new Point(137, 24);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnSua_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Aqua;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(15, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnThem_Click;
            // 
            // dgvDSLop
            // 
            dgvDSLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLop.Location = new Point(59, 185);
            dgvDSLop.Name = "dgvDSLop";
            dgvDSLop.RowHeadersWidth = 51;
            dgvDSLop.Size = new Size(803, 269);
            dgvDSLop.TabIndex = 32;
            dgvDSLop.Click += dgvDSLop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(305, 12);
            label1.Name = "label1";
            label1.Size = new Size(286, 51);
            label1.TabIndex = 17;
            label1.Text = "Danh sách lớp";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenLop);
            groupBox1.Controls.Add(txtKhoa);
            groupBox1.Controls.Add(txtMaLop);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(59, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 113);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtTenLop
            // 
            txtTenLop.BorderStyle = BorderStyle.FixedSingle;
            txtTenLop.Font = new Font("Times New Roman", 9F);
            txtTenLop.Location = new Point(111, 72);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(228, 25);
            txtTenLop.TabIndex = 35;
            // 
            // txtKhoa
            // 
            txtKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtKhoa.Font = new Font("Times New Roman", 9F);
            txtKhoa.Location = new Point(533, 26);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(233, 25);
            txtKhoa.TabIndex = 34;
            // 
            // txtMaLop
            // 
            txtMaLop.BorderStyle = BorderStyle.FixedSingle;
            txtMaLop.Font = new Font("Times New Roman", 9F);
            txtMaLop.Location = new Point(111, 26);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(228, 25);
            txtMaLop.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(15, 74);
            label8.Name = "label8";
            label8.Size = new Size(73, 23);
            label8.TabIndex = 32;
            label8.Text = "Tên lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(408, 28);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 31;
            label6.Text = "Tên khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(20, 28);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 30;
            label2.Text = "Mã lớp";
            // 
            // fLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 568);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dgvDSLop);
            Controls.Add(label1);
            Name = "fLop";
            Text = "Lớp";
            Load += fLop_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSLop).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnSave;
        private Button btnSkip;
        private Button btnDel;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvDSLop;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTenLop;
        private TextBox txtKhoa;
        private TextBox txtMaLop;
        private Label label8;
        private Label label6;
        private Label label2;
    }
}