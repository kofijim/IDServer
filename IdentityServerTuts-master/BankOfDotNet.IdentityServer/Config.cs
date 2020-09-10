using System.Collections.Generic;
using IdentityServer4.Models;

namespace BankOfDotNet.IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetAllApiResources => new List<ApiResource>
        {
            new ApiResource(
                "BankOfDotNetApi","Customer API for Bank of Dot net")
        };

        public static IEnumerable<Client> GetAllClients=>new List<Client>
        {
            new Client
            {
                ClientId = "client",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret>
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes = new List<string>
                {
                    "BankOfDotNetApi"
                }
            }
        };
    }
}