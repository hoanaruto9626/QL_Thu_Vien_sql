using System.Data;

namespace QL_Thu_Vien
{
    public partial class fDauSach : Form
    {
        DataTable dataThuVien;

        public fDauSach()
        {
            InitializeComponent();
        }

        private void fDauSach_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaSach.Enabled = false;
            LoadDataGridView();

            btnLuu.Paint += Button_Paint;
            btnBoQua.Paint += Button_Paint;
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Sach";
            dataThuVien = DBConnection.GetDataToTable(sql);
            dgvSach.DataSource = dataThuVien;
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[2].HeaderText = "Tác giả";
            dgvSach.Columns[3].HeaderText = "Năm XB";
            dgvSach.Columns[4].HeaderText = "Nhà XB";
            dgvSach.Columns[5].HeaderText = "Thể loại";
            dgvSach.Columns[6].HeaderText = "Số lượng";

            dgvSach.Columns[0].Width = 150;
            dgvSach.Columns[1].Width = 150;
            dgvSach.Columns[2].Width = 150;
            dgvSach.Columns[3].Width = 150;
            dgvSach.Columns[4].Width = 150;
            dgvSach.Columns[5].Width = 150;
            dgvSach.Columns[6].Width = 100;

            dgvSach.AllowUserToAddRows = false;
            dgvSach.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvSach.CellFormatting += DgvSach_CellFormatting;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            ResetValues();
            txtMaSach.Enabled = true;
            txtMaSach.Focus();

            btnThem.Paint += Button_Paint;
            btnSua.Paint += Button_Paint;
            btnXoa.Paint += Button_Paint;
        }

