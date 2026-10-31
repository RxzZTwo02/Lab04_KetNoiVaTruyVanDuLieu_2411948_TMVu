using System.Windows.Forms;

namespace Lab04_Basic_Command
{
    // Bài tập 3: các vai trò được gán cho một tài khoản
    public partial class AccountRolesForm : Form
    {
        public AccountRolesForm()
        {
            InitializeComponent();
        }

        public void LoadRoles(string accountName)
        {
            this.Text = "Vai trò của tài khoản: " + accountName;
            dgvRoles.DataSource = DataProvider.GetData(
                "SELECT r.ID AS [Mã vai trò], r.RoleName AS [Tên vai trò], r.Path AS [Đường dẫn], ra.Actived AS [Kích hoạt] " +
                "FROM RoleAccount ra JOIN Role r ON ra.RoleID = r.ID " +
                "WHERE ra.AccountName = N'" + accountName + "'");
        }
    }
}
