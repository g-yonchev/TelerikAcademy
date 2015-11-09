namespace StudentSystem.Data.Repositories
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using System.Linq;
	using System.Linq.Expressions;

	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private IStudentSystemDbContext context;
		private IDbSet<T> set;

		public GenericRepository(IStudentSystemDbContext context)
		{
			if (context == null)
			{
				throw new ArgumentException("An instance of DbContext is required to use this repository.", "context");
			}

			this.context = context;
			this.set = context.Set<T>();
		}

		public IQueryable<T> All()
		{
			return this.set.AsQueryable();
		}

		public IQueryable<T> SearchFor(Expression<Func<T, bool>> conditions)
		{
			return this.All().Where(conditions);
		}

		public void Add(T entity)
		{
			var entry = AttachIfDetached(entity);
			entry.State = EntityState.Added;
		}

		public void Update(T entity)
		{
			var entry = AttachIfDetached(entity);
			entry.State = EntityState.Modified;
		}

		public void Delete(T entity)
		{
			var entry = AttachIfDetached(entity);
			entry.State = EntityState.Deleted;
		}

		public void Detach(T entity)
		{
			var entry = this.context.Entry(entity);
			entry.State = EntityState.Detached;
		}

		private DbEntityEntry AttachIfDetached(T entity)
		{
			var entry = this.context.Entry(entity);
			if (entry.State == EntityState.Detached)
			{
				this.set.Attach(entity);
			}

			return entry;
		}

		public void Delete(object id)
		{
			var entity = this.GetById(id);

			if (entity != null)
			{
				this.Delete(entity);
			}
		}

		public T GetById(object id)
		{
			return this.set.Find(id);
		}

		public T Attach(T entity)
		{
			return this.context.Set<T>().Attach(entity);
		}

		public int SaveChanges()
		{
			return this.context.SaveChanges();
		}
	}
}
