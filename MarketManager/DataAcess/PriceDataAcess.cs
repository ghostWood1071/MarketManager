using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.Interface;
using MarketManager.Models;
using SQLHelper;
namespace MarketManager.DataAcess
{
    class PriceDataAcess: DataAcess<Price>
    {
        public PriceDataAcess(): base(Program.conn)
        {

        }
    }
}
