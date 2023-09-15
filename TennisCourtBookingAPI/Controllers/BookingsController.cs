// Controllers/BookingsController.cs
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

[Route("api/bookings")]
[ApiController]
public class BookingsController : ControllerBase
{
    private readonly IBookingService _bookingService;

    public BookingsController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }

    [HttpPost("make")]
    public async Task<IActionResult> MakeBooking([FromBody] BookingModel model)
    {
        var result = await _bookingService.MakeBookingAsync(model);

        if (result.Success)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }

    
}
