using System.Runtime.CompilerServices;
namespace crud_aspnet_core_webapi.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public bool Status { get; set; }
    }
}