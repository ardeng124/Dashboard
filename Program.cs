using DashboardProject.Application.Interfaces.Repositories;
using DashboardProject.Application.Interfaces.Services;
using DashboardProject.Application.Services;
using DashboardProject.Persistance.Context;
using DashboardProject.Persistance.Repositories;
using DashboardProject.Components;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("PostgresConnection");

builder.Services.AddDbContext<DashboardDbContext>(options => options.UseNpgsql(connectionString));

// Blazor
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

// DI
builder.Services.AddScoped<IWeatherLocationRepository, WeatherLocationRepository>();
builder.Services.AddScoped<IWeatherLocationService, WeatherLocationService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
