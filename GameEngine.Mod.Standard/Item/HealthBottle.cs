using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Mod.Standard.Item
{
    public class HealthBottle : ItemModel
    {
        public HealthBottle()
        {
            this.Name = "血瓶";
            this.CostMoney = 10;
        }

        public override void Ability(PlayerModel playerModel)
        {
            playerModel.HP = playerModel.HP + 300;
        }
    }
}
