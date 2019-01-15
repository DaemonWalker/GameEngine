using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameModel
{
    public class MonsterModel : AliveBase
    {
        public int GiveMoney { get; set; }
        public int GiveExp { get; set; }
    }
}
