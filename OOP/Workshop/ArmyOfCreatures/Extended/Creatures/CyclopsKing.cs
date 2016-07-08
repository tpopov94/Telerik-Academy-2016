namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class CyclopsKing : Creature
    {
        private const int cyclopsKingAttack = 17;
        private const int cyclopsKingDefence = 13;
        private const int cyclopsKingHealth = 70;
        private const int cyclopsKingDamage = 18;

        public CyclopsKing()
            : base(cyclopsKingAttack, cyclopsKingDefence, cyclopsKingHealth, cyclopsKingDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
