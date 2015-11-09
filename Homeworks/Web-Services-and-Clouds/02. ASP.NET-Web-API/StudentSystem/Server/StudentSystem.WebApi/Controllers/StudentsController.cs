namespace StudentSystem.WebApi.Controllers
{
	using System.Linq;
	using System.Net;
	using System.Web.Http;

	using AutoMapper;
	using AutoMapper.QueryableExtensions;

	using StudentSystem.Models;
	using StudentSystem.Data;
	using StudentSystem.Data.Repositories;
	using StudentSystem.WebApi.Models.Students;

	public class StudentsController : ApiController
	{
		private readonly IGenericRepository<Student> data;

		public StudentsController()
		{
			this.data = new GenericRepository<Student>(new StudentSystemDbContext());
		}

		[HttpGet]
		public IHttpActionResult Get()
		{
			var allStudents = data
				.All()
				.ProjectTo<StudentDetailsResponseModel>()
				.ToList();

			return this.Ok(allStudents);
		}

		[HttpGet]
		public IHttpActionResult Get(int id)
		{
			var student = data
				.All()
				.Where(st => st.StudentIdentification == id)
				.ProjectTo<StudentDetailsResponseModel>()
				.FirstOrDefault();

			if (student == null)
			{
				return this.NotFound();
			}

			return this.Ok(student);
		}

		[HttpPost]
		public IHttpActionResult Post(StudentRequestModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var studentToAdd = Mapper.Map<Student>(model);

			data.Add(studentToAdd);
			data.SaveChanges();
			return this.StatusCode(HttpStatusCode.Created);
		}

		[HttpPut]
		public IHttpActionResult Put(int id, StudentRequestModel model)
		{
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest(this.ModelState);
			}

			var studentToUpdate = this.data.SearchFor(st => st.StudentIdentification == id).FirstOrDefault();

			if (studentToUpdate == null)
			{
				return this.NotFound();
			}

			studentToUpdate.FirstName = model.FirstName;
			studentToUpdate.LastName = model.LastName;
			studentToUpdate.Level = model.Level;

			this.data.Update(studentToUpdate);
			this.data.SaveChanges();

			return this.Ok(studentToUpdate);
		}

		[HttpDelete]
		public IHttpActionResult Delete(int id)
		{
			var studentToDelete = data.SearchFor(st => st.StudentIdentification == id).FirstOrDefault();

			if (studentToDelete == null)
			{
				return this.NotFound();
			}

			this.data.Delete(studentToDelete);
			var studentId = this.data.SaveChanges();

			return this.Ok(studentId);
		}
	}
}