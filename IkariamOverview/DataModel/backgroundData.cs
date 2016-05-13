using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkariamOverview
{
    public class BackgroundData
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public bool isCaptial { get; set; }   
        
        [JsonProperty("position")]
        public List<Position>  Bulidings { get; set; }
}

    public class Position
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public bool IsBusy { get; set; }

        public bool IsMaxLevel { get; set; }      
    }
}
