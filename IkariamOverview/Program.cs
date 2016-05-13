using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace IkariamOverview
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            var o = JsonConvert.DeserializeObject<BackgroundData>(f);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }

        public static string f = @"            
 {
                ""name"": ""賀坦特領地"",
                ""id"": ""53785"",
                ""phase"": 5,
                ""isCapital"": true,
                ""ownerId"": ""18912"",
                ""ownerName"": ""walylay"",
                ""islandId"": ""3696"",
                ""islandName"": ""Echeytia"",
                ""islandXCoord"": ""27"",
                ""islandYCoord"": ""85"",
                ""buildingSpeedupActive"": 1,
                ""showPirateFortressBackground"": 1,
                ""showPirateFortressShip"": 1,
                ""underConstruction"": -1,
                ""endUpgradeTime"": -1,
                ""startUpgradeTime"": -1,
                ""position"": [                   
                    {
                        ""name"": ""光學儀器商館"",
                        ""level"": ""32"",
                        ""isBusy"": false,
                        ""canUpgrade"": false,
                        ""isMaxLevel"": true,
                        ""building"": ""optician""
                    }
                ],
                ""spiesInside"": null,
                ""cityLeftMenu"": {
                    ""visibility"": {
                        ""military"": 1,
                        ""espionage"": 0,
                        ""resourceShop"": 1,
                        ""slot1"": 1,
                        ""slot2"": 1,
                        ""slot3"": 0,
                        ""slot4"": 1
                    },
                    ""ownCity"": 1
                },
                ""ambrosiaFountain"": ""fountain_inactive"",
                ""walkers"": [],
                ""dailyTasks"": ""2"",
                ""cityCinema"": ""invisible""
            }";
    }
}
