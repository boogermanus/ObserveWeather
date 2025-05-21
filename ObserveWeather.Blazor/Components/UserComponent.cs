using Microsoft.AspNetCore.Components;

namespace ObserveWeather.Blazor.Components;

public class UserComponent : ComponentBase
{
    [Inject]
    protected IHttpContextAccessor HttpContextAccessor { get; set; } = default!;
    [Inject]
    protected IHttpClientFactory HttpClientFactory { get; set; } = default!;
    
}