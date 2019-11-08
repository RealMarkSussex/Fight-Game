using System;

namespace FightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = PlayerCreator.GetPlayer();
            var enemyType = UserInput.GetEnemyType();
            var enemyState = UserInput.GetEnemyState();
            var parsedEnemyType = int.Parse(enemyType);
            var userInput = UserInput.ProcessUserInput(parsedEnemyType, enemyState);

            UserDialogue.InitialGreeting(player.Name, player.Damage, player.Armour, player.HitPoints);

            if (parsedEnemyType == (int)EnemyEnum.Werewolf)
            {
                var enemy = EnemyCreator.CreateWerewolf(userInput, player);
                var convertedEnemy = (BaseClass)enemy;
                var convertedPlayer = (BaseClass)player;
                Actions.PerformAction(convertedEnemy, convertedPlayer);
            }

            if (parsedEnemyType == (int)EnemyEnum.Vampire)
            {
                var enemy = EnemyCreator.CreateVampire(userInput, player);
                var convertedEnemy = (BaseClass)enemy;
                var convertedPlayer = (BaseClass)player;
                Actions.PerformAction(convertedEnemy, convertedPlayer);
            }

            if (parsedEnemyType == (int)EnemyEnum.Ghost)
            {
                var enemy = EnemyCreator.CreateGhost(userInput, player);
                var convertedEnemy = (BaseClass)enemy;
                var convertedPlayer = (BaseClass)player;
                Actions.PerformAction(convertedEnemy, convertedPlayer);
            }

            Console.ReadLine();
        }
    }
}
