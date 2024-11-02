using QL_Thu_Vien.UserControls;
using System.Data;
using System.Text.RegularExpressions;

namespace QL_Thu_Vien
{
    public partial class fphieumuon : Form
    {
        DataTable dataThuVien;

        public fphieumuon()
        {
            InitializeComponent();
            LoadComboBoxData();
            LoadSinhVienDaMuon();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaPhieu, MaSV, MaSach, SoLuongMuon, NgayMuon, NgayTra FROM Phieu";
            dataThuVien = DBConnection.GetDataToTable(sql);
            dgvMuon.DataSource = dataThuVien;

            dgvMuon.Columns[0].HeaderText = "Mã phiếu";
            dgvMuon.Columns[1].HeaderText = "Mã sinh viên";
            dgvMuon.Columns[2].HeaderText = "Mã sách";
            dgvMuon.Columns[3].HeaderText = "Số lượng";
            dgvMuon.Columns[4].HeaderText = "Ngày mượn";
            dgvMuon.Columns[5].HeaderText = "Ngày trả";

            dgvMuon.Columns[0].Width = 170;
            dgvMuon.Columns[1].Width = 200;
            dgvMuon.Columns[2].Width = 200;
            dgvMuon.Columns[3].Width = 200;
            dgvMuon.Columns[4].Width = 200;
            dgvMuon.Columns[5].Width = 250;

            dgvMuon.AllowUserToAddRows = false;
            dgvMuon.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvMuon.CellFormatting += DgvPhieuMuon_CellFormatting;
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(cbMaSV.Text) || string.IsNullOrEmpty(cbMaSach.Text) || string.IsNullOrEmpty(txtSL.Text) || dateNgayMuon.Value == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số lượng sách mượn có phải là số nguyên không
            int soLuongMuon;
            if (!int.TryParse(txtSL.Text, out soLuongMuon) || soLuongMuon <= 0)
            {
                MessageBox.Show("Số lượng mượn phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem sinh viên có tồn tại trong hệ thống không
            string checkSVSql = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = N'" + cbMaSV.Text + "'";
            DataTable dtCheckSV = DBConnection.GetDataToTable(checkSVSql);

            if (dtCheckSV.Rows.Count == 0 || Convert.ToInt32(dtCheckSV.Rows[0][0]) == 0)
            {
                MessageBox.Show("Sinh viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy số lượng sách hiện có
            string getSoLuongSachSql = "SELECT SoLuong FROM Sach WHERE MaSach = N'" + cbMaSach.Text + "'";
            DataTable dtSach = DBConnection.GetDataToTable(getSoLuongSachSql);

            // Kiểm tra số lượng sách
            if (dtSach.Rows.Count > 0)
            {
                int soLuongSachHienCo = Convert.ToInt32(dtSach.Rows[0]["SoLuong"]);

                // Kiểm tra xem số lượng mượn có vượt quá số lượng hiện có không
                if (soLuongMuon > soLuongSachHienCo)
                {
                    MessageBox.Show("Số lượng sách mượn không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem sinh viên đã trả sách chưa
                string checkMuonSql = "SELECT NgayTra FROM Phieu WHERE MaSV = N'" + cbMaSV.Text + "' AND NgayTra IS NULL";
                DataTable dtCheckMuon = DBConnection.GetDataToTable(checkMuonSql);

                // Nếu có kết quả và ngày trả là NULL, không cho phép mượn
                if (dtCheckMuon.Rows.Count > 0)
                {
                    MessageBox.Show("Sinh viên này đã có sách mượn mà chưa trả, không thể mượn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy số lượng phiếu mượn hiện có để tạo MaPhieu mới
                string countPhieuSql = "SELECT COUNT(*) FROM Phieu";
                DataTable dtCount = DBConnection.GetDataToTable(countPhieuSql);

                // Nếu có kết quả, tạo mã phiếu mới
                if (dtCount.Rows.Count > 0)
                {
                    int soPhieuHienTai = Convert.ToInt32(dtCount.Rows[0][0]);
                    string maPhieuMoi = "MP" + (soPhieuHienTai + 1).ToString();

                    // Lấy dữ liệu từ form
                    string maSV = cbMaSV.Text;
                    string maSach = cbMaSach.Text;
                    string ngayMuon = dateNgayMuon.Value.ToString("yyyy-MM-dd");

                    // Thêm phiếu mượn vào cơ sở dữ liệu
                    string insertPhieuSql = "INSERT INTO Phieu (MaPhieu, MaSV, MaSach, SoLuongMuon, NgayMuon, NgayTra) " +
                                            "VALUES (N'" + maPhieuMoi + "', N'" + maSV + "', N'" + maSach + "', " + soLuongMuon +
                                            ", '" + ngayMuon + "', NULL)"; // Ngày trả để NULL
                    DBConnection.RunSQL(insertPhieuSql);

                    // Cập nhật số lượng sách sau khi mượn
                    string updateSoLuongSachSql = "UPDATE Sach SET SoLuong = SoLuong - " + soLuongMuon + " WHERE MaSach = N'" + maSach + "'";
                    DBConnection.RunSQL(updateSoLuongSachSql);

                    MessageBox.Show("Mượn sách thành công với mã phiếu: " + maPhieuMoi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu và đặt lại các ô nhập liệu
                    LoadDataGridView();
                    ResetValues();
                }
                else
                {
                    MessageBox.Show("Không thể tạo mã phiếu mượn mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxData()
        {
            // Tải dữ liệu MaSV vào ComboBox cbMaSV
            string sqlMaSV = "SELECT MaSV FROM SinhVien";
            DataTable dtMaSV = DBConnection.GetDataToTable(sqlMaSV);

            if (dtMaSV.Rows.Count > 0)
            {
                cbMaSV.DataSource = dtMaSV;
                cbMaSV.DisplayMember = "MaSV";
                cbMaSV.ValueMember = "MaSV";
                cbMaSV.SelectedIndex = -1; // Đặt mặc định không chọn gì
            }

            // Tải dữ liệu MaSach vào ComboBox cbMaSach
            string sqlMaSach = "SELECT MaSach FROM Sach";
            DataTable dtMaSach = DBConnection.GetDataToTable(sqlMaSach);

            if (dtMaSach.Rows.Count > 0)
            {
                cbMaSach.DataSource = dtMaSach;
                cbMaSach.DisplayMember = "MaSach";
                cbMaSach.ValueMember = "MaSach";
                cbMaSach.SelectedIndex = -1; // Đặt mặc định không chọn gì
            }
        }

        private void cbMaSach_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbMaSach.Text))
            {
                // Truy vấn thông tin sách từ cơ sở dữ liệu dựa vào mã sách
                string getSachInfoSql = "SELECT TenSach, TacGia, NamXB, NhaXB,TheLoai, SoLuong FROM Sach WHERE MaSach = N'" + cbMaSach.Text + "'";
                DataTable dtSach = DBConnection.GetDataToTable(getSachInfoSql);

                // Kiểm tra nếu sách tồn tại trong cơ sở dữ liệu
                if (dtSach.Rows.Count > 0)
                {
                    // Hiển thị thông tin sách lên các Label hoặc TextBox
                    lbTenSach.Text = dtSach.Rows[0]["TenSach"].ToString();
                    lbTacGia.Text = dtSach.Rows[0]["TacGia"].ToString();
                    DateTime namXuatBan = Convert.ToDateTime(dtSach.Rows[0]["NamXB"]);
                    lbNamXB.Text = namXuatBan.ToString("dd/MM/yyyy");
                    lbNhaXB.Text = dtSach.Rows[0]["NhaXB"].ToString();
                    lbTheLoai.Text = dtSach.Rows[0]["TheLoai"].ToString();
                    lbSoLuong.Text = dtSach.Rows[0]["SoLuong"].ToString();
                }
                else
                {
                    // Nếu mã sách không tồn tại, xóa các thông tin hiện tại
                    lbTenSach.Text = "";
                    lbTacGia.Text = "";
                    lbNamXB.Text = "";
                    lbNhaXB.Text = "";
                    lbTheLoai.Text = "";
                    lbSoLuong.Text = "";
                }
            }
            else
            {
                // Nếu TextBox mã sách trống, xóa thông tin các Label
                lbTenSach.Text = "";
                lbTacGia.Text = "";
                lbNamXB.Text = "";
                lbNhaXB.Text = "";
                lbTheLoai.Text = "";
                lbSoLuong.Text = "";
            }
        }

        private void ResetValues()
        {
            cbMaSach.Text = "";
            cbMaSV.Text = "";
            txtSL.Text = "";
            dateNgayMuon.Value = DateTime.Now;
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            // Lấy mã sinh viên từ ComboBox
            string maSV = cbMaSVMuon.Text;

            // Kiểm tra mã sinh viên không trống
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần trả sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem sinh viên có tồn tại trong hệ thống không
            string checkSVSql = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = N'" + maSV + "'";
            DataTable dtCheckSV = DBConnection.GetDataToTable(checkSVSql);

            if (dtCheckSV.Rows.Count == 0 || Convert.ToInt32(dtCheckSV.Rows[0][0]) == 0)
            {
                MessageBox.Show("Sinh viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem sinh viên có phiếu mượn nào chưa trả không
            string checkPhieuSql = "SELECT * FROM Phieu WHERE MaSV = N'" + maSV + "' AND NgayTra IS NULL";
            DataTable dtPhieu = DBConnection.GetDataToTable(checkPhieuSql);

            if (dtPhieu.Rows.Count > 0)
            {
                // Nếu có phiếu mượn chưa trả, lấy mã phiếu và mã sách
                string maPhieu = dtPhieu.Rows[0]["MaPhieu"].ToString();
                string maSach = dtPhieu.Rows[0]["MaSach"].ToString();
                int soLuongMuon = Convert.ToInt32(dtPhieu.Rows[0]["SoLuongMuon"]);

                // Cập nhật ngày trả vào phiếu
                string ngayTra = DateTime.Now.ToString("yyyy-MM-dd");
                string updatePhieuSql = "UPDATE Phieu SET NgayTra = '" + ngayTra + "' WHERE MaPhieu = N'" + maPhieu + "'";
                DBConnection.RunSQL(updatePhieuSql);

                // Cập nhật lại số lượng sách trong bảng Sach
                string updateSoLuongSachSql = "UPDATE Sach SET SoLuong = SoLuong + " + soLuongMuon + " WHERE MaSach = N'" + maSach + "'";
                DBConnection.RunSQL(updateSoLuongSachSql);

                MessageBox.Show("Trả sách thành công cho sinh viên: " + maSV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu và đặt lại các ô nhập liệu
                LoadDataGridView();
                ResetValues();
            }
            else
            {
                MessageBox.Show("Sinh viên không có phiếu mượn nào cần trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fphieumuon_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void cbMaSVMuon_TextChanged(object sender, EventArgs e)
        {
            // Lấy mã sinh viên từ ComboBox
            string maSV = cbMaSVMuon.Text;
            if (!string.IsNullOrEmpty(maSV))
            {
                // Lấy thông tin phiếu mượn và sách mượn của sinh viên
                string getBorrowedRecordsSql = "SELECT Phieu.MaPhieu, Phieu.NgayMuon, Phieu.NgayTra, Phieu.SoLuongMuon, " +
                                               "Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.NamXB, Sach.NhaXB, Sach.TheLoai, Sach.SoLuong " +
                                               "FROM Phieu " +
                                               "JOIN Sach ON Phieu.MaSach = Sach.MaSach " +
                                               "WHERE Phieu.MaSV = N'" + maSV + "'";
                DataTable dtBorrowedRecords = DBConnection.GetDataToTable(getBorrowedRecordsSql);

                if (dtBorrowedRecords.Rows.Count > 0)
                {
                    // Hiển thị thông tin phiếu mượn và sách mượn (có thể dùng DataGridView hoặc các Label khác)
                    foreach (DataRow row in dtBorrowedRecords.Rows)
                    {
                        lbNgayMuon.Text = Convert.ToDateTime(row["NgayMuon"]).ToString("dd/MM/yyyy");
                        lbSL.Text = row["SoLuongMuon"].ToString();
                        lblMaSach.Text = row["MaSach"].ToString();
                        lblTenSach.Text = row["TenSach"].ToString();
                        lblTacGia.Text = row["TacGia"].ToString();
                        lblNamXB.Text = Convert.ToDateTime(row["NamXB"]).ToString("yyyy");
                        lblNhaXB.Text = row["NhaXB"].ToString();
                        lblTheLoai.Text = row["TheLoai"].ToString();
                        lblSL.Text = row["SoLuong"].ToString();
                    }
                }
                else
                {
                    // Nếu không có phiếu mượn nào, xóa nội dung các Label
                    lbNgayMuon.Text = string.Empty;
                    lbSL.Text = string.Empty;
                    lblMaSach.Text = string.Empty;
                    lblTenSach.Text = string.Empty;
                    lblTacGia.Text = string.Empty;
                    lblNamXB.Text = string.Empty;
                    lblNhaXB.Text = string.Empty;
                    lblTheLoai.Text = string.Empty;
                }
            }
        }

        private void LoadSinhVienDaMuon()
        {
            // Truy vấn lấy các sinh viên đã mượn sách
            string sqlSinhVienDaMuon = "SELECT DISTINCT SinhVien.MaSV, SinhVien.TenSV " +
                                       "FROM SinhVien " +
                                       "JOIN Phieu ON SinhVien.MaSV = Phieu.MaSV";

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable dtSinhVienDaMuon = DBConnection.GetDataToTable(sqlSinhVienDaMuon);

            if (dtSinhVienDaMuon.Rows.Count > 0)
            {
                cbMaSVMuon.DataSource = dtSinhVienDaMuon;
                cbMaSVMuon.DisplayMember = "MaSV"; // Hiển thị MaSV
                cbMaSVMuon.ValueMember = "MaSV"; // Giá trị là MaSV
                cbMaSVMuon.SelectedIndex = -1; // Đặt mặc định không chọn gì
            }
            else
            {
                MessageBox.Show("Hiện không có sinh viên nào đã mượn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Lấy đối tượng nút được click
            Button btn = sender as Button;

            if (btn.Name == "btnHuyMuon")
            {
                this.Close();
            }
            else if (btn.Name == "btnHuyTra")
            {
                this.Close();
            }
        }

        private void DgvPhieuMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMuon.Columns[e.ColumnIndex].HeaderText == "Ngày mượn" && e.Value != null)
            {
                DateTime dateValue;
                if (DateTime.TryParse(e.Value.ToString(), out dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Định dạng ngày theo kiểu "dd/MM/yyyy"
                    e.FormattingApplied = true;
                }
            }

            // Định dạng cột "Ngày trả"
            if (dgvMuon.Columns[e.ColumnIndex].HeaderText == "Ngày trả" && e.Value != null)
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
