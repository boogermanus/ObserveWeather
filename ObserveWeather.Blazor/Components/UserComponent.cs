using Microsoft.AspNetCore.Components;

namespace ObserveWeather.Blazor.Components;

public class UserComponent : ComponentBase
{
    [Inject]
    protected IHttpContextAccessor HttpContextAccessor { get; set; } = null!;
    
}