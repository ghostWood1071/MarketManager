using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.Interface;
using SQLHelper.Interface;
using MarketManager.Models;
namespace MarketManager.Bussiness
{
    class LoginBussiness : ILoginable
    {
        private ICRUD<Staff> staffAcess;
        public LoginBussiness(ICRUD<Staff> staffAcess)
        {
            this.staffAcess = staffAcess;
        }

        public Staff Login(string account, string password)
        {
            List<Staff> staffs =  staffAcess.GetList("Staff");
            List<Staff> result = staffs.FindAll(x => x.account == account && x.password == password);
            if (result.Count > 0)
                return result[0];
            return null;
        }
    }
}
