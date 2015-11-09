namespace StudentSystem.WebApi.Controllers
{
	using System;
	using System.Linq;
	using System.Net;
	using System.Web.Http;
	using System.Web.Http.Cors;

	using StudentSystem.Models;
	using StudentSystem.Data;
	using StudentSystem.Data.Repositories;
	using StudentSystem.WebApi.Models.Courses;
	using AutoMapper.QueryableExtensions;
	using AutoMapper;

	public class CoursesController : ApiController
	{
		private readonly IGenericRepository<Course> data;

		public CoursesController()
		{
			this.data = new GenericRepository<Course>(new StudentSystemDbContext());
		}

		[HttpGet]
		[EnableCors("*", "*", "*")]
		public IHttpActionResult Get()
		{
			var allCourses = data
				.All()
				.ProjectTo<CourseModel>()
				.ToList();

			return this.Ok(allCourses);
		}

		[HttpGet]
		public IHttpActionResult Get(Guid id)
		{
			var course = data
				.All()
				.Where(c => c.Id == id)
				.ProjectTo<CourseModel>()
				.FirstOrDefault();

			if (course == null)
			{
				return this.NotFound();
			}

			return this.Ok(course);
		}

		[HttpPost]
		public IHttpActionResult Post(CourseModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var courseToAdd = Mapper.Map<Course>(model);

			data.Add(courseToAdd);
			data.SaveChanges();
			return this.StatusCode(HttpStatusCode.Created);
		}

		[HttpPut]
		public IHttpActionResult Put(Guid id, CourseModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var courseToUpdate = this.data.SearchFor(c => c.Id == id).FirstOrDefault();

			if (courseToUpdate == null)
			{
				return this.NotFound();
			}

			if (model.Name != null)
			{
				courseToUpdate.Name = model.Name;
			}

			if (model.Description != null)
			{
				courseToUpdate.Description = model.Description;
			}

			this.data.Update(courseToUpdate);
			this.data.SaveChanges();

			return this.Ok(courseToUpdate);
		}

		[HttpDelete]
		public IHttpActionResult Delete(Guid id)
		{
			var courseToDelete = data.SearchFor(st => st.Id == id).FirstOrDefault();

			if (courseToDelete == null)
			{
				return this.NotFound();
			}

			this.data.Delete(courseToDelete);
			var courseId = this.data.SaveChanges();

			return this.Ok(courseId);
		}
	}
}