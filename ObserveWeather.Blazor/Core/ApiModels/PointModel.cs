namespace ObserveWeather.Blazor.Core.ApiModels;

public class PointModel
{
    public string Id { get; set; } = string.Empty;
    public PointPropertiesModel Properties { get; set; } = new PointPropertiesModel();
}