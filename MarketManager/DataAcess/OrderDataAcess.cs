using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;
using MarketManager.Models;
using MarketManager.Interface;
using System.Data;
using System.Data.SqlClient;
namespace MarketManager.DataAcess
{
    class OrderDataAcess : DataAcess<Order>, IOrderAcessible
    {
        public OrderDataAcess(): base(Program.conn)
        {

        }
        public List<object> AnalystProfit()
        {
            List<object> result = new List<object>();
            DataTable table =  dbHelper.GetData("SP_Analyst_Profit", new object[1] { null });
            foreach(DataRow row in table.Rows)
            {
                result.Add(row.ItemArray);
            }
            return result;
        }

        public override bool Add(Order model)
        {
            int result =  dbHelper.Excute("SP_ADD_Order", model.customer_id, model.staff_id, model.used_mark, model.paid_price);
            return result > 0 ;
        }

        public override bool Update(Order model)
        {
            int result = dbHelper.Excute("SP_UPDATE_Order", model.order_id, model.customer_id, model.staff_id, model.paid_price, model.used_mark);
            return result > 0;
        }

        public override bool Delete(Order model)
        {
            int result = dbHelper.Excute("SP_DELETE_Order", model.order_id);
            return result > 0;
        }

        public List<SP_GET_Order_Result> GetOrders()
        {
            DataTable table = dbHelper.GetData("SP_GET_Order", new object[1] { null});
            List<SP_GET_Order_Result> results = Convert<SP_GET_Order_Result>(table);
            return results;
        }

        public int GetCurrentOrderIndex()
        {
           DataTable table =  dbHelper.GetData("SP_getCurrentIndex", parameters: "Order");
            object a = table.Rows[0]["ident"];
           return int.Parse(a.ToString()); 
        }
    }
}
