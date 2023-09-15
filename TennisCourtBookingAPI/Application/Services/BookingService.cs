using TennisCourtBooking.Application.Services;
using TennisCourtBooking.Domain.Models;
using TennisCourtBooking.Infrastructure.Repositories;

public class BookingService
{
    private readonly BookingRepository _bookingRepository;

    public BookingService(BookingRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    public async Task<BookingModel> GetBookingByIdAsync(int id)
    {
        // Implement logic to get a booking by ID using the repository.
        var booking = await _bookingRepository.GetByIdAsync(id);

        if (booking == null)
        {
            // If the booking is not found, you can return null or throw an exception.
            throw new NotFoundException("Booking not found"); // You need to define this exception class.
        }

        return booking; // Return the BookingModel.
    }

    // Implement other booking-related business logic.
}
