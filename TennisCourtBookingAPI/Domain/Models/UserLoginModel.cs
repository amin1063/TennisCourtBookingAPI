using System.ComponentModel.DataAnnotations;

public class UserLoginModel
{
    [Required]
    public string UsernameOrEmail { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }
}
