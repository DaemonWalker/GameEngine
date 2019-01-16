using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Mod.Standard
{
    public class Player : PlayerModel
    {
        public Player()
        {
            this.Name = "Daemon";
            this.Exp = 0;
            this.HP = 1000;
            this.Attak = 10;
            this.Defence = 10;
            this.Describe = "";

            var rand = new Random();

            this.LvlIncAtk = 10 + rand.Next(10);
            this.LvlIncDef = 10 + rand.Next(10);
            this.LvlIncHp = 10 + rand.Next(10);

            this.OnExpChange += ExpChange;
        }
        public int LvlIncHp { get; set; }
        public int LvlIncAtk { get; set; }
        public int LvlIncDef { get; set; }
        public int ActualHP { get; set; }
        public int ActualAtk { get; set; }
        public int ActDef
        {
            get; set;

        }
        private void ExpChange(int before, int after)
        {
            var beforeLv = ExpMap.GetLvl(before);
            var afterLv = ExpMap.GetLvl(after);
            var lv = afterLv - beforeLv;

            this.HP = this.HP + (lv * LvlIncHp);
            this.Attak = this.Attak + (lv * LvlIncAtk);
            this.Defence = this.Defence + (lv * LvlIncDef);
        }

        public void CopyNumber()
        {
            this.ActDef = this.Defence;
            this.ActualAtk = this.Attak;
            this.ActualHP = this.HP;
        }

        public override void PrepareFight()
        {
            CopyNumber();

        }
    }
}
