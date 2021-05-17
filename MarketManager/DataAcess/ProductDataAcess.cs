using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;
using MarketManager.Models;
using MarketManager.Interface;
using System.Data;
namespace MarketManager.DataAcess
{
    class ProductDataAcess: DataAcess<Product>, IProductAcessible
    {
        MarketEntities entities;
        public ProductDataAcess(MarketEntities entities): base(Program.conn)
        {
            this.entities = entities;
        }

        public override bool Add(Product model)
        {
            int result = dbHelper.Excute("SP_ADD_Product", model.product_name, model.brand_id, model.category_id, model.Price.price1, model.quantity);
            return result > 0;
        }

        public override bool Delete(Product model)
        {
            int result = dbHelper.Excute("SP_DELETE_Product", model.product_id);
            return result > 0;
        }

        public override bool Update(Product model)
        {
            int result = dbHelper.Excute("SP_UPDATE_Product", model.product_id, model.product_name, model.brand_id, model.category_id, model.Price.price1, model.quantity);
            return result > 0;
        }

        public List<object> AnalystProduct()
        {
            DataTable resultQuery =  dbHelper.GetData("SP_Analyst_Product", parameters: null);
            List<object> result = new List<object>(); 
            foreach(DataRow row in resultQuery.Rows)
            {
                result.Add(row.ItemArray);
            }
            return result;
        }

        public List<object> AnalystProductSaled()
        {
            List<object> result =  entities.SP_Analyst_Product_Saled().ToList<object>();
            return result;
        }

        public List<object> GetProducts(int? catId, int? brandId)
        {
            var query =  from x in entities.SP_GET_PRODUCT(catId, brandId) select new { x.product_id, brand_name = x.brand_name, category_name = x.category_name, price = x.price, product_name = x.product_name, quantity = x.quantity };
            return query.ToList<object>();
        }

        public List<SP_GET_PRODUCT_Result> GetProducts()
        {
            return entities.SP_GET_PRODUCT(null, null).ToList();
        }
    }
}
