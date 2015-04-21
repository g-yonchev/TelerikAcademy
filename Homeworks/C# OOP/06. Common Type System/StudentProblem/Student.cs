namespace StudentProblem
{
    using System;
    using System.Text;
    using System.Reflection;

    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string Ssn { get; private set; }
        public string Address { get; private set; }
        public string Mobile { get; private set; }
        public string Email { get; private set; }
        public int Course { get; private set; }
        public UniversityType University { get; private set; }
        public FacultyType Faculty { get; private set; }
        public SpecialtyType Specialty { get; private set; }

        public Student(string firstName, string middleName, string lastName, string ssn,
                        string address = null, string mobile = null, string email = null, int course = 0,
                        UniversityType university = UniversityType.Other,
                        FacultyType faculty = FacultyType.Other,
                        SpecialtyType specialty = SpecialtyType.Other)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Address = address;
            this.Mobile = mobile;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var property in this.GetType().GetRuntimeProperties())
            {
                result.AppendLine(string.Format("{0}: {1}", property.Name, property.GetValue(this)));
            }

            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var otherStudent = obj as Student;

            if (this.Ssn == otherStudent.Ssn)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student a, Student b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !a.Equals(b);
        }

        public override int GetHashCode()
        {
            return this.Ssn.GetHashCode() ^ this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public Student Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Address,
                    this.Mobile, this.Email, this.Course, this.University, this.Faculty, this.Specialty);

        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student studentX)
        {
            if (studentX == null)
            {
                return 1;
            }


            else
            {
                if (this.FirstName != studentX.FirstName)
                {
                    return this.FirstName.CompareTo(studentX.FirstName);
                }
                else if (this.MiddleName != studentX.MiddleName)
                {
                    return this.MiddleName.CompareTo(studentX.MiddleName);
                }
                else if (this.LastName != studentX.LastName)
                {
                    return this.LastName.CompareTo(studentX.LastName);
                }
                else if (this.Ssn != studentX.Ssn)
                {
                    return this.Ssn.CompareTo(studentX.Ssn);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
