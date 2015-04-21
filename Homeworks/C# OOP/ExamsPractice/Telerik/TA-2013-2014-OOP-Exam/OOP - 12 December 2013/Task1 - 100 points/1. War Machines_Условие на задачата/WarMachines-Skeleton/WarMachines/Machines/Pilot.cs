namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> listOfMachines;

        public Pilot(string name)
        {
            this.listOfMachines = new List<IMachine>();
            this.Name = name;
        }

        public string Name
        {
            get 
            { 
                return this.name;
            }
            private set 
            {
                ValidatorNullException<string>.ValidateProperty<string>(value);

                this.name = value;
            }
        }

        public List<IMachine> ListOfMachines
        {
            get
            {
                return new List<IMachine>(this.listOfMachines);
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.listOfMachines.Add(machine);

            var sortedList = this.listOfMachines
                .OrderBy(x => x.HealthPoints)
                .ThenBy(x => x.Name)
                .ToList();

            this.listOfMachines = sortedList;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.Append(
                string.Format("{0} - {1} {2}",
                this.Name,
                this.ListOfMachines.Count > 0 ? this.ListOfMachines.Count.ToString() : "no",
                this.ListOfMachines.Count == 1 ? "machine" : "machines"));

            if (this.listOfMachines.Count > 0)
            {
                result.AppendLine();
            }

            for (int i = 1; i <= this.ListOfMachines.Count; i++)
            {
                
                if (i == this.ListOfMachines.Count)
                {
                    result.Append(this.ListOfMachines[i-1].ToString());
                }
                else
                {
                    result.AppendLine(this.ListOfMachines[i - 1].ToString());
                }
            }

            return result.ToString();
        }
    }
}
