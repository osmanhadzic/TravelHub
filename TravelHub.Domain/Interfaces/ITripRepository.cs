using TravelHub.Domain.Entities;

namespace TravelHub.Domain.Interfaces;

public interface ITripRepository
{
    Task AddAsync(Trip trip);

    Task<Trip?> GetByIdAsync(Guid id);
}