using QL_Thu_Vien.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Thu_Vien
{
    public partial class fsinhvien : Form
    {
        DataTable dataThuVien;
        public fsinhvien()
        {
            InitializeComponent();
            LoadMaLopComboBox();
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM SinhVien";
            dataThuVien = DBConnection.GetDataToTable(sql);
            dgvSinhVien.DataSource = dataThuVien;
            dgvSinhVien.Columns[0].HeaderText = "Mã sinh viên";
            dgvSinhVien.Columns[1].HeaderText = "Tên sinh viên";
            dgvSinhVien.Columns[2].HeaderText = "Năm sinh";
            dgvSinhVien.Columns[3].HeaderText = "Số điện thoại";
            dgvSinhVien.Columns[4].HeaderText = "Mã lớp";
            dgvSinhVien.Columns[5].HeaderText = "Tuổi";
            dgvSinhVien.Columns[6].HeaderText = "Giới tính";

            dgvSinhVien.Columns[0].Width = 150;
            dgvSinhVien.Columns[1].Width = 200;
            dgvSinhVien.Columns[2].Width = 100;
            dgvSinhVien.Columns[3].Width = 150;
            dgvSinhVien.Columns[4].Width = 150;
            dgvSinhVien.Columns[5].Width = 100;
            dgvSinhVien.Columns[6].Width = 100;

            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.EditMode = DataGridViewEditMode.EditProgrammatically;


            dgvSinhVien.CellFormatting += DgvSinhVien_CellFormatting;
        }

        private void fsinhvien_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            txtMaSV.Enabled = false;
            LoadDataGridView();

            btnSave.Paint += Button_Paint;
            btnSkip.Paint += Button_Paint;
        }

        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có đang ở chế độ "Thêm mới" hay không
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return;
            }

            // Kiểm tra xem có dữ liệu trong DataGridView hay không
            if (dgvSinhVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra nếu không có hàng nào được chọn
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dữ liệu từ hàng hiện tại và gán vào các TextBox
            txtMaSV.Text = dgvSinhVien.CurrentRow.Cells["MaSV"].Value?.ToString() ?? string.Empty;
            txtTenSV.Text = dgvSinhVien.CurrentRow.Cells["TenSV"].Value?.ToString() ?? string.Empty;
            dateNamSinh.Text = dgvSinhVien.CurrentRow.Cells["NamSinh"].Value?.ToString() ?? string.Empty;
            txtSDT.Text = dgvSinhVien.CurrentRow.Cells["SDT"].Value?.ToString() ?? string.Empty;
            cbMaLop.Text = dgvSinhVien.CurrentRow.Cells["MaLop"].Value?.ToString() ?? string.Empty;
            lbTuoi.Text = dgvSinhVien.CurrentRow.Cells["Tuoi"].Value?.ToString() ?? string.Empty;

            if (dgvSinhVien.CurrentRow.Cells["GioiTinh"].Value.ToString().Trim() == "Nam")
                rdNam.Checked = true;
            else 
                rdNu.Checked = true;

            // Bật các nút Sửa, Xóa, và Bỏ Qua
            btnExit.Enabled = true;
            btnDel.Enabled = true;
            btnSkip.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            ResetValues();
            txtMaSV.Enabled = true;
            txtMaSV.Focus();

            btnAdd.Paint += Button_Paint;
            btnEdit.Paint += Button_Paint;
            btnDel.Paint += Button_Paint;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;

            // Kiểm tra mã sinh viên
            if (txtMaSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }

            // Kiểm tra tên sinh viên
            if (txtTenSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSV.Focus();
                return;
            }

            // Kiểm tra năm sinh hợp lệ
            if (dateNamSinh.Value > DateTime.Now)
            {
                MessageBox.Show("Năm sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNamSinh.Focus();
                return;
            }

            // Cập nhật tuổi tự động dựa trên năm sinh
            int tuoi = DateTime.Now.Year - dateNamSinh.Value.Year;
            if (dateNamSinh.Value > DateTime.Now.AddYears(-tuoi)) tuoi--;
            lbTuoi.Text = tuoi.ToString();

            // Kiểm tra số điện thoại
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (txtSDT.Text.Trim().Length != 10 || !txtSDT.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại của bạn không hợp lệ. Vui lòng nhập 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            // Kiểm tra mã lớp
            if (cbMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaLop.Focus();
                return;
            }

            if (rdNam.Checked == false && rdNu.Checked == false)
            {
                MessageBox.Show("Bạn hãy chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdNam.Checked == true)
                gt = "Nam";
            else 
                gt = "Nữ";

            // Kiểm tra mã lớp có tồn tại trong bảng Lop không
            sql = "SELECT MaLop FROM Lop WHERE MaLop = N'" + cbMaLop.Text.Trim() + "'";
            if (!DBConnection.CheckKey(sql))
            {
                MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaLop.Focus();
                return;
            }

            // Kiểm tra nếu mã sinh viên tồn tại
            sql = "SELECT MaSV FROM SinhVien WHERE MaSV = N'" + txtMaSV.Text.Trim() + "'";
            if (DBConnection.CheckKey(sql))
            {
                MessageBox.Show("Mã sinh viên tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }

            // Kiểm tra nếu số điện thoại bị trùng
            sql = "SELECT SDT FROM SinhVien WHERE SDT = N'" + txtSDT.Text.Trim() + "'";
            if (DBConnection.CheckKey(sql))
            {
                MessageBox.Show("Số điện thoại đã được sử dụng. Vui lòng nhập số khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            // Thêm sinh viên vào bảng SinhVien
            sql = "INSERT INTO SinhVien (MaSV, TenSV, NamSinh, SDT, MaLop, Tuoi, GioiTinh) VALUES (N'" + txtMaSV.Text.Trim() + "', N'" + txtTenSV.Text.Trim() + "', '" + dateNamSinh.Value.ToString("yyyy-MM-dd") + "', N'" + txtSDT.Text.Trim() + "', N'" + cbMaLop.Text.Trim() + "', " + tuoi + ", N'" + gt + "')";
            DBConnection.RunSQL(sql);

            // Thiết lập lại trạng thái các nút và cập nhật giao diện
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtMaSV.Enabled = false;

            LoadDataGridView(); // Tải lại dữ liệu
            ResetValues();      // Đặt lại các giá trị
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataThuVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xác nhận xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE SinhVien WHERE MaSV=N'" + txtMaSV.Text + "'";
                DBConnection.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
            btnSkip.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;

            if (dataThuVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtTenSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSV.Focus();
                return;
            }

            if (dateNamSinh.Value == null)
            {
                MessageBox.Show("Bạn hãy chọn năm sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNamSinh.Focus();
                return;
            }

            if (txtSDT.Text.Trim().Length == 0 || txtSDT.Text.Trim().Length != 10 || !txtSDT.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (cbMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaLop.Focus();
                return;
            }

            if (rdNam.Checked == true)
                gt = "Nam";
            else 
                gt = "Nữ";

            // Kiểm tra mã lớp có tồn tại trong bảng Lop không
            sql = "SELECT MaLop FROM Lop WHERE MaLop = N'" + cbMaLop.Text.Trim() + "'";
            if (!DBConnection.CheckKey(sql))
            {
                MessageBox.Show("Mã lớp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaLop.Focus();
                return;
            }

            
            // Kiểm tra nếu số điện thoại bị trùng
            sql = "SELECT SDT, MaSV FROM SinhVien WHERE SDT = N'" + txtSDT.Text.Trim() + "' AND MaSV != N'" + txtMaSV.Text.Trim() + "'";
            if (DBConnection.CheckKey(sql))
            {
                MessageBox.Show("Số điện thoại đã được sử dụng. Vui lòng nhập số khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            // Câu lệnh UPDATE với các trường cần thiết
            sql = "UPDATE SinhVien SET TenSV = N'" + txtTenSV.Text.Trim() +
                              "', NamSinh = N'" + dateNamSinh.Value.ToString("yyyy-MM-dd") +
                              "', SDT = N'" + txtSDT.Text.Trim() +
                              "', MaLop = N'" + cbMaLop.Text.Trim() +
                              "', Tuoi = N'" + lbTuoi.Text.Trim() +
                              "', GioiTinh = N'" + gt +
                              "' WHERE MaSV = N'" + txtMaSV.Text.Trim() + "'";

            DBConnection.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSkip.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtMaSV.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xác nhận đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void ResetValues()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            dateNamSinh.Text = "";
            txtSDT.Text = "";
            cbMaLop.Text = "";
            lbTuoi.Text = "";
            rdNu.Checked = false;
            rdNam.Checked = false;
        }
        private void LoadMaLopComboBox()
        {
            string sql = "SELECT MaLop FROM Lop";
            DataTable dtMaLop = DBConnection.GetDataToTable(sql);

            cbMaLop.DataSource = dtMaLop;
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.ValueMember = "MaLop";
            cbMaLop.SelectedIndex = -1; // Đặt mặc định không chọn giá trị nào
        }

        private void dateNamSinh_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dateNamSinh.Value.Year;
            if (dateNamSinh.Value > DateTime.Now.AddYears(-age)) age--;
            lbTuoi.Text = age.ToString();
        }

        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;

            if (button != null && !button.Enabled)
            {
                // Vẽ nền tùy chỉnh
                using (SolidBrush backBrush = new SolidBrush(Color.LightGray))
                {
                    e.Graphics.FillRectangle(backBrush, button.ClientRectangle);
                }

                // Vẽ chữ tùy chỉnh
                TextRenderer.DrawText(e.Graphics, button.Text, button.Font,
                    button.ClientRectangle, Color.DarkGray, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void DgvSinhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSinhVien.Columns[e.ColumnIndex].HeaderText == "Năm sinh" && e.Value != null)
            {
                DateTime dateValue;
                if (DateTime.TryParse(e.Value.ToString(), out dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Định dạng ngày theo kiểu "dd/MM/yyyy"
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
