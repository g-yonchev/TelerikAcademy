using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            : base(firstName,lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Grade must be positive number");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Grade: {1:F2}", base.ToString(), this.Grade);
        }
    }
}
