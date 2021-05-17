using System;
using System.Collections.Generic;
using SQLHelper;
using MarketManager.Models;
using MarketManager.Interface;
using System.Threading;
using System.Text.Json;
namespace MarketManager.DataAcess
{
    class OrderDetailDataAcess: DataAcess<OrderDetail>, IDetailAcessible
    {
        public OrderDetailDataAcess() : base(Program.conn)
        {

        }

        public bool AddAll(List<OrderDetail> details)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(details);
                dbHelper.Excute("SP_InsertOrderDetail", jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateAll(List<OrderDetail> details)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(details);
                dbHelper.Excute("SP_UpdateOrderDetails", jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
