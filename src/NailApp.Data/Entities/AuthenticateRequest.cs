using System.ComponentModel.DataAnnotations;

namespace NailApp.Data.Entities
{
    public class AuthenticateRequest
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
