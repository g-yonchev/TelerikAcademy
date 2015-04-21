namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        // Use these constats in constructor, but compiler shows warnings. For another creatures is the same.

        //private const int Attack = 19;
        //private const int Defense = 19;
        //private const int HealthPoints = 300;
        //private const decimal Damage = 40M;

        private const int RoundsInDoubleDefense = 5;
        private const int PercentageForReduceEnemyDefense = 80;

        public AncientBehemoth()
            : base(19, 19, 300, 40M)
            //: base(AncientBehemoth.Attack, AncientBehemoth.Defense, AncientBehemoth.HealthPoints, AncientBehemoth.Damage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(AncientBehemoth.PercentageForReduceEnemyDefense));
            this.AddSpecialty(new DoubleDefenseWhenDefending(AncientBehemoth.RoundsInDoubleDefense));
        }
    }
}
