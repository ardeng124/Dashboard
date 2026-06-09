namespace DashboardProject.Application.Interfaces
{
    using DashboardProject.Domain.Entities;
    public interface IWeatherLocationService
    {
        Task<List<WeatherLocation>> GetAllAsync();

        Task AddAsync(WeatherLocation location);

        Task DeleteAsync(Guid id);
    }
}
