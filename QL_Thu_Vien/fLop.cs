using System.Data;

namespace QL_Thu_Vien
{
    public partial class fLop : Form
    {
        DataTable dataThuVien;

        public fLop()
        {
            InitializeComponent();
        }

        private void fLop_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            txtMaLop.Enabled = false;
            LoadDataGridView();


            btnSave.Paint += Button_Paint;
            btnSkip.Paint += Button_Paint;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            ResetValues();
            txtMaLop.Enabled = true;
            txtMaLop.Focus();


            btnAdd.Paint += Button_Paint;
            btnEdit.Paint += Button_Paint;
            btnDel.Paint += Button_Paint;
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Lop";
            dataThuVien = DBConnection.GetDataToTable(sql);
            dgvDSLop.DataSource = dataThuVien;
            dgvDSLop.Columns[0].HeaderText = "Mã lớp";
            dgvDSLop.Columns[1].HeaderText = "Tên khoa";
            dgvDSLop.Columns[2].HeaderText = "Tên lớp";

            // Tăng kích thước mỗi cột
            dgvDSLop.Columns[0].Width = 100; // Kích thước cột "Mã lớp"
            dgvDSLop.Columns[1].Width = 350; // Kích thước cột "Tên lớp"
            dgvDSLop.Columns[2].Width = 300; // Kích thước cột "Tên khoa"

            dgvDSLop.AllowUserToAddRows = false;
            dgvDSLop.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvDSLop_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có đang ở chế độ "Thêm mới" hay không
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLop.Focus();
                return;
            }

            // Kiểm tra xem có dữ liệu trong DataGridView hay không
            if (dgvDSLop.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra nếu không có hàng nào được chọn
            if (dgvDSLop.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dữ liệu từ hàng hiện tại và gán vào các TextBox
            txtMaLop.Text = dgvDSLop.CurrentRow.Cells["MaLop"].Value?.ToString() ?? string.Empty;
            txtTenLop.Text = dgvDSLop.CurrentRow.Cells["TenLop"].Value?.ToString() ?? string.Empty;
            txtKhoa.Text = dgvDSLop.CurrentRow.Cells["TenKhoa"].Value?.ToString() ?? string.Empty;

            // Bật các nút Sửa, Xóa, và Bỏ Qua
            btnExit.Enabled = true;
            btnDel.Enabled = true;
            btnSkip.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataThuVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xác nhận xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Lop WHERE MaLop=N'" + txtMaLop.Text + "'";
                DBConnection.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;

            if (dataThuVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoa.Focus();
                return;
            }

            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            // Câu lệnh UPDATE với các trường cần thiết
            sql = "UPDATE Lop SET TenLop = N'" + txtTenLop.Text.Trim() +
                              "', TenKhoa = N'" + txtKhoa.Text.Trim() +
                              "' WHERE MaLop = N'" + txtMaLop.Text.Trim() + "'";

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
            txtMaLop.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            // Kiểm tra nhập liệu
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            if (txtKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoa.Focus();
                return;
            }
            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            // Kiểm tra mã lớp đã tồn tại trong CSDL
            sql = "SELECT MaLop FROM Lop WHERE MaLop = N'" + txtMaLop.Text.Trim() + "'";
            if (DBConnection.CheckKey(sql))
            {
                MessageBox.Show("Mã lớp đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                txtMaLop.Text = "";  // Xóa ô mã lớp để nhập lại
                return;
            }

            // Thực hiện câu lệnh SQL thêm lớp
            sql = "INSERT INTO Lop (MaLop, TenKhoa, TenLop) " +
                  "VALUES (N'" + txtMaLop.Text.Trim() + "', N'" + txtKhoa.Text.Trim() + "', N'" + txtTenLop.Text.Trim() + "')";

            try
            {
                DBConnection.RunSQL(sql);
                MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu và reset form
                LoadDataGridView();
                ResetValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kích hoạt các nút điều hướng và cập nhật trạng thái
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;

            txtMaLop.Enabled = false; // Vô hiệu hóa ô mã lớp sau khi lưu
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
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtKhoa.Text = "";
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
    }
}
