namespace ArtistSystem.WebApi
{
	using ArtistSystem.Data;

	public class DatabaseConfig
	{
		public static void Initialize()
		{
			ArtistSystemDbContext.Create().Database.Initialize(true);
		}
	}
}