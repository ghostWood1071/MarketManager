using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.Models;
using SQLHelper.Interface;
using SQLHelper;
namespace MarketManager.DataAcess
{
    class CategoryDataAcess: DataAcess<Category>
    {
        public CategoryDataAcess(): base(Program.conn)
        {

        }
    }
}
