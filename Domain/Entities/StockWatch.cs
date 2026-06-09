namespace DashboardProject.Domain.Entities
{
    public class StockWatch
    {
        public Guid Id { get; set; }

        public string Symbol { get; set; } = string.Empty;

        public string? DisplayName { get; set; }
    }
}
