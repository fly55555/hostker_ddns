using hostker_ddns;
using hostker_ddns.api;
using hostker_ddns.window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostker_ddns
{
    class Program
    {

        public static void TestLogin()
        {
            var domain = "fly55555.com";
            var email = "1598514620@qq.com";
            var key_code = "0219a39beac1f81c56afbcb6ddd3769684f25073e3dcbe01fcdb8e3f188f74c2";

            var dns_manage = new hostker_dns_api(email, key_code);
            var records = dns_manage.get_records(domain);

            var id = dns_manage.add_record(domain, "aabb", "A", "111.111.111.111");

            if (!string.IsNullOrEmpty(id))
            {
                var delOk = dns_manage.delete_record(id);
            }

            var isOk = dns_manage.edit_record("40066", "58.61.154.231");



        }


        [STAThread]
        static void Main(string[] args)
        {
            //TestLogin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
