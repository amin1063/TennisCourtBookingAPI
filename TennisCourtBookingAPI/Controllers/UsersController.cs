using Microsoft.AspNetCore.Mvc;
using TennisCourtBooking.Application.Services;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] UserRegistrationModel model)
    {
        var result = await _userService.RegisterUserAsync(model);

        if (result.Success)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] UserLoginModel model)
    {
        var result = await _userService.AuthenticateUserAsync(model);

        if (result.Success)
        {
            return Ok(result);
        }

        return Unauthorized(result);
    }
}
