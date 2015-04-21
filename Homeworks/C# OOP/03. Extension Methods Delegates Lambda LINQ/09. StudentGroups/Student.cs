namespace StudentGroups
{
    using System;
    using System.Collections.Generic;

    public enum GroupNumber
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4
    }

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string phone;
        private string email;
        private List<int> marks;
        private GroupNumber group;

        public Student()
        {
            ;
        }
        
        public Student(string firstName, string lastName, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Group = (GroupNumber)group;
        }

        public Student(string firstName, string lastName, string email)
            : this(firstName, lastName, 1)
        {
            this.Email = email;
        }

        public Student(string firstName, string lastName, List<int> marks)
            : this(firstName, lastName, 1)
        {
            this.Marks = marks;
        }

        public Student(string firstName, string lastName, string fn, List<int> marks)
            : this(firstName, lastName, marks)
        {
            this.Fn = fn;
        }   

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Fn
        {
            get { return this.fn; }
            set { this.fn = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public List<int> Marks
        {
            get { return new List<int>(this.marks); }
            set { this.marks = value; }
        }

        public GroupNumber Group
        {
            get { return this.group; }
            set { this.group = value; }
        }
    }
}
