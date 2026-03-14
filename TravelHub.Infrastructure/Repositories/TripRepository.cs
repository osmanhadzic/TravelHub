using Microsoft.EntityFrameworkCore;
using TravelHub.Domain.Entities;
using TravelHub.Domain.Interfaces;
using TravelHub.Infrastructure.Persistence;

namespace TravelHub.Infrastructure.Repositories;

public class TripRepository : ITripRepository
{
    private readonly TravelHubDbContext _context;

    public TripRepository(TravelHubDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Trip trip)
    {
        await _context.Trips.AddAsync(trip);
        await _context.SaveChangesAsync();
    }

    public async Task<Trip?> GetByIdAsync(Guid id)
    {
        return await _context.Trips.FirstOrDefaultAsync(x => x.Id == id);
    }
}