using hostker_ddns.core;
using hostker_ddns.modle;
using hostker_ddns.exterd;
using hostker_ddns.modle.dns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hostker_ddns.api
{
    public class hostker_dns_api
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        public string m_email { get; set; }
        /// <summary>
        /// 密钥
        /// </summary>
        public string m_key_code { get; set; }

        /// <summary>
        /// post/get 实现
        /// </summary>
        public network_request nr { get; set; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="key_code">api密钥</param>
        public hostker_dns_api(string email, string key_code)
        {
            m_email = email;
            m_key_code = key_code;
            nr = new network_request();
        }

        /// <summary>
        /// 添加解析记录
        /// </summary>
        /// <param name="domain">主域名</param>
        /// <param name="header">主机头</param>
        /// <param name="type">解析记录类型(CDN A CNAME TXT MX AAAA)</param>
        /// <param name="data">解析记录值</param>
        /// <param name="ttl">记录生存周期(60-339384)</param>
        /// <param name="priority">优先级(1-50000)</param>
        public string add_record(string domain, string header, string type, string data, string ttl = "300", string priority = "")
        {
            nr.url = "https://i.hostker.com/api/dnsAddRecord";
            nr.post_dict.Add("email", m_email);
            nr.post_dict.Add("token", m_key_code);

            nr.post_dict.Add("domain", domain);
            nr.post_dict.Add("header", header);
            nr.post_dict.Add("type", type);
            nr.post_dict.Add("data", data);
            nr.post_dict.Add("ttl", ttl);
            if (!string.IsNullOrEmpty(priority)) nr.post_dict.Add("priority", priority);

            var response = nr.get_request();
            var h_result = response.ToObject<dns_add>();
            if (h_result.success == 1) return h_result.id.ToString();

            return string.Empty;
        }

        /// <summary>
        /// 删除解析记录
        /// </summary>
        /// <param name="id">解析记录编号</param>
        /// <returns></returns>
        public bool delete_record(string id)
        {
            nr.url = "https://i.hostker.com/api/dnsDeleteRecord";
            nr.post_dict.Add("email", m_email);
            nr.post_dict.Add("token", m_key_code);

            nr.post_dict.Add("id", id);

            var response = nr.get_request();
            var h_result = response.ToObject<response>();

            return h_result.success == 1;
        }

        /// <summary>
        /// 获取所有解析记录
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        public record[] get_records(string domain)
        {
            nr.url = "https://i.hostker.com/api/dnsGetRecords";
            nr.post_dict.Add("email", m_email);
            nr.post_dict.Add("token", m_key_code);

            nr.post_dict.Add("domain", domain);

            var response = nr.get_request();
            var h_result = response.ToObject<dns_records>();
            if (h_result.success == 1) return h_result.records;

            return null;
        }

        /// <summary>
        /// 修改解析记录
        /// </summary>
        /// <param name="id">解析记录编号</param>
        /// <param name="data">新的解析记录值</param>
        /// <param name="ttl">记录生存周期(60-339384)</param>
        /// <param name="priority">优先级(1-50000)</param>
        /// <returns></returns>
        public bool edit_record(string id,string data, string ttl = "300", string priority = "")
        {
            nr.url = "https://i.hostker.com/api/dnsEditRecord";
            nr.post_dict.Add("email", m_email);
            nr.post_dict.Add("token", m_key_code);

            nr.post_dict.Add("id", id);
            nr.post_dict.Add("ttl", ttl);
            nr.post_dict.Add("data", data);
            if (!string.IsNullOrEmpty(priority)) nr.post_dict.Add("priority", priority);

            var response = nr.get_request();
            var h_result = response.ToObject<response>();

            return h_result.success == 1;
        }



    }
}
