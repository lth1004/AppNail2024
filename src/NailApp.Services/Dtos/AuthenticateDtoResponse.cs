
namespace NailApp.Services.Dtos
{
    public class AuthenticateDtoResponse
    {
        public AuthenticateDtoResponse()
        {
        }
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contract { get; set; } = string.Empty;
        public string Token { get; set; }

        public AuthenticateDtoResponse(UserDto user, string token)
        {
            Id = user.Id;
            UserName = user.UserName;
            Address = user.Address;
            Contract = user.Contract;
            Token = token;
        }
    }
}
