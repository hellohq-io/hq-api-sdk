# This repository is deprecated and will not be updated anyore


# HQ API SDK - the C# library for the HQ API

This C# SDK allows convenient access to the HQ API.

- API version: v1
- SDK version: 1.3.0

## HQ API Documentation

https://api.hqlabs.de/

## Frameworks supported
- .NET 4.0 or later

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 10.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using HQ.API.SDK.Authentication;
using HQ.API.SDK.Config;
```

## Getting Started

The following sample shows the basic usage of the SDK. 
You need to provide the AppId and AppSecret for your client application, which you need to register in the HQ administration panel of your system.

This sample uses the pre-shared Access Token for the SyncUser, which is used for non-personal access. The token can be retrieved in the administration panel of your HQ system.
Read more about authentication in the section below.

```csharp
using Authentication;
using Config;
using System;

namespace HQ.API.SDK.Sample
{
    public class CompanyAPISample
    {
        static void Main(string[] args)
        {
            // Create a client configuration with an OAuth Token Manager, using the pre-shared Access Token for the Sync User
            var config = new HQAPIClientConfiguration("https://api.hqlabs.de");
            var manager = config.CreateOAuthTokenManager("AppId", "AppSecret",
                "SyncUser-AccessToken");

            // Register a callback for when the token was refreshed
            manager.TokenRefreshed += Manager_TokenRefreshed;

            // Create the client with the configuration
            var client = new HQAPIClient(config);

            // Get a company by id
            var companyById = client.CompaniesV1_GetByIdAsync(1234).Result;
            Console.WriteLine("Company by Id: " + companyById.Name);

            // Modify the company name and save it using a PUT
            companyById.Name = companyById.Name + " (API)";
            companyById = client.CompaniesV1_PutByIdAsync(companyById.Id, companyById).Result;

            // Create a new company with a default address and a company type
            var newCompany = new Company()
            {
                Name = "Unit Corp.",
                DebitorNumber = 3456,
                CreditorNumber = 1234,
                Description = "A test corporation",
                IndustrialSector = "Testing",
                DefaultAddress = new CompanyAddress()
                {
                    Street = "Am Kaiserkai 70",
                    City = "Hamburg",
                    Country = "DE",
                    DefaultForDocumentType = CompanyAddressDefaultForDocumentType.Invoice,
                },
                CompanyTypes = new System.Collections.ObjectModel.ObservableCollection<CompanyTypeOfCompany>()
                {
                    new CompanyTypeOfCompany()
                    {
                        Id = 1, // Here, 1 is the Id of type 'Customer'
                    }
                }
            };

            // POST the new company to create it
            var newCompanyResult = client.CompaniesV1_PostAsync(newCompany).Result;
            Console.WriteLine("New Company Id: " + newCompanyResult.Id);

            // Delete the new company
            var deletedCompany = client.CompaniesV1_DeleteByIdAsync(newCompanyResult.Id).Result;

            // Various filter and expand examples. See the OData docs for more information
            var companies = client.CompaniesV1_GetAsync().Result; // Get all companies
            //var companies = client.CompaniesV1_GetAsync(filter: "Id eq 1234").Result; // Get a company with a filter by Id
            //var companies = client.CompaniesV1_GetAsync(filter: "indexof(Name, 'Corp') ge 0").Result; // Get all companies where the name contains 'Corp'
            //var companies = client.CompaniesV1_GetAsync(filter: "UpdatedOn gt 2016-02-15T14:17:40+01:00").Result; // Get all companies modified after 15th of February 2016
            //var companies = client.CompaniesV1_GetAsync(expand: "CompanyTypes").Result; // Get all companies with their company types
            //var companies = client.CompaniesV1_GetAsync(expand: "CompanyTypes", filter: "CompanyTypes/any(companyType: companyType/Name eq 'Customer')").Result; // Returns all companies of type 'Customer'

            // Display the results
            foreach (var item in companies)
            {
                Console.WriteLine(item.Id + ": " + item.Name);
                if (item.CompanyTypes != null)
                {
                    foreach (var companyType in item.CompanyTypes)
                    {
                        Console.WriteLine("    " + companyType.Name);
                    }
                }
            }

            // Wait to show the results
            Console.ReadLine();
        }

