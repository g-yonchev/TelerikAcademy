namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;
        private AnimalType type;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Type = AnimalType.Animal;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be positive number");
                }

                this.age = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public AnimalType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public abstract string MakeSound();

        public override string ToString()
        {
            return string.Format("{0}: Gender - {1}. Name - {2}. Age - {3}. Sound {4}",
                this.Type, this.Gender, this.Name, this.Age, this.MakeSound());
        }

        public static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            double result = animals
                .Average(a => a.Age);

            return result;
        }
    }
}
