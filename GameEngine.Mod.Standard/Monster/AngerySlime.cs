using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Mod.Standard
{
    public class AngerySlime : MonsterModel
    {
        public AngerySlime()
        {
            this.Name = "愤怒的史莱姆";
            this.Attak = 30;
            this.Defence = 0;

            this.GiveExp = 100;
            this.GiveMoney = 40;
        }

        public override void Ability(PlayerModel playerModel)
        {
            var player = playerModel as Player;

            player.ActDef = Convert.ToInt32(Math.Ceiling(player.ActDef * 0.75));
        }
    }
}
