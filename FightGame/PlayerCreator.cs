using System;

namespace FightGame
{
    public static class PlayerCreator
    {
        public static Player GetPlayer()
        {
            var random = new Random();

            var player = new Player()
            {
                Name = UserInput.GetUserName(),
                Damage = random.Next(5, 9),
                Armour = random.Next(3, 7),
                HitPoints = 10,
                Alive = true
            };
            return player;
        }
    }
}
