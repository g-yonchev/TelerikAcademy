namespace ArtistSystem.Data.Repositories
{
	using System;
	using System.Linq;

	public interface IGenericRepository<T>
		where T : class
	{
		IQueryable<T> All();

		void Add(T entity);

		void Update(T entity);

		void Delete(T entity);

		void Detach(T entity);
	}
}