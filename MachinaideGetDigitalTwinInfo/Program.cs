using MachinaideGetDigitalTwinInfo.Models;
using MachinaideGetDigitalTwinInfo.Utils;
using MachinaideGetDigitalTwinInfo.WebClientUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace MachinaideGetDigitalTwinInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpHelper httpHelper = new HttpHelper();

            string token = httpHelper.GetToken();
            _MainResponseDigitalTwin digitalTwinInfo = httpHelper.GetDigitalTwinInfo(token);

            Console.ReadKey();
        }
    }
}
