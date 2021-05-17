
namespace MarketManager.Views
{
    partial class FrmMangeProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dvgProduct = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checker = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(541, 221);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(124, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dvgProduct
            // 
            this.dvgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduct.Location = new System.Drawing.Point(35, 384);
            this.dvgProduct.Name = "dvgProduct";
            this.dvgProduct.RowHeadersWidth = 51;
            this.dvgProduct.RowTemplate.Height = 24;
            this.dvgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProduct.Size = new System.Drawing.Size(873, 249);
            this.dvgProduct.TabIndex = 3;
            this.dvgProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProduct_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá tiền:";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(541, 112);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(124, 22);
            this.txtProduct.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng: ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(541, 163);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhãn hàng:";
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(141, 158);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(121, 24);
            this.cbBrand.TabIndex = 4;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh mục:";
            // 
            // cbCate
            // 
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(141, 214);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(121, 24);
            this.cbCate.TabIndex = 4;
            this.cbCate.SelectedIndexChanged += new System.EventHandler(this.cbCate_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(163, 316);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 38);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(293, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(35, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checker
            // 
            this.checker.ContainerControl = this;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(154, 39);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(662, 27);
            this.txtKey.TabIndex = 5;
            // 
            // FrmMangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 663);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.cbCate);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.dvgProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Name = "FrmMangeProduct";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.FrmMangeProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dvgProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider checker;
        private System.Windows.Forms.TextBox txtKey;
    }
}