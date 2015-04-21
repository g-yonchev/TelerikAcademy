namespace AcademyEcosystem
{
    using System;

    public class Wolf : Carnivore, ICarnivore, IOrganism
    {
        public Wolf(string name, Point location)
            : base(name, location, 4)
        {

        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (this.Size >= animal.Size || animal.State == AnimalState.Sleeping)
                {
                    return base.GetMeatFromKillQuantity(animal);
                }
            }

            return 0;
        }
    }
}
