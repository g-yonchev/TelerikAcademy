namespace StudentSystem.WebApi.Infrastructure.Mapping
{
	using AutoMapper;

	public interface IHaveCustomMappings
	{
		void CreateMappings(IConfiguration config);
	}
}