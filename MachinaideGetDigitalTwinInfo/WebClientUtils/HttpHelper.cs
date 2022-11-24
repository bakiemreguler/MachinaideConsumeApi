using MachinaideGetDigitalTwinInfo.Models;
using MachinaideGetDigitalTwinInfo.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MachinaideGetDigitalTwinInfo.WebClientUtils
{
    class HttpHelper
    {
        public string GetToken()
        {
            using (WebClient client = new WebClient())
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Encoding = Encoding.UTF8;

                TokenRequest tokenRequest = new TokenRequest
                {
                    username = Constants.api_username,
                    password = Constants.api_password
                };

                string response_Token = client.UploadString(Constants.api_url_token, "POST", JsonConvert.SerializeObject(tokenRequest));
                string genericData_Token = JsonConvert.DeserializeObject<BaseResponse>(response_Token).data.data;
                List<_MainResponseToken> responseTokenParsed = JsonConvert.DeserializeObject<List<_MainResponseToken>>(genericData_Token);
                string token = responseTokenParsed.FirstOrDefault().token;

                return token;
            }
        }
        public _MainResponseDigitalTwin GetDigitalTwinInfo(string token)
        {
            using (WebClient client = new WebClient())
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("token", token);

                string response_DigitalTwinInfo = client.DownloadString(Constants.api_url_digital_twin_info);
                string genericData_DigitalTwinInfo = JsonConvert.DeserializeObject<BaseResponse>(response_DigitalTwinInfo).data.data;
                List<_MainResponseDigitalTwin> responseDigitalTwinInfoParsed = JsonConvert.DeserializeObject<List<_MainResponseDigitalTwin>>(genericData_DigitalTwinInfo);

                return responseDigitalTwinInfoParsed.FirstOrDefault();
            }
        }
    }
}
