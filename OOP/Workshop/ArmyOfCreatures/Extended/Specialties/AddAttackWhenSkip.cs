namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Specialties;
    using System;
    using System.Globalization;

    public class AddAttackWhenSkip : Specialty
    {
        private int attackToAdd;

        public AddAttackWhenSkip(int attackToAdd)
        {
            this.AttackToAdd = attackToAdd;
        }

        public int AttackToAdd
        {
            get { return this.attackToAdd; }
            protected set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Attack to add should be between 1 and 10 inclusive !!");
                }
                this.attackToAdd = value;
            }
        }

        public override void ApplyOnSkip(Logic.Battles.ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.AttackToAdd;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.AttackToAdd);
        }
    }
}
