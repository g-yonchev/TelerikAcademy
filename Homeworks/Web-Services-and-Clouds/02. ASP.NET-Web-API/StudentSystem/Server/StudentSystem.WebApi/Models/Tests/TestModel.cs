namespace StudentSystem.WebApi.Models.Tests
{
	using System;
	using System.Linq;

	using AutoMapper;
	using StudentSystem.Models;
	using StudentSystem.WebApi.Infrastructure.Mapping;

	public class TestModel : IMapFrom<Test>, IHaveCustomMappings
	{
		public int Students { get; set; }
		
		public string Course { get; set; }

		public void CreateMappings(IConfiguration config)
		{
			config.CreateMap<Test, TestModel>()
							.ForMember(t => t.Course, opts => opts.MapFrom(t => t.Course.Name))
							.ForMember(t => t.Students, opts => opts.MapFrom(t => t.Students.Count()));
		}
	}
}