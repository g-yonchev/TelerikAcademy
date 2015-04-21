using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
            :base(name, age, gender)
        {
            this.Type = AnimalType.Dog;
        }

        public override string MakeSound()
        {
            return "~Bauuu~";
        }
    }
}
