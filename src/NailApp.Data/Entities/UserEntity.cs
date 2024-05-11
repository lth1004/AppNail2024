using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NailApp.Data.Entities
{
    [Table("User")]
    public class UserEntity : BaseEntity
    {
        [MaxLength(100)]
        public string UserName { get; set; } = string.Empty;
        [MaxLength(100)]
        [JsonIgnore]
        public string PassWord { get; set; } = string.Empty;
        [MaxLength(255)]
        public string Address { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Contract { get; set; } = string.Empty;

    }
}
