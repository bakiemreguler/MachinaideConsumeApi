using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinaideGetDigitalTwinInfo.Utils
{
    public class Constants
    {
        private const string api_base_url = "https://vmi474601.contaboserver.net/api/v1.0/";
        public const string api_username = "dogrubilgi";
        public const string api_password = "dbilgi11235";
        public const string api_url_token = api_base_url + "auth/login";
        public const string api_url_digital_twin_info = api_base_url + "dt/";
    }
}
