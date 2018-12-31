using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepository
{
    public class GenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly DbContext _context;

        protected DbSet<TEntity> EntitySet;
        protected string EntityName = typeof(TEntity).Name;

        public GenericRepository(DbContext context)
        {
            _context = context;
            EntitySet = _context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await EntitySet.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await EntitySet.FindAsync(id);
        }
    }
}
