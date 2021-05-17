using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.Models;
namespace MarketManager.Interface
{
    public interface ILoginable
    {
        Staff Login(string account, string password);
    }
}
