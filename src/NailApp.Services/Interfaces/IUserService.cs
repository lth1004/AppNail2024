
using NailApp.Data.Entities;
using NailApp.Services.Dtos;

namespace NailApp.Services.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Get all Users
        /// </summary>
        /// <returns></returns>
        IEnumerable<UserDto> GetAll();

        /// <summary>
        /// SearchUser equal any
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        IEnumerable<UserDto> SearchUserName(string str);

        /// <summary>
        /// Get User by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserDto GetUserById(int id);

        /// <summary>
        /// Authenticate JW
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        AuthenticateDtoResponse? Authenticate(AuthenticateRequest model);
    }
}
