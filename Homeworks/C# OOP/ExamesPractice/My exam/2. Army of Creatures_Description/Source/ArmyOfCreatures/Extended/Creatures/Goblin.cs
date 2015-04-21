namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;

    public class Goblin : Creature
    {
        //private const int Attack = 4;
        //private const int Defense = 2;
        //private const int HealthPoints = 5;
        //private const decimal Damage = 1.5M;

        public Goblin()
            : base(4, 2, 5, 1.5M)
            //: base(Goblin.Attack, Goblin.Defense, Goblin.HealthPoints, Goblin.Damage)
        {

        }
    }
}
