using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinaideGetDigitalTwinInfo.Models
{
    public class Machine
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string parent { get; set; }

        [JsonProperty("@type")]
        public string displayName { get; set; }
        public string description { get; set; }
        public string photoUrl { get; set; }
        public List<Content> contents { get; set; }
        public List<string> measurements { get; set; }
    }
}
