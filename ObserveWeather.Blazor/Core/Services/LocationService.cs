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
    public async Task<UserStationModel?> AddAsync(PointModel? point, string? userId)
    {
        ArgumentNullException.ThrowIfNull(point);
        ArgumentNullException.ThrowIfNull(userId);
        
        var displayName =
            $"{point.Properties.RelativeLocationModel.Properties.City}, {point.Properties.RelativeLocationModel.Properties.State}";
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
        ArgumentNullException.ThrowIfNull(userId);
        
        var results = await _userStationRepository.GetForUserAsync(userId);
        
        return results.Select(r => r.ToApiModel()).ToList();
    }

    public async Task<UserStationModel?> DeleteAsync(UserStationModel model)
    {
        var result = await _userStationRepository.DeleteAsync(model.ToDomainModel());
        return result?.ToApiModel();
    }
}