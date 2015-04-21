namespace SoftwareAcademy
{
    using System;
    using System.Text;

    public class LocalCourse : Course, ILocalCourse, ICourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                NullException.ValidateName(value, string.Format("Lab of the {0}", this.GetType().Name));

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}: ", this.GetType().Name);
            result.Append(base.ToString());

            result.AppendFormat("; Lab={0}", this.Lab);
            
            return result.ToString();
        }
    }
}
