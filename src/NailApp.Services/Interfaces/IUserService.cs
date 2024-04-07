
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
    }
}
