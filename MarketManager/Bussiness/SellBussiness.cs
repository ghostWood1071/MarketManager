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
    class SellBussiness : ISellable
    {
        private IProductAcessible productAcess;
        private IOrderAcessible orderAcess;
        private IDetailAcessible detailAcess;
        private ICRUD<Customer> customAcess;

        public SellBussiness(IProductAcessible productAcess, 
                             IOrderAcessible orderAcess,
                             IDetailAcessible detailAcess, 
                             ICRUD<Customer> customAcess)
        {
            this.productAcess = productAcess;
            this.orderAcess = orderAcess;
            this.detailAcess = detailAcess;
            this.customAcess = customAcess;
        }

        public bool AddOrder(Order order)
        {
            return  orderAcess.Add(order);
        }

        public bool AddOrderDetails(List<OrderDetail> details)
        {
            return detailAcess.AddAll(details);
        }

        public void CheckOut(Order order, List<OrderDetail> details) 
        {
            double totalPrice = 0;
            details.ForEach(x => totalPrice += x.price);
            totalPrice -= order.used_mark==null?0:(short)order.used_mark * 1000;
            order.paid_price = totalPrice;
        }

        public List<SP_GET_Order_Result> GetOrders()
        {

            List<SP_GET_Order_Result> orders =  orderAcess.GetOrders();
            return orders;

        }

        public List<object> GetOrders(string key)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            if(orderId>=0)  
                return detailAcess.GetList("OrderDetail", "order_id", orderId);
            return new List<OrderDetail>();
        }

        public List<SP_GET_PRODUCT_Result> GetProducts()
        {
            List<SP_GET_PRODUCT_Result> result = productAcess.GetProducts();
            return result;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> list =  customAcess.GetList("Customer");
            list.ForEach(x => x.name = x.custom_id + " | " + x.name);
            return list;
        }

        public bool CheckMark(Customer customer, short mark)
        {
            if (customer.mark < mark)
                return false;
            customer.mark -= mark;
            return true;
        }

        public bool CheckQuantity(SP_GET_PRODUCT_Result product, OrderDetail detail)
        {
            
            if (product.quantity < detail.quantity)
                return false;
            product.quantity -= detail.quantity;
            return true;
        }

        public List<OrderDetailResult> GetDetailResults(int orderId, List<SP_GET_PRODUCT_Result> product)
        {
            List<OrderDetail> orderDetails = GetOrderDetails(orderId);
            if (orderDetails == null)
                return null;
            var querry = from x in orderDetails
                         select new OrderDetailResult()
                         {
                             order_id = x.order_id,
                             product_id = product[product.FindIndex(p=>p.product_id == x.product_id)].product_id,
                             product_name = product[product.FindIndex(p => p.product_id == x.product_id)].product_name,
                             price = x.price,
                             discount = x.discount,
                             quantity = x.quantity
                         };
            return querry.ToList<OrderDetailResult>();
        }

        public List<SP_GET_PRODUCT_Result> OptimizeProduct(List<SP_GET_PRODUCT_Result> list)
        {
            for(int i = 0; i<list.Count; i++)
            {
                string name = list[i].product_name;
                list[i].product_name =  name.Split(new char[] {'|'})[1].Trim();
            }
            return list;
        }

        public List<SP_GET_PRODUCT_Result> AddIDToName(List<SP_GET_PRODUCT_Result> list) 
        {
            list.ForEach(x => x.product_name = x.product_id + " | " + x.product_name);
            return list;
        }

        public bool UpdateOrderDetails(List<OrderDetail> details)
        {
            return detailAcess.UpdateAll(details);
        }

        public bool UpdateOrder(Order order)
        {
            return orderAcess.Update(order);
        }

        public bool DeleteOrder(Order order)
        {
           return  orderAcess.Delete(order);
        }

        public int GetCurrentOrderIndex()
        {
            return orderAcess.GetCurrentOrderIndex();
        }
    }
}
