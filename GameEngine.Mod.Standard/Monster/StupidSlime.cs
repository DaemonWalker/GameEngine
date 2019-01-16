using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Mod.Standard
{
    class StupidSlime : MonsterModel
    {
        public StupidSlime()
        {
            this.Name = "傻傻的史莱姆";
            this.Attak = 15;
            this.Defence = 0;
            this.HP = 100;

            this.GiveExp = 10;
            this.GiveMoney = 5;
        }
    }
}
