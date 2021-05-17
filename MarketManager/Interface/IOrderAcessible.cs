using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper.Interface;
using MarketManager.Models;
namespace MarketManager.Interface
{
    interface IOrderAcessible: ICRUD<Order> 
    {
        List<object> AnalystProfit();
        List<SP_GET_Order_Result> GetOrders();
        int GetCurrentOrderIndex();
    }
}
