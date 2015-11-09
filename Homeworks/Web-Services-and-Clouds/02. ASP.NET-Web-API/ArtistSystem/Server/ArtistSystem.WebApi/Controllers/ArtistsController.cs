namespace ArtistSystem.WebApi.Controllers
{
	using System.Linq;
	using System.Net;
	using System.Web.Http;

	using ArtistSystem.Models;
	using ArtistSystem.WebApi.Models;
	using ArtistSystem.Data;

	public class ArtistsController : ApiController
	{
		private readonly IArtistSystemDbContext data;

		public ArtistsController()
		{
			this.data = new  ArtistSystemDbContext();
		}

		[HttpGet]
		public IHttpActionResult Get()
		{
			var allArtists = data
				.Artists
				.Select(a => new
				{
					Name = a.Name,
					Country = a.Country,
					Songs = a.Songs.Count(),
					Albums = a.Albums.Count()
				})
				.ToList();

			return this.Ok(allArtists);
		}

		[HttpGet]
		public IHttpActionResult Get(int id)
		{
			var artist = data
				.Artists
				.Where(a => a.Id == id)
				.Select(a => new
				{
					Name = a.Name,
					Country = a.Country,
					Songs = a.Songs.Count(),
					Albums = a.Albums.Count()
				})
				.FirstOrDefault();

			if (artist == null)
			{
				return this.NotFound();
			}

			return this.Ok(artist);
		}

		[HttpPost]
		public IHttpActionResult Post(ArtistRequestModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var artistToAdd = new Artist
			{
				Name = model.Name,
				Country = model.Country,
				DateOfBirth = model.DateOfBirth
			};

			data.Artists.Add(artistToAdd);
			data.SaveChanges();
			return this.StatusCode(HttpStatusCode.Created);
		}

		[HttpPut]
		public IHttpActionResult Put(int id, ArtistRequestModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var artistToUpdate = this.data.Artists.FirstOrDefault(a => a.Id == id);

			if (artistToUpdate == null)
			{
				return this.NotFound();
			}

			artistToUpdate.Name = model.Name;
			artistToUpdate.Country = model.Country;
			artistToUpdate.DateOfBirth = model.DateOfBirth;
			
			this.data.SaveChanges();

			return this.Ok(artistToUpdate);
		}

		[HttpDelete]
		public IHttpActionResult Delete(int id)
		{
			var artistToDelete = data.Artists.FirstOrDefault(a => a.Id == id);

			if (artistToDelete == null)
			{
				return this.NotFound();
			}
			var artistToDeleteId = artistToDelete.Id;

			this.data.Artists.Remove(artistToDelete);
            data.SaveChanges();

			return this.Ok(artistToDeleteId);
		}
	}
}