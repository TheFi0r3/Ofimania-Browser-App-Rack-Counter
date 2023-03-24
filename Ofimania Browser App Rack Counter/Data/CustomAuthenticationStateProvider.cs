using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorApp_Tutorial.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {

//            var identity = new ClaimsIdentity(new[]
//            {
//                new Claim(ClaimTypes.Name,"afiore"),
//          }, "apiauth_type");

            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            return Task.FromResult(new AuthenticationState(user));

        }

        public void MarkUserAsAuthenticated(string userId)
        {
            //throw new NotImplementedException();

            var identity = new ClaimsIdentity(new[]
{
                new Claim(ClaimTypes.Name,userId),
            }, "apiauth_type");

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged( Task.FromResult(new AuthenticationState(user)));
        }

    }
}
