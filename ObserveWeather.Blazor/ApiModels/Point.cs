namespace ObserveWeather.Blazor.ApiModels;

public class Point
{
    public string Id { get; set; } = string.Empty;
    public PointProperties Properties { get; set; } = new PointProperties();
}