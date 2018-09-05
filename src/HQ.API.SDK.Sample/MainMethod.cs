using Authentication;
using Config;
using System;

namespace HQ.API.SDK.Sample
{
    public class MainMethod
    {
        static void Main(string[] args)
        {
            // Create a client configuration with an OAuth Token Manager
            var config = new HQAPIClientConfiguration("https://api.hqlabs.de");
            var manager = config.CreateOAuthTokenManager("AppId", "AppSecret",
                "SyncUser-AccessToken",
                "SyncUser-RefreshToken",
                DateTime.UtcNow.AddSeconds(2500000));

            // Register a callback for when the token was refreshed
            manager.TokenRefreshed += Manager_TokenRefreshed;

            // Create the client with the configuration
            var client = new HQAPIClient(config);

            // Get the details about the currently authenticated user.
            var user = client.MeV1_GetAsync().Result;

            // Create and put a new UserReporting Example
            var newReproting = new CreateUserReportingAPISample();
            newReproting.CreateUserReportingApi(client);

            // Get and create Company Example
            var Company = new CompanyAPISample();
            Company.CompanyAPI(client);
        }

        private static void Manager_TokenRefreshed(object sender, TokenRefreshedEventArgs e)
        {
            // Store access and refresh token securely so they can be used again next time
        }
    }
}
