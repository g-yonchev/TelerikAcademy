using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender)
            :base(name, age, gender)
        {
            this.Type = AnimalType.Frog;
        }

        public override string MakeSound()
        {
            return "~Froggy~";
        }
    }
}
