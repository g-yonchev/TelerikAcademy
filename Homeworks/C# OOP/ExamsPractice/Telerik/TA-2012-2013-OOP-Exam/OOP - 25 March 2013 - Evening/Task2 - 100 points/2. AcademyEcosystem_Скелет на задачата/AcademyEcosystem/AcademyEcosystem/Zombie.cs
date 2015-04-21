namespace AcademyEcosystem
{
    using System;

    public class Zombie : Animal, IOrganism
    {
        public Zombie(string name, Point location)
            : base(name, location, int.MinValue)
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

        public override int GetMeatFromKillQuantity()
        {
            return base.GetMeatFromKillQuantity();
        }
    }
}
