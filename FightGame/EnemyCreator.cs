namespace FightGame
{
    public static class EnemyCreator
    {
        public static Werewolf CreateWerewolf(object userInput, Player player)
        {
            Werewolf selectedEnemyType = (Werewolf)userInput;
            var state = selectedEnemyType.Transformed ? IsTransformed.Transformed.ToString() : IsTransformed.NonTransformed.ToString();  // ToDo: this can be replaced by the enum instead of using strings

            UserDialogue.SelectedEnemy(state, selectedEnemyType.Name);

            if (selectedEnemyType.Transformed)
            {
                selectedEnemyType.Damage += 3;

                UserDialogue.DamageIncrease(selectedEnemyType.Damage);
            }

            UserDialogue.ShowEnemyStats(selectedEnemyType.Damage, selectedEnemyType.Armour, selectedEnemyType.HitPoints);
            return selectedEnemyType;
        }

        public static Vampire CreateVampire(object userInput, Player player)
        {
            Vampire selectedEnemyType = (Vampire)userInput;
            var state = selectedEnemyType.Psychic ? VampireType.Psychic.ToString() : VampireType.Hybrid.ToString(); // ToDo: this can be replaced by the enum instead of using strings

            UserDialogue.SelectedEnemy(state, selectedEnemyType.Name);

            if (selectedEnemyType.Psychic)
            {
                selectedEnemyType.Damage += 3;

                UserDialogue.DamageIncrease(selectedEnemyType.Damage);
            }
            else if (selectedEnemyType.Hybrid)
            {
                selectedEnemyType.Armour += 3;
                UserDialogue.ArmorIncrease(selectedEnemyType.Armour);
            }

            UserDialogue.ShowEnemyStats(selectedEnemyType.Damage, selectedEnemyType.Armour, selectedEnemyType.HitPoints);
            return selectedEnemyType;
        }

        public static Ghost CreateGhost(object userInput, Player player)
        {
            Ghost selectedEnemyType = (Ghost)userInput;
            var state = selectedEnemyType.Angry ? GhostType.Angry.ToString() : GhostType.NotAngry.ToString();
            UserDialogue.SelectedEnemy(state, selectedEnemyType.Name);
            if (selectedEnemyType.Angry)
            {
                selectedEnemyType.Damage += 2;
                UserDialogue.DamageIncrease(selectedEnemyType.Damage);
            }
            else
            {
                selectedEnemyType.Damage -= 2;
                UserDialogue.DamageIncrease(selectedEnemyType.Damage);
            }
            UserDialogue.ShowEnemyStats(selectedEnemyType.Damage, selectedEnemyType.Armour, selectedEnemyType.HitPoints);
            return selectedEnemyType;
        }

        public static Werewolf GetEnemyObject(bool isTransformed)
        {
            var enemy = new Werewolf()
            {
                Name = "Werewolf",
                Damage = 5,
                Armour = 4,
                HitPoints = 10,
                Transformed = isTransformed,
                Alive = true
            };

            return enemy;
        }

        public static Vampire GetEnemyObject(bool isPsychic, bool isHybrid)
        {
            var enemy = new Vampire()
            {
                Name = "Vampire",
                Damage = 7,
                Armour = 2,
                HitPoints = 10,
                Hybrid = isHybrid,
                Psychic = isPsychic,
                Alive = true
            };

            return enemy;
        }

        public static Ghost GetGhostEnemyObject(bool isAngry)
        {
            var enemy = new Ghost()
            {
                Name = "Ghost",
                Damage = 5,
                Armour = 0,
                HitPoints = 10,
                Alive = true,
                Angry = true
            };

            return enemy;
        }
    }
}
