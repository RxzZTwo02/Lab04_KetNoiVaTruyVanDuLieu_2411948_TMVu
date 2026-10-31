using System;
using System.Data;
using System.Windows.Forms;

namespace Lab04_Basic_Command
{
    // Bài tập 4: nhật ký hóa đơn của một bàn
    public partial class TableBillLogForm : Form
    {
        public TableBillLogForm()
        {
            InitializeComponent();
        }

        public void LoadBillLog(int tableID)
        {
            this.Text = "Nhật ký hóa đơn của bàn số " + tableID;

            // Tax và Discount lưu tỉ lệ (0.05 = 5%) nên đổi ra số tiền = Amount * tỉ lệ
            DataTable dt = DataProvider.GetData(
                "SELECT b.ID AS [Mã HĐ], b.CheckoutDate AS [Ngày lập], a.FullName AS [Nhân viên lập], " +
                "b.Amount AS [Tổng tiền], b.Amount * ISNULL(b.Tax, 0) AS [Thuế], b.Amount * ISNULL(b.Discount, 0) AS [Giảm giá] " +
                "FROM Bills b LEFT JOIN Account a ON b.Account = a.AccountName " +
                "WHERE b.TableID = " + tableID);
            dgvBills.DataSource = dt;

            // Cộng dồn tiền của tất cả hóa đơn
            double amount = 0, tax = 0, discount = 0;
            foreach (DataRow row in dt.Rows)
            {
                amount += Convert.ToDouble(row["Tổng tiền"]);
                tax += Convert.ToDouble(row["Thuế"]);
                discount += Convert.ToDouble(row["Giảm giá"]);
            }

            lblSummary.Text = "Số hóa đơn: " + dt.Rows.Count +
                              "    Tổng tiền: " + amount.ToString("N0") +
                              "    Tổng thuế: " + tax.ToString("N0") +
                              "    Tổng giảm giá: " + discount.ToString("N0");
        }
    }
}
