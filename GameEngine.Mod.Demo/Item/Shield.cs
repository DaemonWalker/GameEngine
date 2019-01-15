using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Mod.Demo.Item
{
    public class Shield : ItemModel
    {
        public Shield()
        {
            this.Name = "先锋盾";
            this.Describe = "看起来很厚实的盾牌，防御+10";

            this.
        }
        public override void Ability(PlayerModel playerModel)
        {
            var player = playerModel as Player;
            player.Defence = player.Defence + 10;
        }
    }
}
