using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Map
{
    public class MapModel
    {
        public List<MapUnit> Map { get; set; }
        public int Size { get; set; }
        public MapModel(int size)
        {
            Map = new List<MapUnit>();
            Size = size;
        }
    }
}
