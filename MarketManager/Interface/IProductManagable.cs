using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.Models;
namespace MarketManager.Interface
{
    public interface IProductManagable
    {
        string Delete(Product product);
        string Add(Product product);
        string Update(Product product);
        List<Product> GetProducts();
        List<object> GetProducts(string key);
        List<object> GetProducts(int? catId, int? brandId);
        List<Category> GetCategories();
        List<Brand> GetBrands();
        int GetCurrentIndex();
    }
}
