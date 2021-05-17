
namespace MarketManager.Views
{
    partial class FrmOrderManger
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
            this.dvgOrder = new System.Windows.Forms.DataGridView();
            this.orderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgOrder
            // 
            this.dvgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderCol,
            this.customCol,
            this.staffCol,
            this.dayCol,
            this.markCol,
            this.totalCol});
            this.dvgOrder.Location = new System.Drawing.Point(34, 84);
            this.dvgOrder.Name = "dvgOrder";
            this.dvgOrder.RowHeadersWidth = 51;
            this.dvgOrder.RowTemplate.Height = 24;
            this.dvgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgOrder.Size = new System.Drawing.Size(1070, 321);
            this.dvgOrder.TabIndex = 0;
            this.dvgOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgOrder_CellDoubleClick);
            // 
            // orderCol
            // 
            this.orderCol.DataPropertyName = "order_id";
            this.orderCol.HeaderText = "Mã đơn hàng";
            this.orderCol.MinimumWidth = 6;
            this.orderCol.Name = "orderCol";
            this.orderCol.Width = 125;
            // 
            // customCol
            // 
            this.customCol.DataPropertyName = "name";
            this.customCol.HeaderText = "Khách hàng";
            this.customCol.MinimumWidth = 6;
            this.customCol.Name = "customCol";
            this.customCol.Width = 125;
            // 
            // staffCol
            // 
            this.staffCol.DataPropertyName = "staff_name";
            this.staffCol.HeaderText = "Nhân viên";
            this.staffCol.MinimumWidth = 6;
            this.staffCol.Name = "staffCol";
            this.staffCol.Width = 125;
            // 
            // dayCol
            // 
            this.dayCol.DataPropertyName = "pay_day";
            this.dayCol.HeaderText = "Ngày thanh toán";
            this.dayCol.MinimumWidth = 6;
            this.dayCol.Name = "dayCol";
            this.dayCol.Width = 125;
            // 
            // markCol
            // 
            this.markCol.DataPropertyName = "used_mark";
            this.markCol.HeaderText = "Điểm sử dụng";
            this.markCol.MinimumWidth = 6;
            this.markCol.Name = "markCol";
            this.markCol.Width = 125;
            // 
            // totalCol
            // 
            this.totalCol.DataPropertyName = "paid_price";
            this.totalCol.HeaderText = "Tổng tiền";
            this.totalCol.MinimumWidth = 6;
            this.totalCol.Name = "totalCol";
            this.totalCol.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 456);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 46);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(34, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(451, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(511, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmOrderManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 549);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dvgOrder);
            this.Name = "FrmOrderManger";
            this.Text = "FrmOrderManger";
            this.Load += new System.EventHandler(this.FrmOrderManger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn customCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn markCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
    }
}