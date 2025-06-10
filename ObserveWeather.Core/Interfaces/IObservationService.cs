using ObserveWeather.Core.ApiModels;

namespace ObserveWeather.Core.Interfaces;

public interface IObservationService
{
    Task<ObservationModel?> GetObservation(string stationId);
}