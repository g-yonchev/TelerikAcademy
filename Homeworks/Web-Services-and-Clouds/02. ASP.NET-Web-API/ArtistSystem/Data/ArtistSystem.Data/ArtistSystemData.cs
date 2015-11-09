using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ArtistSystem.Models;
using System.Collections.Generic;
using ArtistSystem.Data.Repositories;

namespace ArtistSystem.Data
{
	public class ArtistSystemData : IArtistSystemData
	{
		private IArtistSystemDbContext context;
		private IDictionary<Type, object> repositories;

		public ArtistSystemData()
            : this(new ArtistSystemDbContext())
        {
		}

		public ArtistSystemData(IArtistSystemDbContext context)
		{
			this.context = context;
			this.repositories = new Dictionary<Type, object>();
		}
		
		public ArtistsRepository Artists
		{
			get
			{
				return (ArtistsRepository)this.GetRepository<Artist>();
			}
		}

		public IGenericRepository<Album> Albums
		{
			get
			{
				return this.GetRepository<Album>();
			}
		}

		public IGenericRepository<Song> Songs
		{
			get
			{
				return this.GetRepository<Song>();
			}
		}

		private IGenericRepository<T> GetRepository<T>() where T : class
		{
			var typeOfModel = typeof(T);
			if (!this.repositories.ContainsKey(typeOfModel))
			{
				var type = typeof(GenericRepository<T>);

				if (typeOfModel.IsAssignableFrom(typeof(Artist)))
				{
					type = typeof(ArtistsRepository);
				}

				this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
			}

			return (IGenericRepository<T>)this.repositories[typeOfModel];
		}
	}
}
