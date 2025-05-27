namespace ObserveWeather.Blazor.Core.ApiModels;

public class ObservationModel
{
    public string Id { get; set; } = string.Empty;
    public ObservationPropertiesModel Properties { get; set; } = new ObservationPropertiesModel();
    public double TemperatureF => ConvertToFahrenheit(Properties.Temperature.Value);
    public double DewpointF => ConvertToFahrenheit(Properties.Dewpoint.Value);
    public double WindSpeedMph => ConvertToMph(Properties.WindSpeed.Value);
    public double WindGustMph => ConvertToMph(Properties.WingGust.Value);
    public double PressureBar =>
        Properties.BarometricPressure.Value.HasValue ? Properties.BarometricPressure.Value.Value / 100 : 0;
    public string? PressureBarString => PressureBar != 0 ? $"{PressureBar} mb" : null;
    public double PressureHgIn => Properties.BarometricPressure.Value.HasValue
        ? Math.Round(Properties.BarometricPressure.Value.Value / 3386, 2)
        : 0;
    private string? PressureHgString => PressureBar != 0 ? $"{PressureHgIn} in" : null;
    public string PressureString =>
        Properties.BarometricPressure.Value.HasValue ? $"{PressureHgIn} ({PressureHgString})" : "n/a";

    private double VisibilityMiles => Properties.Visibility.Value.HasValue
        ? Math.Round(Properties.Visibility.Value.Value / 1609, 2)
        : 0;
    private string? VisibilityMilesString => VisibilityMiles != 0 ? $"{VisibilityMiles} mi" : null ;

    private double VisibilityKilometers =>
        Properties.Visibility.Value.HasValue ? Properties.Visibility.Value.Value / 1000 : 0;
    private string? VisibilityKilometersString =>
        VisibilityKilometers != 0 ? $"{VisibilityKilometers} km" : null;
    public string VisibilityString => Properties.Visibility.Value.HasValue
        ? $"{VisibilityMilesString} ({VisibilityKilometersString})"
        : "n/a";

    public double WindChillF => ConvertToFahrenheit(Properties.WindChill.Value);
    public double WindChillC => Math.Round(Properties.WindChill.Value ?? 0, 2);
    public double HeatIndexF => ConvertToFahrenheit(Properties.HeatIndex.Value);
    public double HeatIndexC => Math.Round(Properties.HeatIndex.Value ?? 0, 2);
    public double Humidity => Math.Round(Properties.RelativeHumidity.Value ?? 0, 0);

    public string WindDirection => ConvertToDirection(Properties.WindDirection.Value);
    public string GustDirection => ConvertToDirection(Properties.WingGust.Value);
    private double ConvertToFahrenheit(double? celsius) => celsius != null ? Math.Round(celsius.Value * 9 / 5 + 32, 2) : 0;
    private double ConvertToMph(double? kph) => kph != null ? Math.Round(kph.Value / 1.609, 0) : 0;
    
    private static string ConvertToDirection(double? degrees)
    {
        if(degrees == null)
            return string.Empty;
        
        string[] caridnals = { "N", "NE", "E", "SE", "S", "SW", "W", "NW", "N" };
        return caridnals[ (int)Math.Round(((double)degrees % 360) / 45) ];
    }

}