using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ObserveWeather.Core.ApiModels;

namespace ObserveWeather.Core.Models;

public class UserStation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [MaxLength(4)]
    public required string StationId { get; set; }
    [MaxLength(200)]
    public required string DisplayName { get; set; }
    [MaxLength(36)]
    public required string UserId { get; set; }
    public ApplicationUser? User { get; set; }

    public UserStationModel ToApiModel()
    {
        return new UserStationModel
        {
            Id = Id,
            StationId = StationId,
            UserId = UserId,
            DisplayName = DisplayName,
        };
    }
    
}