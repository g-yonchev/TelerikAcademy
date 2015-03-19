using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            :base(name, age, Gender.Male)
        {

        }
    }
}
