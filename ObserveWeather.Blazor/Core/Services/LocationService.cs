using Microsoft.AspNetCore.Components;
using ObserveWeather.Blazor.Core.ApiModels;
using ObserveWeather.Blazor.Core.Interfaces;
using ObserveWeather.Blazor.Core.Models;

namespace ObserveWeather.Blazor.Core.Services;

public class LocationService : ILocationService
{
    private readonly IUserStationRepository _userStationRepository;
    private readonly HttpClient _httpClient;

    public LocationService(IUserStationRepository userStationRepository, IHttpClientFactory httpClientFactory)
    {
        _userStationRepository = userStationRepository;
        _httpClient = httpClientFactory.CreateClient("api.weather.gov");
    }
    public async Task<UserStationModel?> AddAsync(PointModel? point, string? userId)
    {
        ArgumentNullException.ThrowIfNull(point);
        ArgumentNullException.ThrowIfNull(userId);
        
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

    public async Task<UserStationModel?> AddAsync(string stationId, string stationName, string? userId)
    {
        ArgumentNullException.ThrowIfNull(stationId);
        ArgumentNullException.ThrowIfNull(stationName);
        ArgumentNullException.ThrowIfNull(userId);

        var userStation = new UserStation
        {
            StationId = stationId,
            DisplayName = stationName,
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

    public async Task<PointModel?> GetPointAsync(double latitude, double longitude)
    {
        var result =
            await _httpClient.GetFromJsonAsync<PointModel?>($"points/{latitude},{longitude}");

        return result;
    }
}