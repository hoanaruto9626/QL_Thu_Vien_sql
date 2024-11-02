using System.Data.SqlClient;

namespace QL_Thu_Vien
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu người dùng nhập
            if (txtTenDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            DBConnection.Connect(); // Mở kết nối tới cơ sở dữ liệu
            string sql = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";
            using (SqlCommand cmd = new SqlCommand(sql, DBConnection.conn))
            {
                cmd.Parameters.AddWithValue("@username", txtTenDN.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtMatKhau.Text.Trim());

                try
                {
                    object resultObj = cmd.ExecuteScalar();
                    if (resultObj != null)
                    {
                        int result = Convert.ToInt32(resultObj);
                        if (result == 1)
                        {
                            // Đăng nhập thành công
                            fMenu main = new fMenu(this);
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.Disconnect(); // Ngắt kết nối sau khi hoàn tất
                }
            }
        }
    }
}