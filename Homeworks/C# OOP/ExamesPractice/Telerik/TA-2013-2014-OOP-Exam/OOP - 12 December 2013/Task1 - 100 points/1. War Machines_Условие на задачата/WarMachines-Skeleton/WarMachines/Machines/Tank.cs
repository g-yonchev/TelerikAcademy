namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank, IMachine
    {
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints)
        {
            base.HealthPoints = 100;
            this.ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get 
            {
                return this.defenseMode;
            }
            set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
            else
            {
                this.DefenseMode = true;
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));

            return result.ToString();
        }
    }
}
