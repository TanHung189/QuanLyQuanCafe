using QuanLyQuanCaPhe;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace QuanLyQuanCaPhe
{
    public partial class GiaoDien_ThongTinCuaHang : Form
    {
        private MyDataTable myDataTable;

        public GiaoDien_ThongTinCuaHang()
        {
            InitializeComponent();
            myDataTable = new MyDataTable();
        }

        private void GiaoDien_ThongTinCuaHang_Load(object sender, EventArgs e)
        {
            try
            {
        
                string query = "SELECT TOP 1 StoreID, StoreName, Address, PhoneNumber, Notes FROM ThongTinCuaHang";

        
                DataTable data = myDataTable.ExecuteQuery(query);

                if (data.Rows.Count > 0)
                {
                    var row = data.Rows[0];
                    txtMaCuaHang.Text = row["StoreID"].ToString();
                    txtTenCuaHang.Text = row["StoreName"].ToString();
                    txtDiaChi.Text = row["Address"].ToString();
                    txtDienThoai.Text = row["PhoneNumber"].ToString();
                    txtGhiChu.Text = row["Notes"].ToString();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (ValidateInput() == false)
                {
                    return;
                }

      
                string query = @"
                    UPDATE ThongTinCuaHang
                    SET StoreName = @StoreName, Address = @Address, PhoneNumber = @PhoneNumber, Notes = @Notes
                    WHERE StoreID = @StoreID";

       
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@StoreID", txtMaCuaHang.Text.Trim());
                command.Parameters.AddWithValue("@StoreName", txtTenCuaHang.Text.Trim());
                command.Parameters.AddWithValue("@Address", txtDiaChi.Text.Trim());
                command.Parameters.AddWithValue("@PhoneNumber", txtDienThoai.Text.Trim());
                command.Parameters.AddWithValue("@Notes", txtGhiChu.Text.Trim());

        
                int rowsAffected = myDataTable.Update(command);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào được thực hiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaCuaHang.Text) ||
                string.IsNullOrWhiteSpace(txtTenCuaHang.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!long.TryParse(txtDienThoai.Text, out _))
            {
                MessageBox.Show("Số điện thoại phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnThoatThongTin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
