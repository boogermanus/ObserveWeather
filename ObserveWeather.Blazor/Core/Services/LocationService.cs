using ObserveWeather.Blazor.Core.ApiModels;
using ObserveWeather.Blazor.Core.Interfaces;
using ObserveWeather.Blazor.Core.Models;

namespace ObserveWeather.Blazor.Core.Services;

public class LocationService : ILocationService
{
    private readonly IUserStationRepository _userStationRepository;

    public LocationService(IUserStationRepository userStationRepository)
    {
        _userStationRepository = userStationRepository;
    }
    public async Task<UserStationModel?> AddAsync(Point? point, string? userId)
    {
        var displayName =
            $"{point.Properties.RelativeLocation.Properties.City}, {point.Properties.RelativeLocation.Properties.State}";
        var userStation = new UserStation
        {
            StationId = point.Properties.RadarStation,
            DisplayName =  displayName,
            UserId = userId
        };
        
        var result = await _userStationRepository.AddAsync(userStation);

        return result?.ToApiModel();
    }

    public async Task<IEnumerable<UserStationModel>> GetForUserAsync(string? userId)
    {
        var results = await _userStationRepository.GetForUserAsync(userId);
        
        return results.Select(r => r.ToApiModel()).ToList();
    }
}