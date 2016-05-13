using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkariamOverview
{
    public class FillTab
    {
        public static void FillResource(TabPage tab, DataGridView gv)
        {
           
            gv.DataSource = new List<BackgroundData>() { JsonConvert.DeserializeObject<BackgroundData>(Program.f) };            
            tab.Controls.Add(gv);                
        }

        public static void FillBuilding(TabPage tab,DataGridView gv)
        {            
            gv.DataSource = new List<BackgroundData>() { JsonConvert.DeserializeObject<BackgroundData>(Program.f), JsonConvert.DeserializeObject<BackgroundData>(Program.f) };
            tab.Controls.Add(gv);
        }
    }
}
