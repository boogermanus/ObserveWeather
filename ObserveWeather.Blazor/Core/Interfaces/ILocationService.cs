using ObserveWeather.Blazor.Core.ApiModels;

namespace ObserveWeather.Blazor.Core.Interfaces;

public interface ILocationService
{
    Task<UserStationModel?> AddAsync(Point? point, string? userId);
    Task<IEnumerable<UserStationModel>> GetForUserAsync(string? userId);
    Task<UserStationModel?> DeleteAsync(UserStationModel model);
}