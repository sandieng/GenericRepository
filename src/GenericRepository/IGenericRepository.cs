using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
    }
}
