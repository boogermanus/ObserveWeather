using ObserveWeather.Blazor.Core.Models;
using ObserveWeather.Core.Models;

namespace ObserveWeather.Core.Interfaces;

public interface IUserStationRepository
{
    Task<UserStation?> AddAsync(UserStation model);
    Task<UserStation?> DeleteAsync(UserStation model);
    Task<IEnumerable<UserStation>> GetForUserAsync(string userId);
}