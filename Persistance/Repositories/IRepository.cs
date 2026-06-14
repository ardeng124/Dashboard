namespace DashboardProject.Persistance.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<TEntity?> GetByIdAsync(Guid id);

        Task<List<TEntity>> GetAllAsync();

        Task AddAsync(TEntity entity);

        Task DeleteAsync(Guid id);

        Task SaveChangesAsync();
    }
}
