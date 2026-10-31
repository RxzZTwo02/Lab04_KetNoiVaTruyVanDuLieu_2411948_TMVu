using System;
using System.Data;
using System.Windows.Forms;

namespace Lab04_Basic_Command
{
    // Bài tập 4: danh mục hóa đơn của một bàn
    public partial class TableBillsForm : Form
    {
        // Các hóa đơn của bàn, dòng thứ i ứng với mục thứ i trong ListBox
        DataTable billTable;

        public TableBillsForm()
        {
            InitializeComponent();
        }

        public void LoadBills(int tableID)
        {
            this.Text = "Danh mục hóa đơn của bàn số " + tableID;

            billTable = DataProvider.GetData(
                "SELECT b.ID, b.Name, b.CheckoutDate, b.Amount, b.Discount, b.Tax, b.Status, a.FullName " +
                "FROM Bills b LEFT JOIN Account a ON b.Account = a.AccountName " +
                "WHERE b.TableID = " + tableID + " ORDER BY b.CheckoutDate");

            lbBills.Items.Clear();
            foreach (DataRow row in billTable.Rows)
                lbBills.Items.Add("HĐ " + row["ID"] + " - " + row["CheckoutDate"]);
        }

        private void lbBills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBills.SelectedIndex < 0) return;

            DataRow row = billTable.Rows[lbBills.SelectedIndex];

            lblBillInfo.Text = "Mã hóa đơn: " + row["ID"] +
                               "\nTên hóa đơn: " + row["Name"] +
                               "\nNgày lập: " + row["CheckoutDate"] +
                               "\nNhân viên lập: " + row["FullName"] +
                               "\nTổng tiền: " + row["Amount"] +
                               "    Tỉ lệ giảm giá: " + row["Discount"] +
                               "    Tỉ lệ thuế: " + row["Tax"] +
                               "\nTrạng thái: " + (Convert.ToBoolean(row["Status"]) ? "Đã thanh toán" : "Chưa thanh toán");

            dgvBillDetails.DataSource = BillDetailsForm.GetBillDetails(Convert.ToInt32(row["ID"]));
        }
    }
}
