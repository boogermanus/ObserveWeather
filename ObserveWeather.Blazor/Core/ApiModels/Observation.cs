namespace ObserveWeather.Blazor.Core.ApiModels;

public class Observation
{
    public string Id { get; set; } = string.Empty;
    public ObservationProperties Properties { get; set; } = new ObservationProperties();
}