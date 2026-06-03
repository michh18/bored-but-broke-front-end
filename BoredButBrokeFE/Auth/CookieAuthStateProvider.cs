using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace BoredButBrokeFE.Auth
{
    public class CookieAuthStateProvider : AuthenticationStateProvider
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private static readonly AuthenticationState _loggedOut = new(new ClaimsPrincipal(new ClaimsIdentity()));
        public CookieAuthStateProvider(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var client = _httpClientFactory.CreateClient("BBBBackEnd");
                var response = await client.GetAsync("api/auth/me");

                if (!response.IsSuccessStatusCode) return _loggedOut;

                var user = await response.Content.ReadFromJsonAsync<UserInfo>();
                if (user is null) return _loggedOut;

                var claims = new[]
                {
                    new Claim(ClaimTypes.GivenName,  user.FirstName ?? string.Empty),
                    new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                };

                var identity = new ClaimsIdentity(claims, "cookie");
                var principal = new ClaimsPrincipal(identity);

                return new AuthenticationState(principal);
            }
            catch
            {
                return _loggedOut;
            }
        }

        public void NotifyAuthStateChanged()
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        private record UserInfo(string? Email, string? FirstName);
    }
}
