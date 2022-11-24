using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinaideGetDigitalTwinInfo.Models
{
    public class Field
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public string name { get; set; }
        public double minValue { get; set; }
        public double maxValue { get; set; }
        public string type { get; set; }
        public string parent { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string measurement { get; set; }
        public string dataSource { get; set; }
    }
}
