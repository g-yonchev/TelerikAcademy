namespace ArtistSystem.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Artist
	{
		private ICollection<Album> albums;
		private ICollection<Song> songs;

		public Artist()
		{
			this.albums = new HashSet<Album>();
			this.songs = new HashSet<Song>();
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[MinLength(2)]
		[MaxLength(40)]
		public string Name { get; set; }

		public string Country { get; set; }

		public DateTime DateOfBirth { get; set; }
		
		public virtual ICollection<Album> Albums
		{
			get { return this.albums; }
			set { this.albums = value; }
		}

		public virtual ICollection<Song> Songs
		{
			get { return this.songs; }
			set { this.songs = value; }
		}
	}
}
