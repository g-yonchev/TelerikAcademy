namespace StudentSystem.WebApi.Models.Students
{
	using Infrastructure.Mapping;
	using System.ComponentModel.DataAnnotations;
	using AutoMapper;
	using System;
	using StudentSystem.Models;

	public class StudentRequestModel : IMapFrom<Student>, IHaveCustomMappings
	{
		[Required]
		[MinLength(3)]
		[MaxLength(20)]
		public string FirstName { get; set; }

		[Required]
		[MinLength(3)]
		[MaxLength(20)]
		public string LastName { get; set; }

		public int Level { get; set; }

		public void CreateMappings(IConfiguration config)
		{
			config.CreateMap<StudentRequestModel, Student>();
        }
	}
}