namespace NailApp.API.Models
{
    public class User 
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string PassWord { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contract { get; set; } = string.Empty;
    }
}
