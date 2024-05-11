namespace NailApp.Data.Entities
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contract { get; set; } = string.Empty;
        public string Token { get; set; }

        public AuthenticateResponse(UserEntity user, string token)
        {
            Id = user.Id;
            UserName = user.UserName;
            Address = user.Address;
            Contract = user.Contract;
            Token = token;
        }
    }
}
