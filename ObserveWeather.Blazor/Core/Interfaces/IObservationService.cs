using ObserveWeather.Blazor.Components;
using ObserveWeather.Blazor.Core.ApiModels;

namespace ObserveWeather.Blazor.Core.Interfaces;

public interface IObservationService
{
    Task<ObservationModel?> GetObservation(string stationId);
}