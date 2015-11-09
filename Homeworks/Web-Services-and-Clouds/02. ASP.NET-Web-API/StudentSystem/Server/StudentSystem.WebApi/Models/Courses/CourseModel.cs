namespace StudentSystem.WebApi.Models.Courses
{
	using StudentSystem.Models;
	using Infrastructure.Mapping;
	using AutoMapper;
	using System;

	public class CourseModel : IMapFrom<Course>, IHaveCustomMappings
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public void CreateMappings(IConfiguration config)
		{
			config.CreateMap<CourseModel, Course>();
		}
	}
}