using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hostker_ddns.exterd
{
    public static class exterd
    {
        /// <summary>
        /// Json字符串转对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T ToObject<T>(this string source)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(source);
        }

    }
}
