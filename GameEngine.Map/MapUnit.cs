using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Map
{
    public class MapUnit
    {
        public Type UnitType { get; set; }
        public ScenarioObjectType ScenarioObjectType { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
    }
}