        private static void Manager_TokenRefreshed(object sender, TokenRefreshedEventArgs e)
        {
            // Store access and refresh token securely so they can be used again next time
            User.AccessToken = e.TokenResponse.AccessToken;
            User.RefreshToken = e.TokenResponse.RefreshToken;
            User.TokenExpiresOn = DateTime.UtcNow.Add(e.TokenResponse.GetExpirationTimeSpan());
        }
    }
}

```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.hqlabs.de/*

Visit the <a href="https://api.hqlabs.de/docs/index">HQ API documentation</a> for details about the entities and their endpoints.

## Documentation for Authorization

### OAuth 2.0

The HQ API uses OAuth 2.0 Authentication, which is a secure and flexible authentication framework. 
This way, the users are authenticated personally and their right levels in API and HQ are identical.

To enabled non-personal access, for example for background sync activities like imports and exports which require full read and write access, the API provides a dedicated Sync User with a pre-shared Access Token. This token can be retrieved in the HQ administration panel.

Read more about OAuth 2.0 authentication in the <a href="https://api.hqlabs.de/docs/index">HQ API documentation</a> or the <a href="https://oauth.net/2/">OAuth 2.0 framework documentation</a>.


### Getting an Access Token for a user

The following sample code shows how to initially retrieve an Access and Refresh Token for a user. The internal user id can be passed as a state argument, which will be returned in the response URL. This makes it easier for your application to match the received token to a user.

```csharp

public function GetAccessTokenForUser(string internalUserId)
{
    // Construct the authorization URL
    var authorizeUrl = OAuthTokenManager.GetAuthorizeUrl("AppId", internalUserId, "http://localhost/", new string[] {"read_all","write_all"});

    // Direct a web browser to the authorizeUrl
    ....

    // Retrieve the authorization code from the response URL
    var authorizationCode = ....

    // Configure the client and token manager
    var config = new HQAPIClientConfiguration("https://api.hqlabs.de");
    var manager = config.CreateOAuthTokenManager("AppId", "AppSecret");

    // Register a callback for when the token was refreshed
    manager.TokenRefreshed += Manager_TokenRefreshed;

    // Exchange the authorization code for an Access Token
    manager.GetAccessToken(authorizationCode, "http://localhost/");

    // Create the client with the configuration
    var client = new HQAPIClient(config);

    // Use the client
    .....
}
    
private void Manager_TokenRefreshed(object sender, TokenRefreshedEventArgs e)
{
    // Store access and refresh token securely so they can be used again next time
    User.AccessToken = e.TokenResponse.AccessToken;
    User.RefreshToken = e.TokenResponse.RefreshToken;
    User.TokenExpiresOn = DateTime.UtcNow.Add(e.TokenResponse.GetExpirationTimeSpan());
}

```


### Using a previously received Access and Refresh Token

After you have initially received an Access Token and Refresh Token for a user, you can pass those to the client configuration directly so that no further user interaction is required.

```csharp

public HQAPIClient ConstructClientForUser(string accessToken, string refreshToken)
{
    // Configure the client and token manager
    var config = new HQAPIClientConfiguration("https://api.hqlabs.de");
    var manager = config.CreateOAuthTokenManager("AppId", "AppSecret"
        accessToken, refreshToken);

    // Register a callback for when the token was refreshed
    manager.TokenRefreshed += Manager_TokenRefreshed;

    // Create the client with the configuration
    var client = new HQAPIClient(config);

    // Use the client
    return client;
}
    
private void Manager_TokenRefreshed(object sender, TokenRefreshedEventArgs e)
{
    // Store access and refresh token securely so they can be used again next time
    User.AccessToken = e.TokenResponse.AccessToken;
    User.RefreshToken = e.TokenResponse.RefreshToken;
    User.TokenExpiresOn = DateTime.UtcNow.Add(e.TokenResponse.GetExpirationTimeSpan());
}

```

## Feedback and Support

Let us know what you think of our API and SDK! For feedback, suggestions and questions, please contact us at <a href="mailto:support@helloHQ.io">support@helloHQ.io</a>.


## Website and Contact

http://helloHQ.io
<br/>
<a href="mailto:support@helloHQ.io">support@helloHQ.io</a>
