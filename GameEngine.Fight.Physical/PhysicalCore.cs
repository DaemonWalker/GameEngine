using GameEngine.GameModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameEngine.Fight.Physical
{
    public abstract class PhysicalCore
    {
        public int RoundDelay = 300;
        protected virtual void PlayerAttackJudge(PlayerModel player, MonsterModel monster) { }
        protected virtual void MonsterAttackJudge(MonsterModel monster, PlayerModel player) { }
        public abstract void ShowWinResult(PlayerModel player, MonsterModel monster);
        public abstract void ShowLoseResult(PlayerModel player, MonsterModel monster);
        public int WaitMillionSecond { get; set; } = 300;
        protected virtual int CalculateDamage(int atk, int def, object obj)
        {
            return Math.Max(atk - def, 0);
        }
        protected int CalculateDamage(int atk, int def)
        {
            return CalculateDamage(atk, def, null);
        }
        public void Fight(PlayerModel player, MonsterModel monster)
        {
            player.PrepareFight();
            player.Ability(player);
            monster.Ability(player);

            while (player.HP > 0 && monster.HP > 0)
            {
                PlayerAttackJudge(player, monster);

                monster.HP = monster.HP - CalculateDamage(player.Attak, monster.Defence);
                if (monster.HP <= 0)
                {
                    monster.HP = 0;
                    break;
                }

                player.HP = player.HP - CalculateDamage(monster.Attak, player.Defence);
                if (player.HP <= 0)
                {
                    player.HP = 0;
                }
                Thread.Sleep(WaitMillionSecond);
            }

            if (player.HP == 0)
            {
                ShowLoseResult(player, monster);
            }
            else
            {
                ShowWinResult(player, monster);
            }
        }
    }
}
