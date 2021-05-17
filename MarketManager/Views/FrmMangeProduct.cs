using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketManager.Interface;
using MarketManager.Models;
namespace MarketManager.Views
{
    public partial class FrmMangeProduct : Form
    {
        private IProductManagable productManager;
        private List<object> products;
        private List<Category> categories;
        private List<Brand> brands;
        private int curentBrandId, curentCateId;
        private int currentProductId;
        private int cursorPos;

        public FrmMangeProduct(IProductManagable productManager)
        {
            this.productManager = productManager;
            InitializeComponent();
        }

        private void FrmMangeProduct_Load(object sender, EventArgs e)
        {
            brands = productManager.GetBrands();
            categories = productManager.GetCategories();
            curentBrandId = brands.First().brand_id;
            curentCateId = categories.First().category_id;
            products = productManager.GetProducts(curentCateId, curentBrandId);
            currentProductId = productManager.GetCurrentIndex();
            cursorPos = 0;

            cbBrand.DataSource = brands;
            cbBrand.DisplayMember = "brand_name";
            cbBrand.ValueMember = "brand_id";

            cbCate.DataSource = categories;
            cbCate.DisplayMember = "category_name";
            cbCate.ValueMember = "category_id";

            dvgProduct.DataSource = products;

            UpdateContentComponent(cursorPos);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Product product = GetProductFromView();

            MessageBox.Show(productManager.Add(product));
            currentProductId += 1;
            products.Add(Convert(product));
            ReloadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = GetProductFromView();
            MessageBox.Show(productManager.Update(product));
            products[products.FindIndex((x) => {
                dynamic pr = x;
                return pr.product_id == product.product_id;
            })] = Convert(product);
            ReloadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product product = GetProductFromView();
            MessageBox.Show(productManager.Delete(product));
            products.Remove(products.Find((x) => {
                dynamic pr = x;
                return pr.product_id == product.product_id;
            }));
            ReloadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            products = productManager.GetProducts(key);
            ReloadData();
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brand curentBrand = (Brand)cbBrand.SelectedItem;
            curentBrandId = curentBrand.brand_id;
            products = productManager.GetProducts(curentCateId, curentBrandId);
            ReloadData();
        }

        private void cbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category)cbCate.SelectedItem;
            curentCateId = category.category_id;
            products = productManager.GetProducts(curentCateId, curentBrandId);
            ReloadData();
        }

        private void dvgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cursorPos = e.RowIndex;
            UpdateContentComponent(e.RowIndex);
        }

        private void ReloadData()
        {
            dvgProduct.DataSource = null;
            dvgProduct.DataSource = products;
        }

        private void UpdateContentComponent(int index)
        {

            string brand = dvgProduct.Rows[index].Cells[1].Value.ToString();
            string cate = dvgProduct.Rows[index].Cells[2].Value.ToString();
            double price = (double)dvgProduct.Rows[index].Cells[3].Value;
            string name = dvgProduct.Rows[index].Cells[4].Value.ToString();
            short quantity = (short)dvgProduct.Rows[index].Cells[5].Value;

            txtPrice.Text = price.ToString();
            txtProduct.Text = name;
            txtQuantity.Text = quantity.ToString();
            cbBrand.Text = brand;
            cbCate.Text = cate;
        }

        private Product GetProductFromView()
        {
            int id = (int)dvgProduct.Rows[cursorPos].Cells[0].Value;
            double inPrice = float.Parse(txtPrice.Text);
            string productName = txtProduct.Text;
            short inQuantity = short.Parse(txtQuantity.Text);
            Category category = (Category)(cbCate.SelectedItem);
            Brand brand = (Brand)cbBrand.SelectedItem;

            Product product = new Product();
            product.product_id = id;
            product.brand_id = brand.brand_id;
            product.category_id = category.category_id;
            product.product_name = productName;
            product.Price = new Price() { price1 = inPrice };
            product.quantity = inQuantity;
            product.Category = category;
            product.Brand = brand;

            return product;
        }

        private object Convert(Product product)
        {
            return new
            {
                product_id = currentProductId,
                brand_name = product.Brand.brand_name,
                category_name = product.Category.category_name,
                price = product.Price.price1,
                product_name = product.product_name,
                quantity = product.quantity
            };
        }

    }
}
