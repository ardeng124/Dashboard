namespace DashboardProject.Application.Interfaces.Services
{
    using DashboardProject.Domain.Entities;
    public interface IWeatherLocationService
    {
        Task<List<WeatherLocation>> GetAllAsync();

        Task AddAsync(string locationName, string countryCode);

        Task DeleteAsync(Guid id);
    }
}
