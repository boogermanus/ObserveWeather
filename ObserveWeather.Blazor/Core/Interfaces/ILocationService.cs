using ObserveWeather.Blazor.Core.ApiModels;

namespace ObserveWeather.Blazor.Core.Interfaces;

public interface ILocationService
{
    Task<UserStationModel?> AddAsync(UserStationModel userStation);
}