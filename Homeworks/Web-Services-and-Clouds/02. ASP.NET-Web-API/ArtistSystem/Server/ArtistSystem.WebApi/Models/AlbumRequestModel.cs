namespace ArtistSystem.WebApi.Models
{
	using System.ComponentModel.DataAnnotations;

	public class AlbumRequestModel
	{
		[Required]
		[MinLength(2)]
		[MaxLength(40)]
		public string Title { get; set; }

		[Required]
		[MaxLength(50)]
		public string Producer { get; set; }

		public short Year { get; set; }
	}
}