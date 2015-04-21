namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private ICollection<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public ICollection<string> Topics
        {
            get
            {
                return new List<string>(this.topics);
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

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Name={0}", this.Name);

            if (this.Teacher != null)
            {
                result.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }

            var property = this.GetType().GetProperties();

            if (this.Topics.Count > 0)
            {
                result.AppendFormat("; Topics=[{0}]", string.Join(", ", this.Topics));
            }

            return result.ToString();
        }
    }
}
