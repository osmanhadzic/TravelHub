using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore;
using TravelHub.Infrastructure.Persistence;
using TravelHub.Infrastructure.Repositories;
using TravelHub.Domain.Interfaces;
using TravelHub.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddDbContext<TravelHubDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ITripRepository, TripRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

//app.UseHttpsRedirection();

app.MapTripsEndpoints();

app.Run();