using System;
using System.Data;
using System.Windows.Forms;

namespace Lab04_Basic_Command
{
    // Bài tập 3: quản lý tài khoản
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {
            // Nạp danh sách nhóm (vai trò) vào ComboBox
            cbbRole.DisplayMember = "RoleName";
            cbbRole.ValueMember = "ID";
            cbbRole.DataSource = DataProvider.GetData("SELECT ID, RoleName FROM Role");

            btnView.PerformClick();
        }

        // Xem danh sách tài khoản theo nhóm và theo trạng thái kích hoạt
        private void btnView_Click(object sender, EventArgs e)
        {
            // Chưa có nhóm nào trong CSDL
            if (cbbRole.SelectedValue == null) return;

            string query = "SELECT a.AccountName, a.FullName, a.Email, a.Tell, a.DateCreated " +
                           "FROM Account a JOIN RoleAccount ra ON a.AccountName = ra.AccountName " +
                           "WHERE ra.RoleID = " + cbbRole.SelectedValue +
                           " AND ra.Actived = " + (chkActived.Checked ? 1 : 0);
            DataTable dt = DataProvider.GetData(query);

            lvAccount.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["AccountName"].ToString());
                item.SubItems.Add(row["FullName"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Tell"].ToString());
                item.SubItems.Add(row["DateCreated"].ToString());
                lvAccount.Items.Add(item);
            }

            // Danh sách mới chưa có tài khoản nào được chọn
            txtAccountName.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtTell.Text = "";
            btnUpdate.Enabled = false;
            btnResetPassword.Enabled = false;
        }

        private void lvAccount_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvAccount.SelectedItems[0];

            txtAccountName.Text = item.Text;
            txtFullName.Text = item.SubItems[1].Text;
            txtEmail.Text = item.SubItems[2].Text;
            txtTell.Text = item.SubItems[3].Text;

            btnUpdate.Enabled = true;
            btnResetPassword.Enabled = true;
        }

        // Thêm tài khoản mới và gán vào nhóm đang chọn (đang kích hoạt)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản và mật khẩu");
                return;
            }

            string query = "INSERT INTO Account(AccountName, Password, FullName, Email, Tell, DateCreated) " +
                           "VALUES (N'" + txtAccountName.Text + "', N'" + txtPassword.Text + "', N'" + txtFullName.Text +
                           "', N'" + txtEmail.Text + "', N'" + txtTell.Text + "', GETDATE())";
            if (DataProvider.Execute(query) == 0) return;   // trùng tên tài khoản hoặc lỗi khác

            DataProvider.Execute("INSERT INTO RoleAccount(RoleID, AccountName, Actived) " +
                                 "VALUES (" + cbbRole.SelectedValue + ", N'" + txtAccountName.Text + "', 1)");

            MessageBox.Show("Thêm tài khoản thành công");
            btnView.PerformClick();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Account SET FullName = N'" + txtFullName.Text +
                           "', Email = N'" + txtEmail.Text +
                           "', Tell = N'" + txtTell.Text +
                           "' WHERE AccountName = N'" + txtAccountName.Text + "'";

            if (DataProvider.Execute(query) == 1)
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
                btnView.PerformClick();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            // ponytail: mật khẩu mặc định cố định, đổi sang mật khẩu ngẫu nhiên khi cần bảo mật hơn
            string query = "UPDATE Account SET Password = N'123456' WHERE AccountName = N'" + txtAccountName.Text + "'";

            if (DataProvider.Execute(query) == 1)
                MessageBox.Show("Mật khẩu mới của tài khoản " + txtAccountName.Text + " là 123456");
        }

        // Xóa tài khoản = đánh dấu toàn bộ vai trò của tài khoản là không kích hoạt (0)
        private void tsmDeleteAccount_Click(object sender, EventArgs e)
        {
            if (lvAccount.SelectedItems.Count == 0) return;

            string accountName = lvAccount.SelectedItems[0].Text;
            if (DataProvider.Execute("UPDATE RoleAccount SET Actived = 0 WHERE AccountName = N'" + accountName + "'") > 0)
            {
                MessageBox.Show("Đã hủy kích hoạt toàn bộ vai trò của tài khoản " + accountName);
                btnView.PerformClick();
            }
        }

        private void tsmViewRoles_Click(object sender, EventArgs e)
        {
            if (lvAccount.SelectedItems.Count == 0) return;

            AccountRolesForm accountRolesForm = new AccountRolesForm();
            accountRolesForm.Show(this);
            accountRolesForm.LoadRoles(lvAccount.SelectedItems[0].Text);
        }
    }
}
