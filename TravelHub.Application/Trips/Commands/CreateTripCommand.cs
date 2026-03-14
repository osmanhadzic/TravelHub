namespace TravelHub.Application.Trips.Commands;

public record CreateTripCommand(
    Guid UserId,
    string Name,
    DateTime StartDate,
    DateTime EndDate
);