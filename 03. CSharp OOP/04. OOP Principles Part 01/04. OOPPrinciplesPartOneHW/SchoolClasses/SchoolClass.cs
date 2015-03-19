namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SchoolClass : ICommentable
    {
        private string textIdentifier;
        private List<Teacher> listOfTeachers;
        private List<Student> listOfStudents;

        public SchoolClass(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
            this.listOfTeachers = new List<Teacher>();
            this.listOfStudents = new List<Student>();
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Text Identifier cannot be null or empty");
                }

                this.textIdentifier = value;
            }
        }

        public List<Teacher> ListOfTeachers
        {
            get
            {
                return new List<Teacher>(this.listOfTeachers);
            }
        }

        public List<Student> ListOfStudents
        {
            get
            {
                return new List<Student>(this.listOfStudents);
            }
        }

        public string Comment { get; set; }

        public void AddTeacher(params Teacher[] teachers)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                this.listOfTeachers.Add(teachers[i]);
            }
        }
        
        public void AddTeacher(Teacher teacher)
        {
            this.listOfTeachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.listOfStudents.Add(student);
        }

        public void AddStudent(params Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                this.listOfStudents.Add(students[i]);                
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Class: {0}", this.TextIdentifier));

            foreach (Teacher teacher in this.ListOfTeachers)
            {
                result.Append(" *" + teacher.ToString());
            } 
            
            foreach (Student st in this.ListOfStudents)
            {
                result.AppendLine(" -" + st.ToString());
            }

            return result.ToString();
        }
    }
}
