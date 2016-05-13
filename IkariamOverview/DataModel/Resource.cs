using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkariamOverview
{
    public class Resource
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Citizens { get; set; }

        public long Populiation { get; set; }

        [JsonProperty("resource")]
        public string Wood { get; set; }

        [JsonProperty("1")]
        public string Wine { get; set; }

        [JsonProperty("2")]
        public string Marble { get; set; }

        [JsonProperty("3")]
        public string Crystal { get; set; }

        [JsonProperty("4")]
        public string Sulphur { get; set; }
    }
}
