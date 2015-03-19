namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Human, ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string name)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(disciplines);
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void AddDiscipline(params Discipline[] disciplines)
        {
            for (int i = 0; i < disciplines.Length; i++)
            {
                this.disciplines.Add(disciplines[i]);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Teacher: {0}", this.Name));
            foreach (Discipline discipline in disciplines)
            {
                result.AppendLine("    > " + discipline.ToString());
            }
            return result.ToString();
        }
    }
}
