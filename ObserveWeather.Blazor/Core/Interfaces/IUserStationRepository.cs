using ObserveWeather.Blazor.Core.Models;

namespace ObserveWeather.Blazor.Core.Interfaces;

public interface IUserStationRepository
{
    Task<UserStation?> AddAsync(UserStation model);
    Task<UserStation?> DeleteAsync(UserStation model);
    Task<IEnumerable<UserStation>> GetForUserAsync(string userId);
}