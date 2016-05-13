using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IkariamOverview
{
    public class GetData
    {
        public string Url { get; set; }

        public string Server { get; set; } //= "http://s9-tw.ikariam.gameforge.com/index.php";

        public List<City> Cities { get; set; }

        public List<Resource> Resources { get; set; }

        public string SessionID { get; set; } //= "ecbpusduitsmdkbjb5bu6v02u0";

        public string IkariamID { get; set; }

        private object obj = new object();

        public GetData()
        {

        }

        public void Get()
        {
            if (this.Cities == null)
            {
                GetCities();
            }

            GetDataOfCities();

        }

        private void GetDataOfCities()
        {
            Resources = new List<Resource>();
            List<Task> tasks = new List<Task>();

            foreach (var city in Cities)
            {
                var task = Task.Factory.StartNew(() =>
                {
                    GetResource(city);
                });

                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray());
            Resources.Sort((x, y) => { return x.ID.CompareTo(y.ID); });
        }

        private Resource GetResource(City city)
        {
            this.Url = $"{this.Server}?view=updateGlobalData&currentCityId={city.ID}&backgroundView=city&ajax=1&cityId={city.ID}";
            var json = this.Request();
            var jarr = JsonConvert.DeserializeObject<JArray>(json);
            jarr = (JArray)jarr[0];
            var current = jarr[1]["headerData"]["currentResources"];
            var max = jarr[1]["headerData"]["maxResources"];

            var c = JsonConvert.DeserializeObject<Resource>(current.ToString());
            var m = JsonConvert.DeserializeObject<Resource>(max.ToString());

            Resource r = new Resource()
            {
                ID = city.ID,
                Name = city.Name,
                Wood = $"{c.Wood} / {int.Parse(m.Wood) - int.Parse(c.Wood)}",
                Wine = $"{c.Wine} / {int.Parse(m.Wine) - int.Parse(c.Wine)}",
                Marble = $"{c.Marble} / {int.Parse(m.Marble) - int.Parse(c.Marble)}",
                Crystal = $"{c.Crystal} / {int.Parse(m.Crystal) - int.Parse(c.Crystal)}",
                Sulphur = $"{c.Sulphur} / {int.Parse(m.Sulphur) - int.Parse(c.Sulphur)}",
            };

            lock (obj)
            {
                Resources.Add(r);
            }

            return r;
        }

        private void GetCities()
        {
            this.Url = $"{this.Server}?view=updateGlobalData&ajax=1";
            var json = this.Request();
            var jarr = JsonConvert.DeserializeObject<JArray>(json);
            jarr = (JArray)jarr[0];

            var jobj = jarr[1]["headerData"]["cityDropdownMenu"];
            //var bb = jobj.Where(c=>c.GetType() != typeof(string)).Select(c => JsonConvert.DeserializeObject<City>(c.First().ToString())).ToList();

            foreach (var obj in jobj)
            {
                try
                {
                    Cities = Cities ?? new List<City>();
                    var g = JsonConvert.DeserializeObject<City>((obj.First() ?? "").ToString());
                    Cities.Add(g);
                }
                catch (Exception)
                {

                }
            }
        }


        private string Request()
        {
            string responseString = "";
            WebRequest request = WebRequest.Create(this.Url);
            request.Timeout = 10000;
            request.Method = "GET";
            request.Headers["Cookie"] = $@"PHPSESSID={this.SessionID};ikariam={this.IkariamID}";
            request.ContentType = "text/html";

            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    responseString = reader.ReadToEnd();
                }
            }

            return responseString;

        }
    }
}
