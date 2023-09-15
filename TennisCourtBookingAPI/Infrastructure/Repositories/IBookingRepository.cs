using System.Collections.Generic;
using System.Threading.Tasks;
using TennisCourtBooking.Domain.Models;

public interface IBookingRepository
{
    Task<BookingModel> GetByIdAsync(int id);
    Task<IEnumerable<BookingModel>> GetAllAsync();
    Task AddAsync(BookingModel booking);
    Task UpdateAsync(BookingModel booking);
    Task DeleteAsync(int id);
}
