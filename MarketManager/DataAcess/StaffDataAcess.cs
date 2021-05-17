using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;
using MarketManager.Models;
namespace MarketManager.DataAcess
{
    class StaffDataAcess: DataAcess<Staff>
    {
        public StaffDataAcess() : base(Program.conn)
        {
        }
    }
}
