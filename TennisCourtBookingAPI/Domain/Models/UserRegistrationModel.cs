using System.ComponentModel.DataAnnotations;

public class UserRegistrationModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    // Add any additional properties relevant to user registration.
}
