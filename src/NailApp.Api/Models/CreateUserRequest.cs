namespace NailApp.API.Models
{
    public class UserRequest
    {
        public string UserName { get; set; } = string.Empty;
        public string PassWord { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contract { get; set; } = string.Empty;
    }
}
