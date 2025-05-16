namespace ObserveWeather.Blazor.Core.Models;

public class QuantitativeValue
{
    public double? Value { get; set; }
    public string UnitCode { get; set; } = string.Empty;
}