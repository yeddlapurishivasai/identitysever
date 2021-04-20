using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace IdentityServerWeb
{
    internal class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
        {
            ////new Client
            ////{
            ////    ClientId = "oauthClient",
            ////    ClientName = "Example client application using client credentials",
            ////    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
            ////    ClientSecrets = new List<Secret> {new Secret("SuperSecretPassword".Sha256())}, // change me!
            ////    AllowedScopes = new List<string> {"api1.read"}
            ////}
            ///
            new Client {
                ClientId = "angular_spa",
                ClientName = "Angular 4 Client",
                AllowedGrantTypes = GrantTypes.Implicit,
                AllowedScopes = new List<string> { "openid", "profile", "api1" },
                RedirectUris = new List<string> { "http://localhost:4200/auth-callback" },
                PostLogoutRedirectUris = new List<string> { "http://localhost:4200/" },
                AllowedCorsOrigins = new List<string> { "http://localhost:4200" },
                AllowAccessTokensViaBrowser = true
            }
        };
        }
    }
}
