namespace DashboardProject.Persistance.Repositories
{
    using DashboardProject.Application.Interfaces.Repositories;
    using DashboardProject.Domain.Entities;
    using DashboardProject.Persistance.Context;
    using Microsoft.EntityFrameworkCore;
    public class WeatherLocationRepository: IWeatherLocationRepository
    {
        private readonly DashboardDbContext _db;

        public WeatherLocationRepository(
                DashboardDbContext db)
        {
            _db = db;
        }

        public async Task<List<WeatherLocation>> GetAllAsync()
        {
            return await _db.WeatherLocations
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task<WeatherLocation?> GetByIdAsync(Guid id)
        {
            return await _db.WeatherLocations
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(WeatherLocation location)
        {
            await _db.WeatherLocations.AddAsync(location);
        }

        public async Task DeleteAsync(Guid id)
        {
            var location = await GetByIdAsync(id);

            if (location is not null)
            {
                _db.WeatherLocations.Remove(location);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
