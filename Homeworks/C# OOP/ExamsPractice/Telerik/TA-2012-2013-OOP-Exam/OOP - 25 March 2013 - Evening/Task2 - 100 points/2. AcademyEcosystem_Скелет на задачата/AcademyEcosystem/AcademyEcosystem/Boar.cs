namespace AcademyEcosystem
{
    using System;

    public class Boar : Carnivore, ICarnivore, IHerbivore, IOrganism
    {
        private int biteSize;

        public Boar(string name, Point location)
            : base(name,location, 4)
        {
            this.biteSize = 2;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(this.biteSize);
            }

            return 0;
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (this.Size >= animal.Size)
                {
                    return base.GetMeatFromKillQuantity(animal);
                }
            }

            return 0;
        }
    }
}
