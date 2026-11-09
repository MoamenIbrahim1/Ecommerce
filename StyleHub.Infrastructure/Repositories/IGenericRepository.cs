using System.Collections.Generic;
using System.Threading.Tasks;

namespace StyleHub.Infrastructure.Repositories
{
    // The <T> makes it generic; 'where T : class' ensures it's a reference type.
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAllAsync();
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}