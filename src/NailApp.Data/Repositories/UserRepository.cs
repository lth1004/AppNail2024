using Microsoft.EntityFrameworkCore;
using NailApp.Data.Authorization;
using NailApp.Data.Entities;
using NailApp.Data.Interfaces;

namespace NailApp.Data.Repositories
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        private readonly IJwtUtils _jwtUtils;

        public UserRepository(ApplicationDbContext context, IJwtUtils jwtUtils) : base(context)
        {
            _jwtUtils = jwtUtils;
        }
        public IEnumerable<UserEntity> SearchUser(string keywords)
        {
            return _context.Set<UserEntity>().AsNoTracking().AsQueryable()
                 .Where(x => x.UserName.Equals(keywords)).ToArray();

        }
        public UserEntity GetUserById(int id)
        {
            return _context.Set<UserEntity>().AsNoTracking().AsQueryable()
                 .Where(x => x.Id == id).First();
        }

        public AuthenticateResponse? Authenticate(AuthenticateRequest model)
        {
            var user = _context.Set<UserEntity>().AsNoTracking().AsQueryable().SingleOrDefault(x => x.UserName == model.Username && x.PassWord == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = _jwtUtils.GenerateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }
    }
}
