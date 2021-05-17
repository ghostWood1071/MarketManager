using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.ExtendsionMethod
{
    public static class DataSenderBuss
    {
        public static void SetData(this Dictionary<String, object> dict ,string key, object value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = value;
                return;
            }
            dict.Add(key, value);
        }
    }
}
