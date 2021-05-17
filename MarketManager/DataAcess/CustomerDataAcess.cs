using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper.Interface;
using MarketManager.Models;
using SQLHelper;
namespace MarketManager.DataAcess
{
    class CustomerDataAcess: DataAcess<Customer>
    {
        public CustomerDataAcess() : base(Program.conn)
        {

        }
    }
}
