// ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using TennisCourtBooking.Domain.Models;

namespace TennisCourtBooking.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TennisCourt> TennisCourts { get; set; }
        public DbSet<BookingModel> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships, constraints, and seed data here if needed.
        }
    }
}
