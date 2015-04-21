namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter, IMachine
    {
        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
            base.HealthPoints = 200;
        }

        public bool StealthMode { get; set; }

        public void ToggleStealthMode()
        {
            if (this.StealthMode)
            {
                this.StealthMode = false;
            }
            else
            {
                this.StealthMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));

            return result.ToString();
        }
    }
}
