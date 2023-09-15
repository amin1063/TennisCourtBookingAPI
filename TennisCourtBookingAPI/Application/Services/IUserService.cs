using System.Threading.Tasks;
using TennisCourtBooking.Domain.Models;

public interface IUserService
{
    Task<RegistrationResponse> RegisterUserAsync(UserRegistrationModel model);
    Task<AuthenticationResponse> AuthenticateUserAsync(UserLoginModel model);
    // Other methods related to user operations
}
