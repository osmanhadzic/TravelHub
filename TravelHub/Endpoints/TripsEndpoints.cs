using TravelHub.Application.Trips.Commands;

namespace TravelHub.API.Endpoints;

public static class TripsEndpoints
{
    public static void MapTripsEndpoints(this WebApplication app)
    {
        app.MapPost("/trips", (CreateTripCommand command) =>
        {
            return Results.Ok(command);
        });
    }
}