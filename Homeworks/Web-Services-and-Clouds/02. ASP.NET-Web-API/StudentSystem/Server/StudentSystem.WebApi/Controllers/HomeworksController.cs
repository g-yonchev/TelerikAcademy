namespace StudentSystem.WebApi.Controllers
{
	using System.Linq;
	using Data.Repositories;
	using Data;
	using StudentSystem.Models;
	using System.Web.Http;
	using Models.Homeworks;
	using AutoMapper.QueryableExtensions;

	public class HomeworksController : ApiController
    {
		private readonly IGenericRepository<Homework> data;

		public HomeworksController()
		{
			this.data = new GenericRepository<Homework>(new StudentSystemDbContext());
		}

		[HttpGet]
		public IHttpActionResult Get()
		{
			var allHomeworks = data
				.All()
				.ProjectTo<HomeworkDetailsResponseModel>()
				.GroupBy(hw => hw.Course)
				.ToList();

			return this.Ok(allHomeworks);
		}
	}
}