using TennisCourtBooking.Application.Services;
using TennisCourtBooking.Domain.Models;
using TennisCourtBooking.Infrastructure.Repositories;

public class TennisCourtService
{
    private readonly ITennisCourtRepository _tennisCourtRepository;

    public TennisCourtService(ITennisCourtRepository tennisCourtRepository)
    {
        _tennisCourtRepository = tennisCourtRepository;
    }

    public async Task<TennisCourtModel> GetTennisCourtByIdAsync(int id)
    {
        // Implement logic to get a tennis court by ID using the repository.
        var tennisCourt = await _tennisCourtRepository.GetByIdAsync(id);

        if (tennisCourt == null)
        {
            // If the tennis court is not found, you can return null or throw an exception.
            throw new NotFoundException("Tennis court not found"); // You need to define this exception class.
        }

        return tennisCourt; // Make sure to return a value when the tennis court is found.
    }

    // Implement other tennis court-related business logic.
}
