
namespace MarketManager.Views
{
    partial class FrmOrderDetailManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dvgDetail = new System.Windows.Forms.DataGridView();
            this.productIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edtAmount = new System.Windows.Forms.TextBox();
            this.edtMark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.txtStaffName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edtDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dvgDetail
            // 
            this.dvgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdCol,
            this.PriceCol,
            this.ProductNameCol,
            this.QuantityCol,
            this.DiscountCol});
            this.dvgDetail.Location = new System.Drawing.Point(16, 261);
            this.dvgDetail.Name = "dvgDetail";
            this.dvgDetail.RowHeadersWidth = 51;
            this.dvgDetail.RowTemplate.Height = 24;
            this.dvgDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDetail.Size = new System.Drawing.Size(908, 285);
            this.dvgDetail.TabIndex = 3;
            this.dvgDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDetail_CellClick);
            // 
            // productIdCol
            // 
            this.productIdCol.DataPropertyName = "product_id";
            this.productIdCol.HeaderText = "Mã SP";
            this.productIdCol.MinimumWidth = 6;
            this.productIdCol.Name = "productIdCol";
            this.productIdCol.Width = 125;
            // 
            // PriceCol
            // 
            this.PriceCol.DataPropertyName = "price";
            this.PriceCol.HeaderText = "Đơn giá";
            this.PriceCol.MinimumWidth = 6;
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.Width = 125;
            // 
            // ProductNameCol
            // 
            this.ProductNameCol.DataPropertyName = "product_name";
            this.ProductNameCol.HeaderText = "Sản phẩm";
            this.ProductNameCol.MinimumWidth = 6;
            this.ProductNameCol.Name = "ProductNameCol";
            this.ProductNameCol.Width = 125;
            // 
            // QuantityCol
            // 
            this.QuantityCol.DataPropertyName = "quantity";
            this.QuantityCol.HeaderText = "Số lượng";
            this.QuantityCol.MinimumWidth = 6;
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.Width = 125;
            // 
            // DiscountCol
            // 
            this.DiscountCol.DataPropertyName = "discount";
            this.DiscountCol.HeaderText = "Giảm giá";
            this.DiscountCol.MinimumWidth = 6;
            this.DiscountCol.Name = "DiscountCol";
            this.DiscountCol.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 45);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng";
            // 
            // edtAmount
            // 
            this.edtAmount.Location = new System.Drawing.Point(135, 112);
            this.edtAmount.Name = "edtAmount";
            this.edtAmount.Size = new System.Drawing.Size(100, 22);
            this.edtAmount.TabIndex = 1;
            // 
            // edtMark
            // 
            this.edtMark.Location = new System.Drawing.Point(518, 114);
            this.edtMark.Name = "edtMark";
            this.edtMark.Size = new System.Drawing.Size(100, 22);
            this.edtMark.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sử dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khách hàng";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(518, 55);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(251, 24);
            this.cbCustomer.TabIndex = 4;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(135, 54);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(220, 24);
            this.cbProduct.TabIndex = 4;
            // 
            // txtStaffName
            // 
            this.txtStaffName.AutoSize = true;
            this.txtStaffName.Location = new System.Drawing.Point(27, 9);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(76, 17);
            this.txtStaffName.TabIndex = 0;
            this.txtStaffName.Text = "Nhân viên:";
            this.txtStaffName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sử dụng";
            // 
            // edtDiscount
            // 
            this.edtDiscount.Location = new System.Drawing.Point(518, 162);
            this.edtDiscount.Name = "edtDiscount";
            this.edtDiscount.Size = new System.Drawing.Size(100, 22);
            this.edtDiscount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giảm giá(%)";
            // 
            // FrmOrderDetailManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 558);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.dvgDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.edtAmount);
            this.Controls.Add(this.edtDiscount);
            this.Controls.Add(this.edtMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.label1);
            this.Name = "FrmOrderDetailManager";
            this.Text = "FrmOrderDetailManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOrderDetailManager_FormClosing);
            this.Load += new System.EventHandler(this.FrmOrderDetailManager_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmOrderDetailManager_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dvgDetail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtAmount;
        private System.Windows.Forms.TextBox edtMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label txtStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountCol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtDiscount;
        private System.Windows.Forms.Label label7;
    }
}