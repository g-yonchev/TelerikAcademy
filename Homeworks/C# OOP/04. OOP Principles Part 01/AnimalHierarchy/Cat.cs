using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender gender)
            :base(name, age, gender)
        {
            this.Type = AnimalType.Cat;
        }

        public override string MakeSound()
        {
            return "~Myrrrr~";
        }
    }
}
