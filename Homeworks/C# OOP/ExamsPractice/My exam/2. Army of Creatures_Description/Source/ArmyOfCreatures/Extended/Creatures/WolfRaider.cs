namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class WolfRaider : Creature
    {
        //private const int Attack = 8;
        //private const int Defense = 5;
        //private const int HealthPoints = 10;
        //private const decimal Damage = 3.5M;
        private const int RoundsInDoubleDamage = 7;

        public WolfRaider()
            : base(8, 5, 10, 3.5M)
            //: base(WolfRaider.Attack, WolfRaider.Defense, WolfRaider.HealthPoints, WolfRaider.Damage)
        {
            this.AddSpecialty(new DoubleDamage(WolfRaider.RoundsInDoubleDamage));
        }
    }
}
