using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab04_Basic_Command
{
    // Phần C: gom 2 thao tác đã học ở chủ đề 4 để các form bài tập không phải lặp lại
    internal static class DataProvider
    {
        const string connectionString = "server=localhost\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";

        // SELECT: đổ kết quả vào DataTable bằng phương thức Fill của DataAdapter
        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi CSDL: " + ex.Message);
            }
            return dt;
        }

        // INSERT, UPDATE, DELETE: trả về số dòng bị ảnh hưởng, lỗi thì báo và trả về 0
        public static int Execute(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = query;
            try
            {
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi CSDL: " + ex.Message);
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
