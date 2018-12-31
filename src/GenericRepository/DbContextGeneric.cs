using Microsoft.EntityFrameworkCore;

namespace GenericRepository
{
    public class DbContextGeneric<T> : DbContext where T : DbContext
    {
        public DbContextGeneric(DbContextOptions<T> options) : base(options)
        {

        }
    }
}
