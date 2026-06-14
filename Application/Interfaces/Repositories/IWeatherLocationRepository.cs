namespace DashboardProject.Application.Interfaces.Repositories
{
	using DashboardProject.Domain.Entities;
    using DashboardProject.Persistance.Repositories;

    public interface IWeatherLocationRepository: IRepository<WeatherLocation>
    {
    }
}
