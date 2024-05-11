using System.ComponentModel.DataAnnotations;

namespace NailApp.Services.Dtos
{
    public class AuthenticateDtoRequest
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
