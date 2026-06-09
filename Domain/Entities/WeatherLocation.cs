namespace DashboardProject.Domain.Entities;

public class WeatherLocation
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string CountryCode { get; set; } = string.Empty;
}
