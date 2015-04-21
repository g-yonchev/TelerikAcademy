namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private List<SchoolClass> schoolClasses;
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.schoolClasses = new List<SchoolClass>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public List<SchoolClass> SchoolClasses
        {
            get
            {
                return new List<SchoolClass>(this.schoolClasses);
            }
        }

        public void AddClass(SchoolClass schoolClass)
        {
            this.schoolClasses.Add(schoolClass);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("SCHOOL: {0}\n", this.Name));

            foreach (SchoolClass currentClass in this.SchoolClasses)
            {
                result.AppendLine(currentClass.ToString());
            }

            return result.ToString();
        }
    }
}
