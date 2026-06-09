namespace DashboardProject.Persistance.Context
{
	using Microsoft.EntityFrameworkCore;
    using DashboardProject.Domain.Entities;

    public class DashboardDbContext:DbContext
    {
        public DashboardDbContext(
                DbContextOptions<DashboardDbContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherLocation> WeatherLocations =>
            Set<WeatherLocation>();

        public DbSet<StockWatch> StockWatches =>
            Set<StockWatch>();
    }
}
