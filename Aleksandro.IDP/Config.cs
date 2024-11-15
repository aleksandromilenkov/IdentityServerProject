using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using System.Security.Cryptography;

namespace Aleksandro.IDP;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResource("roles", "Your role(s)", new[] {"role"}),
            //adding new claim for country that we'll need for the Policy:
            new IdentityResource("country", "The country you are living in", new List<string>{"country"}),
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            { 
                new ApiScope("imagegalleryapi.fullaccess"),            
                new ApiScope("imagegalleryapi.write"),            
                new ApiScope("imagegalleryapi.read"),            
            };

    public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
    {
        new ApiResource("imagegalleryapi",
            "Image Gallery API",
            new[] {"role", "country"}
            )
        {
            Scopes = { "imagegalleryapi.fullaccess", "imagegalleryapi.write", "imagegalleryapi.read" },
            ApiSecrets = { new Secret("apisecret".Sha256())}
        }
    };

    public static IEnumerable<Client> Clients =>
        new Client[] 
            { 
                new Client()
                {
                    ClientName= "Image Gallery",
                    ClientId = "imagegalleryclient",
                    AllowedGrantTypes = GrantTypes.Code,
                    AccessTokenType = AccessTokenType.Reference,
                    //IdentityTokenLifetime = ... The default is 5 minutes but you can set it here to custom value
                    // AuthorizationCodeLifetime = ... Time for lasting the code that is exchanged for accessToken in the Client
                    AccessTokenLifetime = 120,
                    AllowOfflineAccess = true, // this is creating the 'offline_access' scope this is needed for refresh tokens
                    UpdateAccessTokenClaimsOnRefresh = true, // If some user claim is changed this will update it
                    RedirectUris =
                    {
                        "https://localhost:7184/signin-oidc"
                    },
                    PostLogoutRedirectUris =
                    {
                        "https://localhost:7184/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        //"imagegalleryapi.fullaccess",
                        "imagegalleryapi.read",
                        "imagegalleryapi.write",
                        "country"
                    },
                    ClientSecrets =
                    {
                        new Secret("tajna".Sha256())
                    },
                    RequireConsent= true
                }
            };
}