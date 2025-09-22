using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    internal class MyDataTable : DataTable
    {
        // Biến toàn cục
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private SqlCommand command;

        // Lấy chuỗi kết nối
        public string ConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                ["Server"] = "WINDOWS-10\\SQLEXPRESS",
                ["Database"] = "QL_QUANCafe_LH",
                ["Integrated Security"] = "True"
            };
            return builder.ConnectionString;
        }

        // Mở kết nối
        public bool OpenConnection()
        {
            try
            {
                if (connection == null)
                    connection = new SqlConnection(ConnectionString());

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở kết nối cơ sở dữ liệu.\nLỗi: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Thực thi câu lệnh Select và điền vào DataTable


        public void Fill(SqlCommand selectCommand)
        {
            if (selectCommand == null) throw new ArgumentNullException(nameof(selectCommand));

            try
            {
                command = selectCommand;
                command.Connection = connection;

                adapter = new SqlDataAdapter(command);

                this.Clear();  // Xóa các dòng cũ trong DataTable trước khi điền dữ liệu mới
                adapter.Fill(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể thực thi câu lệnh SQL này!\nLỗi: {ex.Message}", "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thực thi câu lệnh Insert, Update, Delete
        public int Update(SqlCommand insertUpdateDeleteCommand)
        {
            int result = 0;
            SqlTransaction transaction = null;

            try
            {
                if (connection.State != ConnectionState.Open) OpenConnection();

                transaction = connection.BeginTransaction();
                insertUpdateDeleteCommand.Connection = connection;
                insertUpdateDeleteCommand.Transaction = transaction;

                result = insertUpdateDeleteCommand.ExecuteNonQuery();
                this.AcceptChanges();  // Xác nhận thay đổi trong DataTable

                transaction.Commit();  // Cam kết giao dịch
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();  // Quay lại nếu có lỗi

                MessageBox.Show($"Không thể thực thi câu lệnh SQL này!\nLỗi: {ex.Message}", "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        // Thực thi câu lệnh truy vấn SQL trả về DataTable
        public DataTable ExecuteQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Truy vấn không hợp lệ.");

            DataTable dataTable = new DataTable();

            try
            {
                if (connection == null || connection.State != ConnectionState.Open)
                    OpenConnection();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực thi truy vấn: {ex.Message}", "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        // Đảm bảo kết nối được đóng khi không còn sử dụng
        public void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
