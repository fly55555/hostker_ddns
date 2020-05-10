using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hostker_ddns.modle.dns
{
    /// <summary>
    /// 解析记录
    /// </summary>
    public class record
    {
        /// <summary>
        /// 记录值编号
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 解析头
        /// </summary>
        public string header { get; set; }
        /// <summary>
        /// 解析类型
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 生存周期
        /// </summary>
        public string ttl { get; set; }
        /// <summary>
        /// 优先级
        /// </summary>
        public string pritority { get; set; }
        /// <summary>
        /// 解析值
        /// </summary>
        public string data { get; set; }
    }

    public class dns_records: response
    {
        /// <summary>
        /// 解析记录数组
        /// </summary>
        public record[] records { get; set; }
    }
}
