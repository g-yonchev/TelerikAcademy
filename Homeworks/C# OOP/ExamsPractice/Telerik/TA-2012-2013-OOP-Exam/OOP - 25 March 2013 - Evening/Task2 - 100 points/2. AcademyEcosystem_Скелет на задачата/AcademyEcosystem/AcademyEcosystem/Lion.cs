namespace AcademyEcosystem
{
    using System;

    public class Lion : Carnivore, ICarnivore, IOrganism
    {
        public Lion(string name, Point location)
            : base(name, location, 6)
        {
            
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (this.Size * 2 >= animal.Size)
                {
                    this.Size++;
                    return base.GetMeatFromKillQuantity(animal);
                }
            }

            return 0;
        }
    }
}
