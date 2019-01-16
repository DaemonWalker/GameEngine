using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Map
{
    public class Scenario
    {
        public virtual int Size => 15;
        public ScenarioObject[,] Map;
        public Scenario(int pixelCount,string[,] map)
        {
            if (map.GetLength(0) != Size || map.GetLength(1) != Size)
            {
                throw new Exception("地图尺寸与Mod画布尺寸不同");
            }
            Map = new ScenarioObject[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int k = 0; k < Size; k++)
                {
                    var type = Type.GetType(map[i, k]);
                    Map[i, k] = new ScenarioObject()
                    {
                        Model = Activator.CreateInstance(type) as ModelBase,
                        PosX
                } }
        }
    }
}
