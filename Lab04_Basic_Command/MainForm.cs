using System;
using System.Data;
using System.Windows.Forms;

namespace Lab04_Basic_Command
{
    // Bài tập 4: quản lý bàn, đồng thời là form khởi động để mở các form khác
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmCategory_Click(object sender, EventArgs e)
        {
            new CategoryForm().Show(this);
        }

        private void tsmBills_Click(object sender, EventArgs e)
        {
            new BillsForm().Show(this);
        }

        private void tsmAccount_Click(object sender, EventArgs e)
        {
            new AccountManager().Show(this);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = DataProvider.GetData("SELECT ID, Name, Status, Capacity FROM [Table]");

            lvTable.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["ID"].ToString());
                item.SubItems.Add(row["Name"].ToString());
                item.SubItems.Add(row["Status"].ToString());
                item.SubItems.Add(row["Capacity"].ToString());
                lvTable.Items.Add(item);
            }

            // Danh sách mới chưa có bàn nào được chọn
            txtID.Text = "";
            txtName.Text = "";
            txtStatus.Text = "";
            txtCapacity.Text = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnViewBill.Enabled = false;
        }

        private void lvTable_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvTable.SelectedItems[0];

            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtStatus.Text = item.SubItems[2].Text;
            txtCapacity.Text = item.SubItems[3].Text;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnViewBill.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [Table](Name, Status, Capacity) " +
                           "VALUES (N'" + txtName.Text + "', " + txtStatus.Text + ", " + txtCapacity.Text + ")";

            if (DataProvider.Execute(query) == 1)
            {
                MessageBox.Show("Thêm bàn thành công");
                btnLoad.PerformClick();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [Table] SET Name = N'" + txtName.Text +
                           "', Status = " + txtStatus.Text +
                           ", Capacity = " + txtCapacity.Text +
                           " WHERE ID = " + txtID.Text;

            if (DataProvider.Execute(query) == 1)
            {
                MessageBox.Show("Cập nhật bàn thành công");
                btnLoad.PerformClick();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa bàn " + txtName.Text + " khỏi cơ sở dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            if (DataProvider.Execute("DELETE FROM [Table] WHERE ID = " + txtID.Text) == 1)
            {
                MessageBox.Show("Xóa bàn thành công");
                btnLoad.PerformClick();
            }
        }

        // Hóa đơn hiện tại = hóa đơn chưa thanh toán (Status = 0) của bàn
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            DataTable dt = DataProvider.GetData("SELECT ID FROM Bills WHERE TableID = " + txtID.Text + " AND Status = 0");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Bàn này hiện không có hóa đơn chưa thanh toán");
                return;
            }

            BillDetailsForm billDetailsForm = new BillDetailsForm();
            billDetailsForm.Show(this);
            billDetailsForm.LoadBillDetails(Convert.ToInt32(dt.Rows[0]["ID"]));
        }

        // Menu chuột phải
        private void tsmDeleteTable_Click(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmViewBills_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                TableBillsForm tableBillsForm = new TableBillsForm();
                tableBillsForm.Show(this);
                tableBillsForm.LoadBills(Convert.ToInt32(txtID.Text));
            }
        }

        private void tsmViewBillLog_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                TableBillLogForm tableBillLogForm = new TableBillLogForm();
                tableBillLogForm.Show(this);
                tableBillLogForm.LoadBillLog(Convert.ToInt32(txtID.Text));
            }
        }
    }
}
