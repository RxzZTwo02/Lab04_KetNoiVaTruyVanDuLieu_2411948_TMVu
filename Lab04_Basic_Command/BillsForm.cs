using System;
using System.Data;
using System.Windows.Forms;

namespace Lab04_Basic_Command
{
    // Bài tập 2: danh sách hóa đơn bán trong một khoảng thời gian
    public partial class BillsForm : Form
    {
        public BillsForm()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // Định dạng yyyyMMdd để SQL Server luôn hiểu đúng ngày, tháng
            string fromDate = dtpFrom.Value.ToString("yyyyMMdd");
            string toDate = dtpTo.Value.ToString("yyyyMMdd");

            // Discount lưu tỉ lệ giảm (0.05 = 5%) nên số tiền giảm = Amount * Discount
            string query = "SELECT ID AS [Mã HĐ], Name AS [Tên hóa đơn], TableID AS [Bàn], CheckoutDate AS [Ngày lập], " +
                           "Amount AS [Tiền chưa giảm], Amount * ISNULL(Discount, 0) AS [Giảm giá], " +
                           "Amount - Amount * ISNULL(Discount, 0) AS [Thực thu] " +
                           "FROM Bills WHERE CAST(CheckoutDate AS DATE) BETWEEN '" + fromDate + "' AND '" + toDate + "'";
            DataTable dt = DataProvider.GetData(query);
            dgvBills.DataSource = dt;

            // Cộng dồn tiền của các hóa đơn vừa lấy
            double amount = 0, discount = 0;
            foreach (DataRow row in dt.Rows)
            {
                amount += Convert.ToDouble(row["Tiền chưa giảm"]);
                discount += Convert.ToDouble(row["Giảm giá"]);
            }

            lblAmount.Text = "Tổng tiền chưa giảm giá: " + amount.ToString("N0");
            lblDiscount.Text = "Tổng tiền giảm giá: " + discount.ToString("N0");
            lblTotal.Text = "Thực thu: " + (amount - discount).ToString("N0");
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nhấp đôi vào dòng tiêu đề thì bỏ qua
            if (e.RowIndex < 0) return;

            int billID = Convert.ToInt32(dgvBills.Rows[e.RowIndex].Cells["Mã HĐ"].Value);

            BillDetailsForm billDetailsForm = new BillDetailsForm();
            billDetailsForm.Show(this);
            billDetailsForm.LoadBillDetails(billID);
        }
    }
}
