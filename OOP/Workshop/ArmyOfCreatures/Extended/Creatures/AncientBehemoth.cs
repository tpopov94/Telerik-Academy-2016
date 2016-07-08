namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        private const int ancientBehemothAttack = 19;
        private const int ancientBehemothDefence = 19;
        private const int ancientBehemothHealth = 300;
        private const int ancientBehemothDamage = 40;

        public AncientBehemoth()
            : base(ancientBehemothAttack, ancientBehemothDefence, ancientBehemothHealth, ancientBehemothDamage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }
    }
}
