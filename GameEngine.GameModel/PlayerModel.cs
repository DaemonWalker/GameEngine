using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameModel
{
    public abstract class PlayerModel : AliveBase
    {
        public int CarryMoney { get; set; }
        public virtual int Lv => Exp / 100;
        public virtual int Crit => Lv;
        public virtual int CritRatio => 100;
        public virtual int Exp
        {
            get => this.exp;
            set
            {
                var old = this.exp;
                this.exp = value;
                OnExpChange?.Invoke(old, value);
            }
        }
        protected int exp;
        public event Action<int, int> OnExpChange;

        public virtual void PrepareFight() { }
    }
}
