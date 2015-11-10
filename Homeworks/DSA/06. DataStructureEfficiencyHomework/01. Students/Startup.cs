namespace Students
{
	using System;
	using System.Collections.Generic;
	using System.IO;

	using Wintellect.PowerCollections;

	public class Startup
	{
		private const string FilePath = @"../../students.txt";
		private const string FilePathLooooong = @"../../students2.txt";

		private static readonly SortedDictionary<string, OrderedBag<Student>> students = new SortedDictionary<string, OrderedBag<Student>>();

		public static void Main()
		{
			//using (var reader = new StreamReader(FilePath))
			using (var reader = new StreamReader(FilePathLooooong))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var studentInfo = line.Split('|');

					var firstName = studentInfo[0].Trim();
					var lastName = studentInfo[1].Trim();
					var course = studentInfo[2].Trim();

					var student = new Student(firstName, lastName);

					if (!students.ContainsKey(course))
					{
						students[course] = new OrderedBag<Student>();
					}

					students[course].Add(student);
				}
			}

			foreach (var course in students)
			{
				Console.WriteLine(course.Key);

				foreach (var student in course.Value)
				{
					Console.WriteLine($" - {student}");
				}

				Console.WriteLine();
			}
		}
	}
}
