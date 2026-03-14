using TravelHub.Application.Trips.Commands;
using TravelHub.Domain.Entities;
using TravelHub.Domain.Interfaces;

namespace TravelHub.Application.Trips.Handlers;

public class CreateTripHandler
{
    private readonly ITripRepository _repository;

    public CreateTripHandler(ITripRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateTripCommand command)
    {
        var trip = new Trip
        {
            Id = Guid.NewGuid(),
            UserId = command.UserId,
            Name = command.Name,
            StartDate = command.StartDate,
            EndDate = command.EndDate
        };

        await _repository.AddAsync(trip);
    }
}