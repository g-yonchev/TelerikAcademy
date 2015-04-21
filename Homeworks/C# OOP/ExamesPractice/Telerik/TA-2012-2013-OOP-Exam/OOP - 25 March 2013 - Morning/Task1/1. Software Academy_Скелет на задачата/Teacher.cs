namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public ICollection<ICourse> Courses
        {
            get
            {
                return new List<ICourse>(this.courses);
            }
            private set
            {
                
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                NullException.ValidateName(value, this.GetType().Name);

                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Teacher: Name={0}", this.Name);
            
            if (this.Courses.Count > 0)
            {
                result.AppendFormat("; Courses=[{0}]", string.Join(", ", this.Courses.Select(x => x.Name)));
            }

            return result.ToString();
        }
    }
}
