namespace Infestation
{
    using System;

    public class Supplement : ISupplement
    {
        private int powerEffect;
        private int healthEffect;
        private int aggressionEffect;

        public Supplement(int powerEffect, int healthEffect, int aggressionEffect)
        {
            this.AggressionEffect = aggressionEffect;
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
        }

        public void ReactTo(ISupplement otherSupplement)
        {
            throw new NotImplementedException();
        }

        public int PowerEffect { get; private set; }

        public int HealthEffect { get; private set; }

        public int AggressionEffect { get; private set; }

    }
}
