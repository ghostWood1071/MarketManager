using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper.Interface;
using MarketManager.Models;
namespace MarketManager.Interface
{
    interface IDetailAcessible: ICRUD<OrderDetail>
    {
        bool AddAll(List<OrderDetail> details);
        bool UpdateAll(List<OrderDetail> details);
    }
}
