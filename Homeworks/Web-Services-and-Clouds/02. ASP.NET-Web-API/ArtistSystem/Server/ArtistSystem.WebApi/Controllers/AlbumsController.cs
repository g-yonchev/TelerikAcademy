namespace ArtistSystem.WebApi.Controllers
{
	using System.Linq;
	using System.Net;
	using System.Web.Http;

	using ArtistSystem.Models;
	using ArtistSystem.WebApi.Models;
	using ArtistSystem.Data;

	public class AlbumsController :ApiController
	{
		private readonly IArtistSystemDbContext data;

		public AlbumsController()
		{
			this.data = new ArtistSystemDbContext();
		}

		[HttpGet]
		public IHttpActionResult Get()
		{
			var allAlbums = data
				.Albums
				.Select(a => new
				{
					Title = a.Title,
					Producer = a.Producer,
					Year = a.Year,
					Songs = a.Songs.Count()
				})
				.ToList();

			return this.Ok(allAlbums);
		}

		[HttpGet]
		public IHttpActionResult Get(int id)
		{
			var album = data
				.Albums
				.Where(a => a.Id == id)
				.Select(a => new
				{
					NTitle = a.Title,
					Producer = a.Producer,
					Year = a.Year,
					Songs = a.Songs.Count()
				})
				.FirstOrDefault();

			if (album == null)
			{
				return this.NotFound();
			}

			return this.Ok(album);
		}

		[HttpPost]
		public IHttpActionResult Post(AlbumRequestModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var albumToAdd = new Album
			{
				Title = model.Title,
				Producer = model.Producer,
				Year = model.Year
			};

			data.Albums.Add(albumToAdd);
			data.SaveChanges();
			return this.StatusCode(HttpStatusCode.Created);
		}

		[HttpPut]
		public IHttpActionResult Put(int id, AlbumRequestModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var albumToUpdate = this.data.Albums.FirstOrDefault(a => a.Id == id);

			if (albumToUpdate == null)
			{
				return this.NotFound();
			}

			albumToUpdate.Title = model.Title;
			albumToUpdate.Producer = model.Producer;
			albumToUpdate.Year = model.Year;

			this.data.SaveChanges();

			return this.Ok(albumToUpdate);
		}

		[HttpDelete]
		public IHttpActionResult Delete(int id)
		{
			var albumToDelete = data.Albums.FirstOrDefault(a => a.Id == id);

			if (albumToDelete == null)
			{
				return this.NotFound();
			}
			var albumToDeleteId = albumToDelete.Id;

			this.data.Albums.Remove(albumToDelete);
			data.SaveChanges();

			return this.Ok(albumToDeleteId);
		}
	}
}