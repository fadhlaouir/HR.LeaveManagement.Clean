namespace HR.LeaveManagement.Application.Contracts.Persistence
{
    public interface IGenericRepository<T>
        where T : class // T must be a class type
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
