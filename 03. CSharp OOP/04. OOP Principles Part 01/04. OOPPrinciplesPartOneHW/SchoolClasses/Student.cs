namespace SchoolClasses
{
    public class Student : Human, ICommentable
    {
        private int classNumber;

        public Student(string name, int classNumber)
            :base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student: {0}, ID: {1}", this.Name, this.ClassNumber);
        }
    }
}
