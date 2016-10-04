using Authentication.Wrapper;
using Config;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class OAuthTokenManager
    {
        private HQAPIClientConfiguration Configuration { get; set; }
        private const string AccessPath = "/Account/Authorize";
        private const string TokenPath = "/Token";

        private int CustomerId { get; set; }
        private string AppId { get; set; }
        private string AppSecret { get; set; }
        private string CurrentAccessToken { get; set; }
        private string CurrentRefreshToken { get; set; }
        private DateTime? ExpiresOn { get; set; }

        public OAuthTokenManager(HQAPIClientConfiguration configuration, string appId, string appSecret)
        {
            if (!appId.Contains("-"))
                throw new ArgumentException("AppId needs to be in the format customerId-clientId");

            Configuration = configuration;
            AppId = appId;
            CustomerId = int.Parse(AppId.Split('-')[0]);
            AppSecret = appSecret;
        }
        
        public OAuthTokenManager(HQAPIClientConfiguration configuration, string appId, string appSecret, string accessToken, string refreshToken, DateTime expiresOn)
            : this(configuration, appId, appSecret)
        {
            CurrentAccessToken = accessToken;
            CurrentRefreshToken = refreshToken;
            ExpiresOn = expiresOn;
        }

        #region Events

        public event EventHandler<TokenRefreshedEventArgs> TokenRefreshed;
        protected void OnTokenRefreshed(TokenRefreshedEventArgs e)
        {
            TokenRefreshed(this, e);
        }

        #endregion

        /// <summary>
        /// Returns the current bearer token credentials. If the access token has expired, it tries to use the refresh token to retrieve a new access token. 
        /// This only works if a previously acquired refresh token has been provided.
        /// </summary>
        /// <returns></returns>
        public BearerTokenCredentials GetCurrentCredentials()
        {
            // If current credentials are about to expire or not set, get a new access token using the refresh token
            var threshold = DateTime.UtcNow.AddMinutes(0);
            int val = ExpiresOn.Value.CompareTo(threshold);
            if (string.IsNullOrWhiteSpace(CurrentAccessToken) || !ExpiresOn.HasValue || val < 0)
            {
                if (!string.IsNullOrWhiteSpace(CurrentRefreshToken))
                {
                    var tokenResponse = RefreshAccessToken(AppId, AppSecret, CurrentAccessToken);
                    if (tokenResponse == null)
                    {
                    }
                }
                else
                {
                    throw new ArgumentException("RefreshToken not set");
                }
            }

            return new Authentication.BearerTokenCredentials(CurrentAccessToken);
        }

        #region REST

        /// <summary>
        /// Returns the username and password in a Base64-endoded form for HTTP Basic Authentication.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string GetBasicAuthToken(string userName, string password)
        {
            string ticket = string.Format("{0}:{1}", userName, password);
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(ticket);
            var token = System.Convert.ToBase64String(plainTextBytes);
            return token;
        }

        /// <summary>
        /// Tries to refresh the access token with token manager's current refresh token.
        /// If a new access token was retrieved, the access token and new refresh token are stored in the token manager an will be used for subsequent requests.
        /// </summary>
        /// <returns></returns>
        public AccessTokenWrapper RefreshAccessToken()
        {
            return RefreshAccessToken(AppId, AppSecret, CurrentRefreshToken);
        }

        /// <summary>
        /// Tries to refresh the access token with the provided refresh token.
        /// If a new access token was retrieved, the access token and new refresh token are stored in the token manager an will be used for subsequent requests.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        public AccessTokenWrapper RefreshAccessToken(string appId, string appSecret, string refreshToken)
        {
            var accessTokenWrapper = GetAccessToken(appId, appSecret, "refresh_token", "refresh_token", refreshToken);

            if (accessTokenWrapper != null)
            {
                this.CurrentAccessToken = accessTokenWrapper.AccessToken;
                this.CurrentRefreshToken = accessTokenWrapper.RefreshToken;
                this.ExpiresOn = DateTime.UtcNow.Add(accessTokenWrapper.GetExpirationTimeSpan());

                OnTokenRefreshed(new TokenRefreshedEventArgs(accessTokenWrapper));
            }

            return accessTokenWrapper;
        }

        /// <summary>
        /// Tries to get an access token with the provided authorization code.
        /// If an access token was retrieved, the access token and refresh token are stored in the token manager an will be used for subsequent requests.
        /// </summary>
        /// <param name="authorizationCode"></param>
        /// <returns></returns>
        public AccessTokenWrapper GetAccessToken(string authorizationCode)
        {
            return GetAccessToken(AppId, AppSecret, authorizationCode);
        }

        /// <summary>
        /// Tries to get an access token with the provided authorization code.
        /// If an access token was retrieved, the access token and refresh token are stored in the token manager an will be used for subsequent requests.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <param name="authorizationCode"></param>
        /// <returns></returns>
        public AccessTokenWrapper GetAccessToken(string appId, string appSecret, string authorizationCode)
        {
            var accessTokenWrapper = GetAccessToken(appId, appSecret, "authorization_code", "code", authorizationCode);

            if (accessTokenWrapper != null)
            {
                this.CurrentAccessToken = accessTokenWrapper.AccessToken;
                this.CurrentRefreshToken = accessTokenWrapper.RefreshToken;
                this.ExpiresOn = DateTime.UtcNow.Add(accessTokenWrapper.GetExpirationTimeSpan());

                OnTokenRefreshed(new TokenRefreshedEventArgs(accessTokenWrapper));
            }

            return accessTokenWrapper;
        }

        private AccessTokenWrapper GetAccessToken(string appId, string appSecret, string grantType, string tokenType, string code)
        {
            var client = new RestClient(Configuration.BaseUrl);

            var request = new RestRequest(TokenPath, Method.POST);

            string body = string.Format("grant_type={0}&{1}={2}", grantType, tokenType, code);

            request.AddHeader("Authorization", "Basic " + GetBasicAuthToken(appId, appSecret));
            request.AddParameter("application/x-www-form-urlencoded", body, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            try
            {
                AccessTokenWrapper tokenResponse = null;
                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // OK
                    tokenResponse = JsonConvert.DeserializeObject<AccessTokenWrapper>(response.Content);
                }
                else
                {
                    // NOK
                    throw new InvalidOperationException("Token endpoint returned an invalid response");
                }

                return tokenResponse;
            }
            catch (Exception error)
            {
                // Log
                throw new InvalidOperationException("Token endpoint resulted in an error: " + error.Message);
            }
        }

        #endregion

    }
}
