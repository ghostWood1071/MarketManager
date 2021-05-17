using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.Models;
using MarketManager.Interface;
using SQLHelper.Interface;
namespace MarketManager.Bussiness
{
    class ProductManagerBussiness : IProductManagable
    {
        private IProductAcessible productAcess;
        private ICRUD<Brand> brandAcess;
        private ICRUD<Category> categoryAcess;

        public ProductManagerBussiness(IProductAcessible productAcess, ICRUD<Brand> brandAcess, ICRUD<Category> categoryAcess)
        {
            this.productAcess = productAcess;
            this.categoryAcess = categoryAcess;
            this.brandAcess = brandAcess;
        }
        public string Add(Product product)
        {
            bool result =  productAcess.Add(product);
            if (result)
                return "Thêm sản phẩm thành công!";
            return "Thêm sản phẩm thất bại";
        }

        public string Delete(Product product)
        {
            bool result = productAcess.Delete(product);
            if (result)
                return "Xoá sản phẩm thành công!";
            return "Xoá sản phẩm thất bại";
        }

        public List<Brand> GetBrands()
        {
            return brandAcess.GetList("Brand");
        }

        public List<Category> GetCategories()
        {
            return categoryAcess.GetList("Category");
        }

        public int GetCurrentIndex()
        {
            return productAcess.GetList("Product").Last().product_id;
        }

        public List<Product> GetProducts()
        {
           return productAcess.GetList("Product");
        }

        public List<object> GetProducts(string key)
        {
            List<object> products = GetProducts(null, null);
            var result = products.Where((x) =>
            {
                dynamic product = x;
                return product.product_name.Contains(key) || product.brand_name.Contains(key) || product.category_name.Contains(key);
            }).ToList<object>();
            return result;
        }

        public List<object> GetProducts(int? catId, int? brandId)
        {
            return productAcess.GetProducts(catId, brandId);
        }

  
        public string Update(Product product)
        {
            bool result = productAcess.Update(product);
            if (result)
                return "Cập nhật sản phẩm thành công!";
            return "Cập nhật sản phẩm thất bại";
        }
    }
}
