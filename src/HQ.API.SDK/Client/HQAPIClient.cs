using Config;
using DotNetOpenAuth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HQ.API.SDK
{
    public partial class HQAPIClient
    {
        private HQAPIClientConfiguration _configuration { get; set; }

        public HQAPIClient(HQAPIClientConfiguration configuration) : this(configuration.BaseUrl)
        {
            _configuration = configuration;
            //authServer = new AuthorizationServerDescription()
            //{
            //    AuthorizationEndpoint = new Uri(configuration.BaseUrl + AuthorizeUrl),
            //    TokenEndpoint = new Uri(configuration.BaseUrl + TokenUrl),
            //};
            //client = new WebServerClient(authServer, clientId, clientSecret);
        }

        /// <summary>
        /// Updates the configuration of this client, used by all future requests. The base url cannot be updated this way.
        /// </summary>
        /// <param name="configuration"></param>
        public void SetConfiguration(HQAPIClientConfiguration configuration)
        {
            _configuration = configuration;
            authServer = new AuthorizationServerDescription()
            {
                AuthorizationEndpoint = new Uri(configuration.BaseUrl + AuthorizeUrl),
                TokenEndpoint = new Uri(configuration.BaseUrl + TokenUrl),
            };
        }

        /// <summary>
        /// Prepares the request and adds authentication details
        /// </summary>
        /// <param name="request"></param>
        /// <param name="url"></param>
        partial void PrepareRequest(HttpClient request, ref string url)
        {
            if (_configuration != null && _configuration.Credentials != null)
                request.DefaultRequestHeaders.Add("Authorization", _configuration.Credentials.GetAuthorizationCode());
        }

        partial void ProcessResponse(HttpClient request, HttpResponseMessage response)
        {

        }

        #region OAuth 2.0

        private const string AuthorizeUrl = "Account/Authorize";
        private const string TokenUrl = "Token";
        private readonly string clientId = "591379-hqsb";
        private readonly string clientSecret = "hqsb";
        private readonly WebServerClient client;

        private AuthorizationServerDescription authServer;

        public async void Index(string go)
        {
            if (!String.IsNullOrWhiteSpace(go))
            {
                var response = await client.PrepareRequestUserAuthorizationAsync(new[] { "Read.Contacts" });

                Console.WriteLine(response.RequestMessage);
                //client.RequestUserAuthorization(new[] { "Read.Contacts" },
                //new Uri(Url.Action("Exchange", "Home", null,
                //Request.Url.Scheme)));
            }
        }
        //public void Exchange()
        //{
        //    var authorization = client.ProcessUserAuthorization();
        //    if (authorization != null)
        //    {
        //        if (authorization.AccessTokenExpirationUtc.HasValue)
        //            client.RefreshAuthorization(authorization, TimeSpan.FromSeconds(30));
        //        string token = authorization.AccessToken;
        //        string result = String.Empty;
        //        using (HttpClient httpClient = new HttpClient())
        //        {
        //            httpClient.DefaultRequestHeaders.Authorization = new
        //            AuthenticationHeaderValue("Bearer", token);
        //            var apiResponse = httpClient.GetAsync(
        //            "http://www.my-contacts.com/contacts/api/contacts").Result;
        //            if (apiResponse.IsSuccessStatusCode)
        //            {
        //                result = apiResponse.Content.ReadAsStringAsync().Result;
        //                var contacts = JsonConvert.DeserializeObject<IEnumerable<Contact>>
        //                (result);
        //                return View(contacts);
        //            }
        //        }
        //    }
        //}
        #endregion
    }
}
