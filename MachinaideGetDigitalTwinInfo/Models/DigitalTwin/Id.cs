using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinaideGetDigitalTwinInfo.Models
{
    public class Id
    {
        [JsonProperty("$oid")]
        public string oid { get; set; }
    }
}
