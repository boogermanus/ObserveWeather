using ObserveWeather.Blazor.Core.ApiModels;
using ObserveWeather.Blazor.Core.Interfaces;

namespace ObserveWeather.Blazor.Core.Services;

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