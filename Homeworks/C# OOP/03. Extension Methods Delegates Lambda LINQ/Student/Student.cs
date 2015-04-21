namespace Student
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }
                this.lastName = value;
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
                    throw new ArgumentNullException("Age cannot be 0 or less");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}", this.FirstName, this.LastName, this.Age);
        }

        public static void Information(IEnumerable<Student> collection)
        {
            foreach (var st in collection)
            {
                Console.WriteLine(st);
            }
            
        }
    }
}
