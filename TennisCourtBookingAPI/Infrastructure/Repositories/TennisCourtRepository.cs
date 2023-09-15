using System.Threading.Tasks;
using TennisCourtBooking.Domain.Models;
using TennisCourtBooking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TennisCourtBooking.Infrastructure.Repositories
{
    public class TennisCourtRepository
    {
        private readonly ApplicationDbContext _context;

        public TennisCourtRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TennisCourt> GetByIdAsync(int id)
        {
            var tenniscourt = await _context.TennisCourts.FirstOrDefaultAsync(b => b.Id == id);

            if (tenniscourt == null)
            {
                return null; // Return null if the booking is not found.
            }

            return tenniscourt; // Return the booking object if found.
        }

       
    }
}
