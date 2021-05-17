using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Models
{
    public class OrderResults : SP_GET_Order_Result
    {
        public string CustomerName { get; set;}    
        public string StaffName { get; set; }
    }
}
