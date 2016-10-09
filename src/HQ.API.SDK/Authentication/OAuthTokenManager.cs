using Authentication.Wrapper;
using Config;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace Authentication
{
    /// <summary>
    /// The OAuth Token Manager handles the lifecycle of access and refresh tokens for a particular user.
    /// When created with a pre-shared access and refresh token, the token manager automatically refreshes the token when it expires.
    /// When created without a pre-shared access and refresh token, the tokens can be retrieved by first acquiring an authorization code and then exchanging it for an access token. 
    /// </summary>
    public class OAuthTokenManager
    {
        private HQAPIClientConfiguration Configuration { get; set; }
        private const string AuthorizePath = "/Account/Authorize";
        private const string TokenPath = "/Token";

        private int CustomerId { get; set; }
        private string AppId { get; set; }
        private string AppSecret { get; set; }
        private string CurrentAccessToken { get; set; }
        private string CurrentRefreshToken { get; set; }
        private DateTime? ExpiresOn { get; set; }

        /// <summary>
        /// Creates a new token manager without pre-shared access token and refresh token.
        /// </summary>
        /// <param name="configuration">The client configuration containing the base URL, among others</param>
        /// <param name="appId">The app id of this client, in the form of {customer_id}-{client_id}</param>
        /// <param name="appSecret">The app secret of this client</param>
        public OAuthTokenManager(HQAPIClientConfiguration configuration, string appId, string appSecret)
        {
            if (!appId.Contains("-"))
                throw new ArgumentException("AppId needs to be in the format customerId-clientId");

            Configuration = configuration;
            AppId = appId;
            CustomerId = int.Parse(AppId.Split('-')[0]);
            AppSecret = appSecret;
        }

        /// <summary>
        /// Creates a new token manager without pre-shared access token and refresh token.
        /// </summary>
        /// <param name="configuration">The client configuration containing the base URL, among others</param>
        /// <param name="appId">The app id of this client, in the form of {customer_id}-{client_id}</param>
        /// <param name="appSecret">The app secret of this client</param>
        /// <param name="accessToken">The pre-shared access token (typically of the Sync User) or an already existing access token from a previous session</param>
        /// <param name="refreshToken">The pre-shared refresh token (typically of the Sync User) or an already existing refresh token from a previous session</param>
        /// <param name="expiresOn">The expiration date of the access token</param>
        public OAuthTokenManager(HQAPIClientConfiguration configuration, string appId, string appSecret, string accessToken, string refreshToken, DateTime expiresOn)
            : this(configuration, appId, appSecret)
        {
            CurrentAccessToken = accessToken;
            CurrentRefreshToken = refreshToken;
            ExpiresOn = expiresOn;
        }

        #region Events

        /// <summary>
        /// Fired when a new access token and refresh token were retrieved.
        /// </summary>
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

        #region AccessToken

        /// <summary>
        /// Assembles the authorization URL for the specified parameters. 
        /// Direct a user agent to this URL, wait for the user to sign in and extract the authorization code from the redirected URL.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="state"></param>
        /// <param name="redirectUri"></param>
        /// <param name="scopes"></param>
        /// <returns></returns>
        public static string GetAuthorizeUrl(string appId, string state, string redirectUri, string[] scopes)
        {
            var escapedUri = Uri.EscapeDataString(redirectUri);
            var scopeString = string.Join(" ", scopes);
            return string.Format("{0}?response_type=code&client_id={1}&state={2}&redirect_uri={3}&scope={4}", AuthorizePath, appId, state, escapedUri, scopeString);
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

        #endregion

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
        /// Actually performs the request to the Token endpoint.
        /// </summary>
        /// <param name="appId">The app id of this client</param>
        /// <param name="appSecret">The app secret of this client</param>
        /// <param name="grantType">The OAuth grant type</param>
        /// <param name="tokenType">The OAuth token type</param>
        /// <param name="code">The authorization code or refresh token</param>
        /// <returns></returns>
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
