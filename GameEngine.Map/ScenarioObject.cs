using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Map
{
    public class ScenarioObject
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public ScenarioObjectType ScenarioObjectType { get; set; }
        public ModelBase Model { get; set; }
    }
}
