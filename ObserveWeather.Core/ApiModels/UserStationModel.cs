using ObserveWeather.Blazor.Core.Models;
using ObserveWeather.Core.Models;

namespace ObserveWeather.Core.ApiModels;

public class UserStationModel
{
    public int Id { get; set; }
    public required string StationId { get; set; }
    public required string UserId { get; set; }
    public required string DisplayName { get; set; }

    public UserStation ToDomainModel()
    {
        return new UserStation
        {
            Id = Id,
            StationId = StationId,
            UserId = UserId,
            DisplayName = DisplayName,
        };
    }
}