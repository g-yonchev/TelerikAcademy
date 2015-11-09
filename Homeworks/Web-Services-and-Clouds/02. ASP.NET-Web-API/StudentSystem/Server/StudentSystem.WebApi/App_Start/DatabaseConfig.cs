namespace StudentSystem.WebApi
{
	using StudentSystem.Data;

	public class DatabaseConfig
	{
		public static void Initialize()
		{
			StudentSystemDbContext.Create().Database.Initialize(true);
		}
	}
}