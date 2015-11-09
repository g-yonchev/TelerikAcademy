using System.ComponentModel.DataAnnotations;

namespace ArtistSystem.Models
{
	public class Song
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MinLength(2)]
		[MaxLength(40)]
		public string Title { get; set; }

		[Required]
		[MinLength(2)]
		[MaxLength(40)]
		public string Genre { get; set; }

		public int ArtistId { get; set; }

		public virtual Artist Artist { get; set; }

		public int AlbumId { get; set; }

		public virtual Album Album { get; set; }
	}
}
