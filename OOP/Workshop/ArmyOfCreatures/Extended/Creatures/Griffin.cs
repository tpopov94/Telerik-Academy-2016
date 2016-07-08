namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        private const int griffinAttack = 8;
        private const int griffinDefence = 8;
        private const int griffinHealth = 25;
        private const decimal griffinDamage = 4.5m;

        public Griffin()
            : base(griffinAttack, griffinDefence, griffinHealth, griffinDamage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
