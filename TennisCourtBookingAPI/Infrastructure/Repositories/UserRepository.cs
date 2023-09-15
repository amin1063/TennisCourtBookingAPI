using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TennisCourtBooking.Domain.Models;
using TennisCourtBooking.Infrastructure.Data;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> GetByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task AddAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
        _context.Entry(user).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }

    Task<User> IUserRepository.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<User> IUserRepository.GetByUsernameAsync(string username)
    {
        throw new NotImplementedException();
    }

    Task IUserRepository.AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    Task IUserRepository.UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }

    Task IUserRepository.DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}
