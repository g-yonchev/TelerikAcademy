namespace PersonProblem
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.ValidateNullString(value, "Name cannot be null or empty");

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.ValidateNegativeValue(value, "Age cannot be negative");

                this.age = value;

            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("Name: {0}", this.Name));
            result.AppendLine(string.Format("Age: {0}", this.Age == null ? "not specified" : this.Age.ToString()));

            return result.ToString().Trim();
        }

        private void ValidateNegativeValue(int? value, string message)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }

        }

        private void ValidateNullString(string value, string message)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
