namespace ObserveWeather.Core.ApiModels;

public class PointPropertiesModel
{
    public RelativeLocationModel RelativeLocation { get; set; } = new RelativeLocationModel();
    public string ForecastZone { get; set; } = string.Empty;
    public string RadarStation { get; set; } = string.Empty;
}