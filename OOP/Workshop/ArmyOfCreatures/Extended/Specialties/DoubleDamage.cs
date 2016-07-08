namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Specialties;
    using System;
    using System.Globalization;

    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            //if (rounds <= 0)
            //{
            //    throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            //}

            this.Rounds = rounds;
        }


        // Properties
        public int Rounds
        {
            get { return this.rounds; }
            protected set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("The rounds should be between [1...10]");
                }
                this.rounds = value;
            }
        }

        public override decimal ChangeDamageWhenAttacking(Logic.Battles.ICreaturesInBattle attackerWithSpecialty, Logic.Battles.ICreaturesInBattle defender, decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.rounds > 0)
            {
                // Effect expires after fixed number of rounds
                this.rounds--;
                return currentDamage * 2M;
            }

            return currentDamage;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
