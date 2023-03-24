using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Ofimania_Browser_App_Rack_Counter.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;
        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            var userId = await _sessionStorageService.GetItemAsync<string>("UserId");

            ClaimsIdentity identity;

            if (userId != null) 
            {
                identity = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name,userId),
                }, "apiauth_type");
            }
            else 
            {
                identity = new ClaimsIdentity();

            }

            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));

        }

        public void MarkUserAsLoggedIn(string userId)
        {
            //throw new NotImplementedException();

            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name,userId),
            }, "apiauth_type");

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged( Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsLoggedOut()
        {
            _sessionStorageService.RemoveItemAsync("userId");

            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
