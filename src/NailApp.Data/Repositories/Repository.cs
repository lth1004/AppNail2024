using Microsoft.EntityFrameworkCore;
using NailApp.Data;
using NailApp.Data.Entities;
using NailApp.Data.Interfaces;

namespace NorthwindApp.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            var query = _context.Set<T>().AsNoTracking().AsQueryable();
            return query;
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().AsNoTracking().Single(x => x.Id == id);
        }
    }
}
