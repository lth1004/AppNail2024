
using NailApp.Data.Entities;

namespace NailApp.Data.Interfaces
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        IEnumerable<UserEntity> SearchUser(string keywords);
        UserEntity GetUserById(int id);
        AuthenticateResponse? Authenticate(AuthenticateRequest model);
    }
}
