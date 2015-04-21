namespace Infestation
{
    using System;

    public class Weapon : Supplement, ISupplement
    {
        public const int PowerEffect = 10;
        public const int HealthEffect = 0;
        public const int AggressionEffect = 3;

        public Weapon()
            : base(Weapon.PowerEffect, Weapon.HealthEffect, Weapon.AggressionEffect)
        {

        }
    }
}
