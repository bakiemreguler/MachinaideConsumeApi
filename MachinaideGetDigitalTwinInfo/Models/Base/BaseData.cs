using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinaideGetDigitalTwinInfo.Models
{
    public class BaseData
    {
        public string data { get; set; }
        public bool success { get; set; }
        public BaseMessage message { get; set; }
    }
}
