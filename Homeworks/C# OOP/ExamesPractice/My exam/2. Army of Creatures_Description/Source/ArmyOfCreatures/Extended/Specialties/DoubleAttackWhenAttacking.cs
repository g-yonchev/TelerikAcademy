namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    public class DoubleAttackWhenAttacking : Specialty
    {
        private int rounds;

        public DoubleAttackWhenAttacking(int rounds)
        {
            if (rounds <= 0)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }

            this.rounds = rounds;
        }

        public override void ApplyWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty,
            ICreaturesInBattle defender)
        {
            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return;
            }

            attackerWithSpecialty.CurrentAttack *= 2;
            this.rounds--;

            // I don't remove invoking base method, because in future could be added some different logic.
            base.ApplyWhenAttacking(attackerWithSpecialty, defender);
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
