using System;

namespace FightGame
{
    public static class UserInput
    {
        public static string GetUserName()
        {
            Console.WriteLine("Enter username: ");
            return Console.ReadLine();
        }

        public static string GetEnemyType()
        {
            Console.WriteLine("Select enemy type:" +
                " 1: Werewolf" +
                " 2: Vampire" +
                " 3: Ghost");
            return Console.ReadLine();
        }
        public static int GetEnemyState()
        {
            var random = new Random();
            return random.Next(1, 3);
        }
        public static object ProcessUserInput(int enemyType, int enemyState)
        {
            switch (enemyType)
            {
                case (int)(EnemyEnum.Werewolf):
                    {
                        var isTransformed = enemyState % 2 == 0;
                        return EnemyCreator.GetEnemyObject(isTransformed);
                    }
                case (int)(EnemyEnum.Vampire):
                    return enemyState % 2 == 0 ? EnemyCreator.GetEnemyObject(true, false) : EnemyCreator.GetEnemyObject(false, true); ;
                case (int)(EnemyEnum.Ghost):
                    {
                        bool isAngry = enemyState % 2 == 0 ? true : false;
                        return EnemyCreator.GetGhostEnemyObject(isAngry);
                    }
            }

            return null;
        }

        public static string GetUserAction()
        {
            Console.WriteLine("Enter choice: ");
            return Console.ReadLine();
        }


    }
}


