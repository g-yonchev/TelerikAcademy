namespace SoftwareAcademy
{
    using System;
    using System.Text;

    public class OffsiteCourse : Course, IOffsiteCourse, ICourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name,teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                NullException.ValidateName(value, string.Format("Town of the {0}", this.GetType().Name));

                this.town = value;            
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}: ", this.GetType().Name);
            result.Append(base.ToString());

            result.AppendFormat("; Town={0}", this.Town);

            return result.ToString();
        }
    }
}
