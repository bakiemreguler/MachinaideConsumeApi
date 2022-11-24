using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinaideGetDigitalTwinInfo.Models
{
    public class Content
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string parent { get; set; }
        public List<Sensor> sensors { get; set; }
        public object visual { get; set; }
        public string deploymentTime { get; set; }
        public Brand brand { get; set; }
    }
}
