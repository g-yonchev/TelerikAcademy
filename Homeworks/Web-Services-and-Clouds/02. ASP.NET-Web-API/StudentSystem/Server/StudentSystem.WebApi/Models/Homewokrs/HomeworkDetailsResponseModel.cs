namespace StudentSystem.WebApi.Models.Homeworks
{
	using System;
	using AutoMapper;
	using Infrastructure.Mapping;

	using StudentSystem.Models;

	public class HomeworkDetailsResponseModel : IMapFrom<Homework>, IHaveCustomMappings
	{
		public string FileUrl { get; set; }

		public DateTime TimeSent { get; set; }

		public string Student { get; set; }

		public string Course { get; set; }

		public void CreateMappings(IConfiguration config)
		{
			config.CreateMap<Homework, HomeworkDetailsResponseModel>()
				.ForMember(hw => hw.Student, opts => opts.MapFrom(hw => hw.Student.FirstName + " " + hw.Student.LastName))
				.ForMember(hw => hw.Course, opts => opts.MapFrom(hw => hw.Course.Name));
		}
	}
}