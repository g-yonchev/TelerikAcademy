using ArtistSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistSystem.Data
{
	public class ArtistSystemDbContext : DbContext, IArtistSystemDbContext
	{
		public ArtistSystemDbContext()
            : base("ArtistSystem")
        {
		}

		public virtual IDbSet<Artist> Artists { get; set; }

		public virtual IDbSet<Album> Albums { get; set; }

		public virtual IDbSet<Song> Songs { get; set; }
		
		public new IDbSet<T> Set<T>() where T : class
		{
			return base.Set<T>();
		}

		public new void SaveChanges()
		{
			base.SaveChanges();
		}

		public static ArtistSystemDbContext Create()
		{
			return new ArtistSystemDbContext();
		}
	}
}
