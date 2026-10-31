namespace Lab04_Basic_Command
{
    partial class TableBillsForm
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
            this.lbBills = new System.Windows.Forms.ListBox();
            this.lblBillInfo = new System.Windows.Forms.Label();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.SuspendLayout();
            //
            // lbBills
            //
            this.lbBills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbBills.FormattingEnabled = true;
            this.lbBills.Location = new System.Drawing.Point(12, 12);
            this.lbBills.Name = "lbBills";
            this.lbBills.Size = new System.Drawing.Size(200, 394);
            this.lbBills.TabIndex = 0;
            this.lbBills.SelectedIndexChanged += new System.EventHandler(this.lbBills_SelectedIndexChanged);
            //
            // lblBillInfo
            //
            this.lblBillInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillInfo.Location = new System.Drawing.Point(225, 12);
            this.lblBillInfo.Name = "lblBillInfo";
            this.lblBillInfo.Size = new System.Drawing.Size(523, 110);
            this.lblBillInfo.TabIndex = 1;
            this.lblBillInfo.Text = "Chọn một ngày ở bên trái để xem hóa đơn";
            //
            // dgvBillDetails
            //
            this.dgvBillDetails.AllowUserToAddRows = false;
            this.dgvBillDetails.AllowUserToDeleteRows = false;
            this.dgvBillDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Location = new System.Drawing.Point(225, 130);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.ReadOnly = true;
            this.dgvBillDetails.Size = new System.Drawing.Size(523, 276);
            this.dgvBillDetails.TabIndex = 2;
            //
            // TableBillsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.dgvBillDetails);
            this.Controls.Add(this.lblBillInfo);
            this.Controls.Add(this.lbBills);
            this.Name = "TableBillsForm";
            this.Text = "Danh mục hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBills;
        private System.Windows.Forms.Label lblBillInfo;
        private System.Windows.Forms.DataGridView dgvBillDetails;
    }
}
