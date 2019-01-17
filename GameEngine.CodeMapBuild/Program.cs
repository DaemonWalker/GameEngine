using GameEngine.Map;
using GameEngine.Mod.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CodeMapBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = 15;
            var gms = new GmsModel();
            var floor = new MapModel(size);
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    if (i == 0 || i == size - 1)
                    {
                        floor.Map.Add(new MapUnit()
                        {
                            UnitType = typeof(Wall),
                            ScenarioObjectType = ScenarioObjectType.Wall,
                            PosX = i,
                            PosY = k
                        });
                    }
                    else
                    {
                        if (k == size - 1 || k == 0)
                        {
                            floor.Map.Add(new MapUnit()
                            {
                                UnitType = typeof(Wall),
                                ScenarioObjectType = ScenarioObjectType.Wall,
                                PosX = i,
                                PosY = k
                            });
                        }
                    }
                    if ((i % 4 == 0 && k % 4 == 0) & (i != 0 && k != 0))
                    {
                        floor.Map.Add(new MapUnit()
                        {
                            UnitType = typeof(Wall),
                            ScenarioObjectType = ScenarioObjectType.Wall,
                            PosX = i,
                            PosY = k
                        });
                    }
                }
            }
            floor.Map.Add(new MapUnit()
            {
                UnitType = typeof(Player),
                ScenarioObjectType = ScenarioObjectType.Player,
                PosX = 2,
                PosY = 2
            });
            floor.Map.Add(new MapUnit()
            {
                UnitType = typeof(StupidSlime),
                ScenarioObjectType = ScenarioObjectType.Monster,
                PosX = 10,
                PosY = 10
            });

            floor.Map.Add(new MapUnit()
            {
                UnitType = typeof(AngerySlime),
                ScenarioObjectType = ScenarioObjectType.Monster,
                PosX = 6,
                PosY = 6
            });

            floor.Map.Add(new MapUnit()
            {
                UnitType = typeof(BusinessMan),
                ScenarioObjectType = ScenarioObjectType.Monster,
                PosX = 7,
                PosY = 7
            });
            gms.Map.Add(floor);
            GmsModel.SaveMap(gms);
        }
    }
}
