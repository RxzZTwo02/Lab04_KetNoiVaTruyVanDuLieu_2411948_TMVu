namespace Lab04_Basic_Command
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBills = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.lvTable = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDeleteTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewBills = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewBillLog = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.cmsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCategory,
            this.tsmBills,
            this.tsmAccount});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(700, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmCategory
            // 
            this.tsmCategory.Name = "tsmCategory";
            this.tsmCategory.Size = new System.Drawing.Size(139, 20);
            this.tsmCategory.Text = "Quản lý nhóm món ăn";
            this.tsmCategory.Click += new System.EventHandler(this.tsmCategory_Click);
            // 
            // tsmBills
            // 
            this.tsmBills.Name = "tsmBills";
            this.tsmBills.Size = new System.Drawing.Size(121, 20);
            this.tsmBills.Text = "Danh sách hóa đơn";
            this.tsmBills.Click += new System.EventHandler(this.tsmBills_Click);
            // 
            // tsmAccount
            // 
            this.tsmAccount.Name = "tsmAccount";
            this.tsmAccount.Size = new System.Drawing.Size(112, 20);
            this.tsmAccount.Text = "Quản lý tài khoản";
            this.tsmAccount.Click += new System.EventHandler(this.tsmAccount_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(37, 43);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Mã bàn:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 40);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(244, 20);
            this.txtID.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên bàn:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(37, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(130, 100);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(244, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(37, 133);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(56, 13);
            this.lblCapacity.TabIndex = 7;
            this.lblCapacity.Text = "Sức chứa:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(130, 130);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(244, 20);
            this.txtCapacity.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 168);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(107, 29);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Lấy danh sách";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(180, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(290, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(400, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Enabled = false;
            this.btnViewBill.Location = new System.Drawing.Point(510, 168);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(178, 29);
            this.btnViewBill.TabIndex = 13;
            this.btnViewBill.Text = "Xem hóa đơn hiện tại";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // lvTable
            // 
            this.lvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chStatus,
            this.chCapacity});
            this.lvTable.ContextMenuStrip = this.cmsTable;
            this.lvTable.FullRowSelect = true;
            this.lvTable.HideSelection = false;
            this.lvTable.Location = new System.Drawing.Point(12, 205);
            this.lvTable.MultiSelect = false;
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(676, 403);
            this.lvTable.TabIndex = 14;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            this.lvTable.Click += new System.EventHandler(this.lvTable_Click);
            // 
            // chID
            // 
            this.chID.Text = "Mã bàn";
            this.chID.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "Tên bàn";
            this.chName.Width = 300;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Trạng thái";
            this.chStatus.Width = 120;
            // 
            // chCapacity
            // 
            this.chCapacity.Text = "Sức chứa";
            this.chCapacity.Width = 120;
            // 
            // cmsTable
            // 
            this.cmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDeleteTable,
            this.tsmViewBills,
            this.tsmViewBillLog});
            this.cmsTable.Name = "cmsTable";
            this.cmsTable.Size = new System.Drawing.Size(203, 70);
            // 
            // tsmDeleteTable
            // 
            this.tsmDeleteTable.Name = "tsmDeleteTable";
            this.tsmDeleteTable.Size = new System.Drawing.Size(202, 22);
            this.tsmDeleteTable.Text = "Xóa bàn";
            this.tsmDeleteTable.Click += new System.EventHandler(this.tsmDeleteTable_Click);
            // 
            // tsmViewBills
            // 
            this.tsmViewBills.Name = "tsmViewBills";
            this.tsmViewBills.Size = new System.Drawing.Size(202, 22);
            this.tsmViewBills.Text = "Xem danh mục hóa đơn";
            this.tsmViewBills.Click += new System.EventHandler(this.tsmViewBills_Click);
            // 
            // tsmViewBillLog
            // 
            this.tsmViewBillLog.Name = "tsmViewBillLog";
            this.tsmViewBillLog.Size = new System.Drawing.Size(202, 22);
            this.tsmViewBillLog.Text = "Xem nhật ký hóa đơn";
            this.tsmViewBillLog.Click += new System.EventHandler(this.tsmViewBillLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 620);
            this.Controls.Add(this.lvTable);
            this.Controls.Add(this.btnViewBill);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.Text = "Quản lý bàn";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.cmsTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmBills;
        private System.Windows.Forms.ToolStripMenuItem tsmAccount;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chCapacity;
        private System.Windows.Forms.ContextMenuStrip cmsTable;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteTable;
        private System.Windows.Forms.ToolStripMenuItem tsmViewBills;
        private System.Windows.Forms.ToolStripMenuItem tsmViewBillLog;
    }
}
