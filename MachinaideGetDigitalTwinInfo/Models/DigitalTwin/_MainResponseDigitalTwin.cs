using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinaideGetDigitalTwinInfo.Models
{
    public class _MainResponseDigitalTwin
    {
        public Id _id { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string factoryName { get; set; }
        public string name { get; set; }
        public string photoUrl { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public List<ProductionLine> productionLines { get; set; }
        public string bucket { get; set; }
    }
}

