using System.Data;
using System.Data.SqlClient;

namespace QL_Thu_Vien
{
    public class DBConnection
    {
        public static SqlConnection conn;

        // Phương thức kết nối tới cơ sở dữ liệu
        public static void Connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-K24CB9N\SQLEXPRESS;Initial Catalog=ThuVien;Integrated Security=True;";
            conn.Open();
        }

        // Phương thức ngắt kết nối cơ sở dữ liệu
        public static void Disconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            if (conn == null)
            {
                Connect(); // Mở kết nối nếu chưa có
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open(); // Đảm bảo kết nối đã mở
            }

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt); // Thực hiện truy vấn và điền dữ liệu vào DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, không thể xoá...\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            int count = Convert.ToInt32(GetFieldValues("Select count(MaPhieu) from Phieu")) + 1;
            return tiento + count.ToString();
        }

        internal static bool GetValue(string checkMuonSql)
        {
            throw new NotImplementedException();
        }
    }
}
