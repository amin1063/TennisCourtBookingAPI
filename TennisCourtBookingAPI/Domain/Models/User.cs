// User.cs
namespace TennisCourtBooking.Domain.Models
{
    public class User
    {
        // Properties
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        // Other user properties...
    }
}
