using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper.Interface;
using MarketManager.Models;
namespace MarketManager.Interface
{
    public interface IProductAcessible: ICRUD<Product>
    {
        List<object> AnalystProduct();
        List<object> AnalystProductSaled();
        List<object> GetProducts(int? catId, int? brandId);
        List<SP_GET_PRODUCT_Result> GetProducts();
    }
}
