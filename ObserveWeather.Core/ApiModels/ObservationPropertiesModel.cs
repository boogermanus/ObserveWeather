using ObserveWeather.Blazor.Core.Models;

namespace ObserveWeather.Core.ApiModels;

public class ObservationPropertiesModel
{
    public string Id { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public string TextDescription { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public QuantitativeValue Temperature { get; set; } = new QuantitativeValue();
    public QuantitativeValue Dewpoint { get; set; } = new QuantitativeValue();
    public QuantitativeValue WindDirection { get; set; } = new QuantitativeValue();
    public QuantitativeValue WindSpeed { get; set; } = new QuantitativeValue();
    public QuantitativeValue WingGust { get; set; } = new QuantitativeValue();
    public QuantitativeValue BarometricPressure { get; set; } = new QuantitativeValue();
    public QuantitativeValue SeaLevelPressure { get; set; } = new QuantitativeValue();
    public QuantitativeValue Visibility { get; set; } = new QuantitativeValue();
    public QuantitativeValue RelativeHumidity { get; set; } = new QuantitativeValue();
    public QuantitativeValue WindChill { get; set; } = new QuantitativeValue();
    public QuantitativeValue HeatIndex { get; set; } = new QuantitativeValue();
    
    
}