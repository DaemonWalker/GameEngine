using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Mod.Demo
{
    public class ExpMap
    {
        public static int GetLvl(int exp)
        {
            return LvlMap.IndexOf(LvlMap.First(p => p >= exp));
        }
        private static List<int> LvlMap = GetLvlMap().Take(1000).ToList();
        private static IEnumerable<int> GetLvlMap()
        {
            var baseExp = 0;
            var baseStep = 100;
            var upStep = 50;
            while (true)
            {
                yield return baseExp;
                baseExp = baseExp + baseStep;
                baseStep = baseStep + upStep;
            }
        }
    }
}
