namespace SchoolClasses
{
    using System;
    using System.Text;

    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name)
        {
            this.Name = name;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
            : this(name)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
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
                    throw new ArgumentNullException("Name cannot be null ot empty");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures must be positive number");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of exercises must be positive number");
                }
                this.numberOfExercises = value;
            }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Discipline: {0}", this.Name));
            result.AppendLine(string.Format("     lectures: {0}", this.NumberOfLectures));
            result.AppendLine(string.Format("     exercises: {0}", this.NumberOfExercises));

            return result.ToString();

        }
    }
}
