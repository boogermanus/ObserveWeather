using System.Security.Claims;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace ObserveWeather.Blazor.Components;

public class UserComponent : ComponentBase
{
    [Inject]
    protected AuthenticationStateProvider  AuthenticationStateProvider { get; set; } = default!;

    [Inject]
    protected IHttpClientFactory HttpClientFactory { get; set; } = default!;
    
    // protected async Task<string?> UserId() =>
    //     (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User
    //     .FindFirstValue(ClaimTypes.NameIdentifier);
    private string? _userId = string.Empty;
    protected string? UserId => _userId;

    protected override async Task OnInitializedAsync()
    {
        _userId =
            (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User.FindFirstValue(ClaimTypes
                .NameIdentifier);  
        await base.OnInitializedAsync();
    }

}