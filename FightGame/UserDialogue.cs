using System;

namespace FightGame
{
    public static class UserDialogue
    {
        public static void InitialGreeting(string name, int damage, int armour, int hitPoints)
        {
            Console.WriteLine($"Greetings, {name}!. Your random stats are: " +
                $"Damage: {damage}, " +
                $"Armour: {armour}, " +
                $"Hit Points: {hitPoints}");
        }

        public static void SelectedEnemy(string state, string name)
        {
            Console.WriteLine($"You selected a {state} {name} as your enemy");
        }

        public static void DamageIncrease(int damage)
        {
            Console.WriteLine($"The Damage of your enemy has increased to {damage}");
        }

        public static void ArmorIncrease(int armour)
        {
            Console.WriteLine($"The Armour of your enemy has increased to {armour}");
        }

        public static void ShowEnemyStats(int damage, int armour, int hitPoints)
        {
            Console.WriteLine($"Enemy Stats: Damage:{damage}, Armour:{armour}, Hit Points:{hitPoints}");
        }
    }
}
