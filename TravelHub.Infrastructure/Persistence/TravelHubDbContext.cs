using Microsoft.EntityFrameworkCore;
using TravelHub.Domain.Entities;

namespace TravelHub.Infrastructure.Persistence;

public class TravelHubDbContext : DbContext
{
    public TravelHubDbContext(DbContextOptions<TravelHubDbContext> options)
        : base(options)
    {
    }

    public DbSet<Trip> Trips => Set<Trip>();
}