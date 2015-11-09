namespace StudentSystem.WebApi.Controllers
{
	using System.Web.Http;
	using System.Linq;

	using AutoMapper.QueryableExtensions;

	using Data;
	using Data.Repositories;
	using Models.Tests;
	using StudentSystem.Models;

	public class TestsController : ApiController
    {
		private readonly IGenericRepository<Test> data;

		public TestsController()
		{
			this.data = new GenericRepository<Test>(new StudentSystemDbContext());
		}

		[HttpGet]
		public IHttpActionResult Get()
		{
			var allTests = data
				.All()
				.ProjectTo<TestModel>()
				.GroupBy(t => t.Course)
				.ToList();

			return this.Ok(allTests);
		}

		[HttpGet]
		public IHttpActionResult Get(int id)
		{
			var allTests = data
				.All()
				.Where(t => t.Id == id)
				.ProjectTo<TestModel>()
				.ToList();

			return this.Ok(allTests);
		}
	}
}