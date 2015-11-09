namespace StudentSystem.WebApi.Models.Students
{
	using System;
	using System.Linq;
	using System.Linq.Expressions;

	using AutoMapper;
	using Infrastructure.Mapping;
	using StudentSystem.Models;

	public class StudentDetailsResponseModel : IMapFrom<Student>, IHaveCustomMappings
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public int Courses { get; set; }

		public void CreateMappings(IConfiguration config)
		{
			config.CreateMap<Student, StudentDetailsResponseModel>()
				.ForMember(st => st.Courses, opts => opts.MapFrom(st => st.Courses.Count()))
				.ForMember(st => st.Email, opts => opts.MapFrom(st => st.AdditionalInformation.Email));
		}
	}
}