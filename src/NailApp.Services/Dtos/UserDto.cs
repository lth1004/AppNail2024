namespace NailApp.Services.Dtos
{
    public class UserDto : BaseDto
    {
        public string UserName { get; set; } = string.Empty;
        public string PassWord { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contract { get; set; } = string.Empty;
    }
}
