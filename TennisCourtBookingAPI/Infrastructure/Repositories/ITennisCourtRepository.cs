using System.Collections.Generic;
using System.Threading.Tasks;
using TennisCourtBooking.Domain.Models;

public interface ITennisCourtRepository
{
    Task<TennisCourtModel> GetByIdAsync(int id);
    Task<IEnumerable<TennisCourtModel>> GetAllAsync();
    Task AddAsync(TennisCourtModel tennisCourt);
    Task UpdateAsync(TennisCourtModel tennisCourt);
    Task DeleteAsync(int id);
}
