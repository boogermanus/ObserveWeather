using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ObserveWeather.Blazor.Data;

namespace ObserveWeather.Blazor.Core.Models;

public class UserStation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int Id { get; set; }
    public required string StationId { get; set; }
    public required string UserId { get; set; }
    public ApplicationUser? User { get; set; }
    
}