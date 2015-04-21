namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        //private const int Attack = 8;
        //private const int Defense = 8;
        //private const int HealthPoints = 25;
        //private const decimal Damage = 4.5M;

        public Griffin()
            : base(8, 8, 25, 4.5M)
            //: base(Griffin.Attack, Griffin.Defense, Griffin.HealthPoints, Griffin.Damage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
