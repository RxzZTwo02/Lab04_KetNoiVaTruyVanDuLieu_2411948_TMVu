using System.Data;
using System.Windows.Forms;

namespace Lab04_Basic_Command
{
    // Bài tập 2: các món đã mua trong một hóa đơn (bài tập 4 cũng dùng lại)
    public partial class BillDetailsForm : Form
    {
        public BillDetailsForm()
        {
            InitializeComponent();
        }

        public static DataTable GetBillDetails(int billID)
        {
            return DataProvider.GetData(
                "SELECT f.Name AS [Tên món], f.Unit AS [Đơn vị tính], f.Price AS [Đơn giá], " +
                "d.Quantity AS [Số lượng], f.Price * d.Quantity AS [Thành tiền] " +
                "FROM BillDetails d JOIN Food f ON d.FoodID = f.ID " +
                "WHERE d.InvoiceID = " + billID);
        }

        public void LoadBillDetails(int billID)
        {
            this.Text = "Chi tiết hóa đơn số " + billID;
            dgvBillDetails.DataSource = GetBillDetails(billID);
        }
    }
}
