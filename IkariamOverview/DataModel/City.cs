using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkariamOverview
{
    public class City
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Coords { get; set; }

        public TradeGoodType TradeGood { get; set; }

        public string Relationship { get; set; }

    }
}
