namespace DashboardProject.Application.Interfaces
{
    using DashboardProject.Domain.Entities;
    using DashboardProject.Application.DTOs;
    public interface IWeatherProvider
    {
        Task<WeatherSnapshot> GetCurrentWeatherAsync(WeatherLocation location);

    }
}
