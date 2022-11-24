using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace MachinaideGetDigitalTwinInfo.Models
{
    public class ProductionLine
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public string type { get; set; }
        public string parent { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string photoUrl { get; set; }
        public List<Machine> machines { get; set; }
        public string section { get; set; }
    }
}
