namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;

    public class Goblin : Creature
    {
        private const int goblinAttack = 4;
        private const int goblinDefence = 2;
        private const int goblinHealth = 5;
        private const decimal goblinDamage = 1.5m;

        public Goblin()
            : base(goblinAttack, goblinDefence, goblinHealth, goblinDamage)
        {

        }
    }
}
