using ObserveWeather.Blazor.Core.Models;

namespace ObserveWeather.Blazor.Core.ApiModels;

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
            StationId = StationId,
            UserId = UserId,
            DisplayName = DisplayName,
        };
    }
}