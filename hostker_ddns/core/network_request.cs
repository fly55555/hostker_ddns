using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hostker_ddns.core
{
    public class network_request
    {
        public string url { get; set; }

        public string content_type { get; set; }

        public HttpClient _http_client { get; set; }

        public Dictionary<string, string> get_dict { get; set; }

        public Dictionary<string, string> post_dict { get; set; }

        public Dictionary<string, string> head_padd { get; set; }


        public network_request()
        {
            get_dict = new Dictionary<string, string>();
            post_dict = new Dictionary<string, string>();
            head_padd = new Dictionary<string, string>();

            content_type = "application/x-www-form-urlencoded";

            _http_client = new HttpClient();

            //_http_client.MaxResponseContentBufferSize = 256000;
            //_http_client.DefaultRequestHeaders.Add("Accept", "*/*");
            //_http_client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            //_http_client.DefaultRequestHeaders.Add("Accept-Language", "zh-cn,zh;q=0.8,en-us;q=0.5,en;q=0.3");
            //_http_client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            //_http_client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0");
        }

        private string get_request_result(string url_string, string post_data = "")
        {
            var http_content = new StringContent(post_data);
            http_content.Headers.ContentType = new MediaTypeHeaderValue(content_type);

            foreach (var item in head_padd)
            {
                _http_client.DefaultRequestHeaders.Add(item.Key, item.Value);
            }

            if (url_string.StartsWith("https"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) =>
                {
                    return true; //总是接受  
                });
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            }

            var response = _http_client.PostAsync(url_string, http_content).Result;

            //var cookie = response.Headers.GetValues("Set-Cookie");

            return response.Content.ReadAsStringAsync().Result;
        }

        public string get_request()
        {
            var get_list = new List<string>();

            foreach (var item in get_dict)
            {
                get_list.Add($"{item.Key}={item.Value}");
            }

            var temp_url = $"{url}{string.Join("&", get_list)}";

            /**************************************************************/
            /**************************************************************/
            /**************************************************************/

            var post_list = new List<string>();

            foreach (var item in post_dict)
            {
                post_list.Add($"{item.Key}={item.Value}");
            }

            var post_data = string.Join("&", post_list);

            var request = get_request_result(temp_url, post_data);

            url = "";
            get_dict.Clear();
            post_dict.Clear();
            head_padd.Clear();

            return request;
        }


    }
}
