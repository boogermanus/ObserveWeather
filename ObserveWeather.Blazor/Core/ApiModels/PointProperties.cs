namespace ObserveWeather.Blazor.Core.ApiModels;

public class PointProperties
{
    public RelativeLocation RelativeLocation { get; set; } = new RelativeLocation();
    public string RadarStation { get; set; } = string.Empty;
}