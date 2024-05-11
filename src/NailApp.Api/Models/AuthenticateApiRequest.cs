using System.ComponentModel.DataAnnotations;

namespace NailApp.Api.Models
{
    public class AuthenticateApiRequest
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
