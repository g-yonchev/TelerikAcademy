namespace ArtistSystem.Data.Migrations
{
	using System;
	using System.Linq;
	using System.Data.Entity.Migrations;
	using Models;

	internal sealed class Configuration : DbMigrationsConfiguration<ArtistSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

        protected override void Seed(ArtistSystemDbContext context)
        {
			this.SeedArtists(context);
			this.SeedAlbums(context);
			this.SeedSongs(context);
		}

		private void SeedSongs(ArtistSystemDbContext context)
		{
			if (context.Songs.Any())
			{
				return;
			}

			var song = new Song
			{
				Title = "Te sa zeleni",
				Genre = "Chalga"
			};

			var artist = context.Artists.FirstOrDefault();
			artist.Songs.Add(song);
			
			var album = context.Albums.FirstOrDefault();
			album.Songs.Add(song);

			context.Songs.Add(song);
		}

		private void SeedArtists(ArtistSystemDbContext context)
		{
			if (context.Artists.Any())
			{
				return;
			}

			var artist = new Artist
			{
				Name = "Pesho",
				Country = "Bulgaria",
				DateOfBirth = DateTime.Now
			};

			context.Artists.Add(artist);
		}

		private void SeedAlbums(ArtistSystemDbContext context)
		{
			if (context.Albums.Any())
			{
				return;
			}

			var album = new Album
			{
				Title = "Pesho's Album",
				Producer = "Gosho",
				Year = 2015
			};

			var artist = context.Artists.FirstOrDefault();
			artist.Albums.Add(album);

			context.Albums.Add(album);
		}
	}
}
