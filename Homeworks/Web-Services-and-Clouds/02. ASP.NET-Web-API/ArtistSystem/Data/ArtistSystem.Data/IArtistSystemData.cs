namespace ArtistSystem.Data
{
	using System.Data.Entity;

	using ArtistSystem.Models;
	using Repositories;

	public interface IArtistSystemData
	{
		ArtistsRepository Artists { get; }

		IGenericRepository<Song> Songs { get; }

		IGenericRepository<Album> Albums { get; }
	}
}
