using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AuthAPI.Entities
{
    public class User
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [JsonIgnore]
        public string UserType { get; set; } = "user";

        [Required]
        public string Email { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [JsonIgnore]
        public bool IsConfirmed { get; set; }
    }
}
