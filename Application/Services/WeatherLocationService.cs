namespace DashboardProject.Application.Services
{
    using DashboardProject.Application.Interfaces;
    using DashboardProject.Application.Interfaces.Repositories;
    using DashboardProject.Application.Interfaces.Services;
    using DashboardProject.Domain.Entities;

    public class WeatherLocationService: IWeatherLocationService
    {
        private readonly IWeatherLocationRepository _repository;
        public WeatherLocationService(
                IWeatherLocationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<WeatherLocation>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task AddAsync(
                string locationName,
                string countryCode)
        {
            var location = new WeatherLocation
            {
                Id = Guid.NewGuid(),
                Name = locationName,
                CountryCode = countryCode
            };

            await _repository.AddAsync(location);

            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);

            await _repository.SaveChangesAsync();
        }
    }
}
