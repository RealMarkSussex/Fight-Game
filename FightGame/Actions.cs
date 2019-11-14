using System;

namespace FightGame
{
    public static class Actions
    {
        private static string Attack(ref BaseClass attacked, ref BaseClass attacker)
        {
            if (attacker.Damage / 2 < attacked.Armour)
            {
                attacked.Armour -= attacker.Damage / 2;
                return attacked.Armour.ToString() + " armour left on " + attacked.Name;
            }
            attacked.HitPoints -= attacker.Damage - attacked.Armour * 2;
            attacked.Armour = 0;

            if (attacked.HitPoints < 0)
            {
                attacked.Alive = false;
                return attacked.Name + " is dead";
            }
            return attacked.HitPoints.ToString() + " hitpoints left and 0 Armour on " + attacked.Name;

        }

        private static string Defend(ref BaseClass defender)
        {
            defender.HitPoints += defender.Armour + 6;
            return defender.HitPoints.ToString() + " hitpoints left on " + defender.Name;
        }

        public static void PerformAction(BaseClass convertedEnemy, BaseClass convertedPlayer)
        {
            while (convertedPlayer.Alive && convertedEnemy.Alive)
            {
                var choice = UserInput.GetUserAction();
                Console.WriteLine(choice == "attack"
                    ? Actions.Attack(ref convertedEnemy, ref convertedPlayer)
                    : Actions.Defend(ref convertedPlayer));
                if (!convertedPlayer.Alive)
                {
                    Console.WriteLine("You lose");
                    break;
                }
                if (!convertedEnemy.Alive)
                {
                    Console.WriteLine("You win");
                    break;
                }
                var random = new Random();
                var randEnemyChoice = random.Next(1, 3);
                Console.WriteLine(randEnemyChoice == 1
                    ? "enemy attacks " + Actions.Attack(ref convertedPlayer, ref convertedEnemy)
                    : "enemy defends " + Actions.Defend(ref convertedEnemy));
            }
        }
    }
}
