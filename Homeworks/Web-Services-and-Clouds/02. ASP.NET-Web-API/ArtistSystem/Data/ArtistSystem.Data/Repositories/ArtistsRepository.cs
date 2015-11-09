using ArtistSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistSystem.Data.Repositories
{
	public class ArtistsRepository : GenericRepository<Artist>, IGenericRepository<Artist>
	{
		public ArtistsRepository(IArtistSystemDbContext context)
			: base(context)
		{

		}
	}
}
