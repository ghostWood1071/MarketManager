using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.Models;
namespace MarketManager.Interface
{
    public interface ISellable
    {
        List<SP_GET_PRODUCT_Result> GetProducts();
        List<SP_GET_Order_Result> GetOrders();
        List<object> GetOrders(string key);
        List<OrderDetail> GetOrderDetails(int orderId);
        List<OrderDetailResult> GetDetailResults(int orderId, List<SP_GET_PRODUCT_Result> product);
        List<SP_GET_PRODUCT_Result> OptimizeProduct(List<SP_GET_PRODUCT_Result> list);
        List<SP_GET_PRODUCT_Result> AddIDToName(List<SP_GET_PRODUCT_Result> list);
        List<Customer> GetCustomers();

        bool UpdateOrderDetails(List<OrderDetail> details);
        bool AddOrder(Order order);
        bool AddOrderDetails(List<OrderDetail> details);
        void CheckOut(Order order, List<OrderDetail> details);
        
        bool CheckMark(Customer customer, short mark);
        bool CheckQuantity(SP_GET_PRODUCT_Result product, OrderDetail detail);
        
        bool UpdateOrder(Order order);
        bool DeleteOrder(Order order);
        int GetCurrentOrderIndex();
    }
}
