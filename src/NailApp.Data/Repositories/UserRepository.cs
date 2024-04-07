using Microsoft.EntityFrameworkCore;
using NailApp.Data;
using NailApp.Data.Entities;
using NailApp.Data.Interfaces;

namespace NorthwindApp.Data.Repositories
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
        public IEnumerable<UserEntity> SearchUser(string keywords)
        {
            return _context.Set<UserEntity>().AsNoTracking().AsQueryable()
                 .Where(x => x.UserName.Equals(keywords)).ToArray();

        }
    }
}
