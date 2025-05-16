namespace ObserveWeather.Blazor.Core.ApiModels;

public class PointPropertiesModel
{
    public RelativeLocationModel RelativeLocation { get; set; } = new RelativeLocationModel();
    public string RadarStation { get; set; } = string.Empty;
}