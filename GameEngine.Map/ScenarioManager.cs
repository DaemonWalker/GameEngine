using GameEngine.GameModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace GameEngine.Map
{
    public class ScenarioManager
    {
        public List<Scenario> Scenarios { get; } = new List<Scenario>();
        private ImageManager imageManager;

        private ScenarioManager(GmsModel gms, PlayerModel playerModel, IEnumerable<string> imgPath)
        {
            this.imageManager = new ImageManager(imgPath);
            foreach (var item in gms.Map)
            {
                Scenarios.Add(new Scenario(item, playerModel, imageManager));
            }
        }
        public static ScenarioManager Load(string fileName, PlayerModel playerModel, IEnumerable<string> imgPath)
        {
            var data = File.ReadAllText(fileName);
            var gms = JsonConvert.DeserializeObject<GmsModel>(data);
            return new ScenarioManager(gms, playerModel, imgPath);
        }
    }
}
