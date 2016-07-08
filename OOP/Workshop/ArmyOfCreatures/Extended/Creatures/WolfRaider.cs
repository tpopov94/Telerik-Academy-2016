namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class WolfRaider : Creature
    {
        private const int wolfRaiderAttack = 8;
        private const int wolfRaiderDefence = 5;
        private const int wolfRaiderHealth = 10;
        private const decimal wolfRaiderDamage = 3.5m;

        public WolfRaider()
            : base(wolfRaiderAttack, wolfRaiderDefence, wolfRaiderHealth, wolfRaiderDamage)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }

    }
}
