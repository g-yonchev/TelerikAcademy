namespace StudentSystem.Data
{
	using StudentSystem.Data.Migrations;
	using StudentSystem.Models;
	using System.Data.Entity;

	public class StudentSystemDbContext : DbContext, IStudentSystemDbContext
	{
		public StudentSystemDbContext()
			: base("StudentSystem")
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
		}

		public IDbSet<Course> Courses { get; set; }

		public IDbSet<Student> Students { get; set; }

		public IDbSet<Homework> Homeworks { get; set; }

		public IDbSet<Test> Tests { get; set; }

		public new IDbSet<T> Set<T>() where T : class
		{
			return base.Set<T>();
		}

		public new void SaveChanges()
		{
			base.SaveChanges();
		}

		public static StudentSystemDbContext Create()
		{
			return new StudentSystemDbContext();
		}
	}
}
