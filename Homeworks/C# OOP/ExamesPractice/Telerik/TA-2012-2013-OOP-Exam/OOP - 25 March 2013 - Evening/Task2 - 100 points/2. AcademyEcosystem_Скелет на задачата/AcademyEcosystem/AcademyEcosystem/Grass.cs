namespace AcademyEcosystem
{
    using System;

    public class Grass : Plant, IOrganism
    {
        private const int InitialSize = 2;

        public Grass(Point location)
            : base(location, Grass.InitialSize)
        {
        }

        public override void Update(int time)
        {
            this.Size += time;
            base.Update(time);
        }
    }
}
