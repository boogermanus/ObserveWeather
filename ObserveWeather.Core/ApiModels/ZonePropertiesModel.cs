﻿namespace ObserveWeather.Core.ApiModels;

public class ZonePropertiesModel
{
    public IEnumerable<string> ObservationStations { get; set; } = new List<string>();
}