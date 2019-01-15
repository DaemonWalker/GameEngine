using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameModel
{
    public class InteractivityBase : ModelBase
    {
        public string Name { get; set; }
        public string Describe { get; set; }
        public virtual void Event(PlayerModel playerModel) { }
        public virtual void Ability(PlayerModel playerModel) { }
    }
}
