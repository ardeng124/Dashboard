namespace DashboardProject.Application.Interfaces
{
    using DashboardProject.Application.DTOs;
    public interface IStockProvider
    {
        Task<StockSnapshot> GetCurrentQuoteAsync(string symbol);
    }
}
