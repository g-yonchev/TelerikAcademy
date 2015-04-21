namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WarMachines.Interfaces;

    public abstract class Machine: IMachine
    {
        private string name;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IPilot pilot;
        private IList<string> targets;

        public Machine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
        }

        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                ValidatorNullException<string>.ValidateProperty<string>(value);

                this.name = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                ValidatorNullException<double>.ValidateProperty<double>(value);

                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                ValidatorNullException<double>.ValidateProperty<double>(value);

                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            protected set
            {
                ValidatorNullException<double>.ValidateProperty<double>(value);

                this.defensePoints = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                this.pilot = value;
            }
        }
        
        public IList<string> Targets
        {
            get 
            {
                return this.targets;
            }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("- {0}", this.Name));
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            result.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            result.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            result.AppendLine(string.Format(" *Targets: {0}", (this.targets.Count > 0) ? string.Join(", ", this.targets) : "None"));
            return result.ToString();
        }
    }
}
