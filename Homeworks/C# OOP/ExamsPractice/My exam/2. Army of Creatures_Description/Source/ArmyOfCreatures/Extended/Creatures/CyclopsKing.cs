namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class CyclopsKing : Creature
    {
        //private const int Attack = 17;
        //private const int Defense = 13;
        //private const int HealthPoints = 70;
        //private const decimal Damage = 18M;

        private const int AttackPointsWhenSkip = 3;
        private const int RoundsWhenDoubleAttack = 4;
        private const int RoundsInDoubleDamage = 1;

        public CyclopsKing()
            : base(17, 13, 70, 18M)
            //: base(CyclopsKing.Attack, CyclopsKing.Defense, CyclopsKing.HealthPoints, CyclopsKing.Damage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(CyclopsKing.AttackPointsWhenSkip));
            this.AddSpecialty(new DoubleAttackWhenAttacking(CyclopsKing.RoundsWhenDoubleAttack));
            this.AddSpecialty(new DoubleDamage(CyclopsKing.RoundsInDoubleDamage));
        }
    }
}