        private void dgvSach_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có đang ở chế độ "Thêm mới" hay không
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                return;
            }

            // Kiểm tra xem có dữ liệu trong DataGridView hay không
            if (dgvSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra nếu không có hàng nào được chọn
            if (dgvSach.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dữ liệu từ hàng hiện tại và gán vào các TextBox
            txtMaSach.Text = dgvSach.CurrentRow.Cells["MaSach"].Value?.ToString() ?? string.Empty;
            txtTenSach.Text = dgvSach.CurrentRow.Cells["TenSach"].Value?.ToString() ?? string.Empty;
            txtTacGia.Text = dgvSach.CurrentRow.Cells["TacGia"].Value?.ToString() ?? string.Empty;

            // Xử lý dữ liệu NamXB nếu tồn tại
            if (DateTime.TryParse(dgvSach.CurrentRow.Cells["NamXB"].Value?.ToString(), out DateTime namXB))
            {
                dateNamXB.Value = namXB;
            }
            else
            {
                dateNamXB.Value = DateTime.Today; // Giá trị mặc định nếu không có dữ liệu hợp lệ
            }

            txtNhaXB.Text = dgvSach.CurrentRow.Cells["NhaXB"].Value?.ToString() ?? string.Empty;
            txtTheLoai.Text = dgvSach.CurrentRow.Cells["TheLoai"].Value?.ToString() ?? string.Empty;

            // Xử lý dữ liệu SoLuong nếu tồn tại và hợp lệ
            if (int.TryParse(dgvSach.CurrentRow.Cells["SoLuong"].Value?.ToString(), out int soLuong))
            {
                txtSoLuong.Text = soLuong.ToString();
            }
            else
            {
                txtSoLuong.Text = "0"; // Giá trị mặc định nếu không có dữ liệu hợp lệ
            }

            // Bật các nút Sửa, Xóa, và Bỏ Qua
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataThuVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn cuốn sách nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xác nhận xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Sach WHERE MaSach=N'" + txtMaSach.Text + "'";
                DBConnection.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql;

            if (dataThuVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtTenSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return;
            }

            if (txtTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTacGia.Focus();
                return;
            }

            if (dateNamXB.Value > DateTime.Now)
            {
                MessageBox.Show("Năm xuất bản không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNamXB.Focus();
                return;
            }

            if (txtNhaXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập nhà xuất bản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhaXB.Focus();
                return;
            }

            if (txtTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập thể loại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTheLoai.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là một số nguyên hợp lệ và lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            // Câu lệnh UPDATE với các trường cần thiết
            sql = "UPDATE Sach SET TenSach = N'" + txtTenSach.Text.Trim() +
                  "', TacGia = N'" + txtTacGia.Text.Trim() +
                  "', NamXB = '" + dateNamXB.Value.ToString("yyyy-MM-dd") +
                  "', NhaXB = N'" + txtNhaXB.Text.Trim() +
                  "', TheLoai = N'" + txtTheLoai.Text.Trim() +
                  "', SoLuong = " + soLuong +
                  " WHERE MaSach = N'" + txtMaSach.Text.Trim() + "'";

            DBConnection.RunSQL(sql); // Thực thi câu lệnh SQL
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void ResetValues()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            dateNamXB.Value = DateTime.Today; // Đặt ngày xuất bản mặc định là ngày hiện tại
            txtNhaXB.Text = "";
            txtTheLoai.Text = "";
            txtSoLuong.Text = "0"; // Đặt số lượng mặc định là 0
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaSach.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            // Kiểm tra mã sách
            if (txtMaSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập mã sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                return;
            }
            // Kiểm tra tên sách
            if (txtTenSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return;
            }
            // Kiểm tra tác giả
            if (txtTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTacGia.Focus();
                return;
            }
            // Kiểm tra năm xuất bản
            if (dateNamXB.Value > DateTime.Now)
            {
                MessageBox.Show("Năm xuất bản không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNamXB.Focus();
                return;
            }
            // Kiểm tra nhà xuất bản
            if (txtNhaXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập nhà xuất bản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhaXB.Focus();
                return;
            }
            // Kiểm tra thể loại
            if (txtTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập thể loại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTheLoai.Focus();
                return;
            }
            // Kiểm tra số lượng
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là một số nguyên hợp lệ và lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            // Kiểm tra mã sách đã tồn tại
            sql = "SELECT MaSach FROM Sach WHERE MaSach=N'" + txtMaSach.Text.Trim() + "'";
            if (DBConnection.CheckKey(sql))
            {
                MessageBox.Show("Mã sách đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                txtMaSach.Text = "";
                return;
            }

            // Thêm sách vào cơ sở dữ liệu
            sql = "INSERT INTO Sach (MaSach, TenSach, TacGia, NamXB, NhaXB, TheLoai, SoLuong) " +
                  "VALUES (N'" + txtMaSach.Text.Trim() + "', N'" + txtTenSach.Text.Trim() + "', N'" +
                  txtTacGia.Text.Trim() + "', '" + dateNamXB.Value.ToString("yyyy-MM-dd") + "', N'" +
                  txtNhaXB.Text.Trim() + "', N'" + txtTheLoai.Text.Trim() + "', " + soLuong + ")";

            try
            {
                DBConnection.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;

            txtMaSach.Enabled = false; // Vô hiệu hóa ô mã sách sau khi lưu
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có chọn dòng nào trong DataGridView không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                // Gán mã sách của dòng được chọn vào ô txtMaSach
                //txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtMaSach.Text = dgvSach.CurrentRow.Cells["MaSach"].Value?.ToString() ?? string.Empty;
                txtTenSach.Text = dgvSach.CurrentRow.Cells["TenSach"].Value?.ToString() ?? string.Empty;
                txtTacGia.Text = dgvSach.CurrentRow.Cells["TacGia"].Value?.ToString() ?? string.Empty;
                dateNamXB.Value = dgvSach.CurrentRow.Cells["NamXB"].Value != null ? Convert.ToDateTime(dgvSach.CurrentRow.Cells["NamXB"].Value) : DateTime.Now;
                txtNhaXB.Text = dgvSach.CurrentRow.Cells["NhaXB"].Value?.ToString() ?? string.Empty;
                txtTheLoai.Text = dgvSach.CurrentRow.Cells["TheLoai"].Value?.ToString() ?? string.Empty;
                txtSoLuong.Text = dgvSach.CurrentRow.Cells["SoLuong"].Value?.ToString() ?? string.Empty;

            }
        }

        private void DgvSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSach.Columns[e.ColumnIndex].HeaderText == "Năm XB" && e.Value != null)
            {
                DateTime dateValue;
                if (DateTime.TryParse(e.Value.ToString(), out dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Định dạng ngày theo kiểu "dd/MM/yyyy"
                    e.FormattingApplied = true;
                }
            }
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
