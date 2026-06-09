namespace DashboardProject.Application.Interfaces
{
    using DashboardProject.Domain.Entities;
    public interface IStockWatchService
    {
        Task<List<StockWatch>> GetAllAsync();

        Task AddAsync(StockWatch stock);

        Task DeleteAsync(Guid id);
    }
}
