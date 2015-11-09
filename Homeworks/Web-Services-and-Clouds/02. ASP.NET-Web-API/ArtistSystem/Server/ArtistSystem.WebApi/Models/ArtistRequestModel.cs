namespace ArtistSystem.WebApi.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class ArtistRequestModel
	{
		[Required]
		[MinLength(2)]
		[MaxLength(40)]
		public string Name { get; set; }

		public string Country { get; set; }

		public DateTime DateOfBirth { get; set; }
	}
}	