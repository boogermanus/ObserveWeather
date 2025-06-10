using System.Net.Http.Json;
using ObserveWeather.Core.ApiModels;
using ObserveWeather.Core.Interfaces;

namespace ObserveWeather.Core.Services;

public class ObservationService : IObservationService
{
    private readonly HttpClient _httpClient;

    public ObservationService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("api.weather.gov");
    }
    public async Task<ObservationModel?> GetObservation(string stationId)
    {
        return await _httpClient.GetFromJsonAsync<ObservationModel?>($"stations/{stationId}/observations/latest");
    }
}