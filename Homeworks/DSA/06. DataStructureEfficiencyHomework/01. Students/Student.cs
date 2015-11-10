﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
	using System;

	public class Student : IComparable<Student>
	{
		public Student(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int CompareTo(Student other)
		{
			var compare = this.LastName.CompareTo(other.LastName);

			if (compare == 0)
			{
				compare = this.FirstName.CompareTo(other.FirstName);
			}

			return compare;
		}

		public override string ToString()
		{
			return string.Format("{0} {1}", this.FirstName, this.LastName);
		}
	}
}
