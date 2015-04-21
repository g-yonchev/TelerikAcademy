using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public abstract class Carnivore : Animal
    {
        public Carnivore(string name, Point location, int size)
            : base(name,location, size)
        {

        }

        public override void Update(int timeElapsed)
        {
            if (this.State == AnimalState.Sleeping)
            {
                if (timeElapsed >= sleepRemaining)
                {
                    this.Awake();
                }
                else
                {
                    this.sleepRemaining -= timeElapsed;
                }
            }

            base.Update(timeElapsed);
        }

        public virtual int GetMeatFromKillQuantity(Animal animal)
        {
            if (animal.GetType() == typeof(Zombie))
            {
                return 10;
            }
            else
            {
                return animal.GetMeatFromKillQuantity();
            }
        }
    }
}
