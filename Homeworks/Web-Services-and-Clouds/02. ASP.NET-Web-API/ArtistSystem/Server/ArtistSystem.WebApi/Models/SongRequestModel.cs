namespace ArtistSystem.WebApi.Models
{
	using System.ComponentModel.DataAnnotations;

	public class SongRequestModel
	{
		[Required]
		[MinLength(2)]
		[MaxLength(40)]
		public string Title { get; set; }

		[Required]
		[MinLength(2)]
		[MaxLength(40)]
		public string Genre { get; set; }
	}
}