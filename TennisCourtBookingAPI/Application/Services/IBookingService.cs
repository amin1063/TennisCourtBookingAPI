// Services/IBookingService.cs
using System.Threading.Tasks;
using System.Collections.Generic;

public interface IBookingService
{
    Task<BookingResponse> MakeBookingAsync(BookingModel model);
    Task<IEnumerable<BookingModel>> GetAllBookings();
    Task<BookingResponse> UpdateBookingAsync(int id, BookingModel model);
    Task<BookingResponse> CancelBookingAsync(int id);
    // Add other booking-related methods
}
