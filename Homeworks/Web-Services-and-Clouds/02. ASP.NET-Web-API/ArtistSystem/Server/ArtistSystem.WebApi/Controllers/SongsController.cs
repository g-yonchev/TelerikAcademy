namespace ArtistSystem.WebApi.Controllers
{
	using System.Linq;
	using System.Net;
	using System.Web.Http;

	using ArtistSystem.Models;
	using ArtistSystem.WebApi.Models;
	using ArtistSystem.Data;

	public class SongsController : ApiController
	{
		private readonly IArtistSystemDbContext data;

		public SongsController()
		{
			this.data = new ArtistSystemDbContext();
		}

		[HttpGet]
		public IHttpActionResult Get()
		{
			var allSongs = data
				.Songs
				.Select(s => new
				{
					Title = s.Title,
					Genre = s.Genre
				})
				.ToList();

			return this.Ok(allSongs);
		}

		[HttpGet]
		public IHttpActionResult Get(int id)
		{
			var song = data
				.Songs
				.Where(s => s.Id == id)
				.Select(s => new
				{
					Title = s.Title,
					Genre = s.Genre
				})
				.FirstOrDefault();

			if (song == null)
			{
				return this.NotFound();
			}

			return this.Ok(song);
		}

		[HttpPost]
		public IHttpActionResult Post(SongRequestModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var songToAdd = new Song
			{
				Title = model.Title,
				Genre = model.Genre
			};

			data.Songs.Add(songToAdd);
			data.SaveChanges();
			return this.StatusCode(HttpStatusCode.Created);
		}

		[HttpPut]
		public IHttpActionResult Put(int id, SongRequestModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var songToUpdate = this.data.Songs.FirstOrDefault(s => s.Id == id);

			if (songToUpdate == null)
			{
				return this.NotFound();
			}

			songToUpdate.Title = model.Title;
			songToUpdate.Genre = model.Genre;

			this.data.SaveChanges();

			return this.Ok(songToUpdate);
		}

		[HttpDelete]
		public IHttpActionResult Delete(int id)
		{
			var songToDelete = data.Songs.FirstOrDefault(s => s.Id == id);

			if (songToDelete == null)
			{
				return this.NotFound();
			}

			var songToDeleteId = songToDelete.Id;

			this.data.Songs.Remove(songToDelete);
			data.SaveChanges();

			return this.Ok(songToDeleteId);
		}
	}
}