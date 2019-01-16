using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Mod.Standard.Item
{
    public class Sward : ItemModel
    {
        public Sward()
        {
            this.Name = "铁剑";

            this.CostMoney = 40;
        }
        public override void Ability(PlayerModel playerModel)
        {
            playerModel.Attak = playerModel.Attak + 10;
        }
    }
}
