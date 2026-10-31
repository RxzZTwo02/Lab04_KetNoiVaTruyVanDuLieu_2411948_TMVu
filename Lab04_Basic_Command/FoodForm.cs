using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Basic_Command
{
    public partial class FoodForm : Form
    {
        // Bài tập 1: nhớ nhóm đang xem để tải lại sau khi lưu
        int categoryID;

        public FoodForm()
        {
            InitializeComponent();
        }

        // 5. Lấy dữ liệu bằng phương thức Fill của DataAdapter
        public void LoadFood(int categoryID)
        {
            this.categoryID = categoryID;

            // Tạo đối tượng kết nối
            string connectionString = "server=localhost\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            // Gán tên nhóm sản phẩm cho tiêu đề
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;

            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

            // Tạo đối tượng DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            // Tạo DataTable để chứa dữ liệu
            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            // Bài tập 1: món thêm mới trên lưới mặc định thuộc nhóm đang xem
            dt.Columns["FoodCategoryID"].DefaultValue = categoryID;

            // Hiển thị danh sách món ăn lên Form
            dgvFood.DataSource = dt;

            // Đóng kết nối và giải phóng bộ nhớ
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        // Bài tập 1: lưu các dòng thêm mới hoặc đã sửa trên dgvFood vào bảng Food
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFood.Rows)
            {
                // Bỏ qua dòng trống ở cuối lưới
                if (row.IsNewRow) continue;

                string id = Convert.ToString(row.Cells["colID"].Value);
                string name = Convert.ToString(row.Cells["colName"].Value);
                string unit = Convert.ToString(row.Cells["colUnit"].Value);
                string catID = Convert.ToString(row.Cells["colFoodCategoryID"].Value);
                string price = Convert.ToString(row.Cells["colPrice"].Value);
                string notes = Convert.ToString(row.Cells["colNotes"].Value);

                string query;
                if (id == "")   // chưa có mã món => món mới
                    query = "INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes) " +
                            "VALUES (N'" + name + "', N'" + unit + "', " + catID + ", " + price + ", N'" + notes + "')";
                else
                    query = "UPDATE Food SET Name = N'" + name + "', Unit = N'" + unit +
                            "', FoodCategoryID = " + catID + ", Price = " + price +
                            ", Notes = N'" + notes + "' WHERE ID = " + id;

                // ponytail: lưu lại mọi dòng kể cả dòng không đổi, đủ nhanh với vài chục món
                // Gặp lỗi thì dừng, giữ nguyên dữ liệu trên lưới để sửa lại
                if (DataProvider.Execute(query) == 0) return;
            }

            MessageBox.Show("Lưu danh sách món ăn thành công");

            // Tải lại để món mới có mã món
            LoadFood(categoryID);
        }

        // Bài tập 1: xóa dòng đang chọn trên dgvFood
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFood.CurrentRow;
            if (row == null || row.IsNewRow) return;

            if (MessageBox.Show("Xóa món ăn đang chọn?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            // Món đã có trong CSDL thì xóa trong bảng Food trước
            string id = Convert.ToString(row.Cells["colID"].Value);
            if (id != "")
            {
                if (DataProvider.Execute("DELETE FROM Food WHERE ID = " + id) == 0) return;
            }

            dgvFood.Rows.Remove(row);
        }
    }
}
