namespace ObserveWeather.Blazor.Core.ApiModels;

public class PointPropertiesModel
{
    public RelativeLocationModel RelativeLocationModel { get; set; } = new RelativeLocationModel();
    public string RadarStation { get; set; } = string.Empty;
}