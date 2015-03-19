namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            { 
                return this.firstName; 
            }
            set 
            {
                ValidateName(value);

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
                ValidateName(value);

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}", this.FirstName, this.LastName);
        }

        private void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be null or empty");
            }
        }
    }
}
