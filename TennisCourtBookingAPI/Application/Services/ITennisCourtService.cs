using System.Threading.Tasks;
using TennisCourtBooking.Domain.Models;

public interface ITennisCourtService
{
    Task<IEnumerable<TennisCourt>> GetAllTennisCourts();
    Task<TennisCourtResponse> CreateTennisCourtAsync(TennisCourt model);
    Task<TennisCourtResponse> UpdateTennisCourtAsync(int id, TennisCourt model);
    Task<TennisCourtResponse> DeleteTennisCourtAsync(int id); // Add this method to the interface
}
