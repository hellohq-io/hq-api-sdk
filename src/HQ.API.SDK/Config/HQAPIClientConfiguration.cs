using Authentication;
using System;

namespace Config
{
    /// <summary>
    /// A configuration class containing, among others, the base URL of the API.
    /// </summary>
    public class HQAPIClientConfiguration
    {
        public string BaseUrl { get; private set; }
        public IAPICredentials Credentials { get; set; }
        public OAuthTokenManager OAuthTokenManager { get; private set; }

        /// <summary>
        /// Creates a new client configuration with the default API URL
        /// </summary>
        public HQAPIClientConfiguration() : this("https://api.hqlabs.de")
        {
        }

        /// <summary>
        /// Creates a new client configuration with the specified API URL
        /// </summary>
        /// <param name="baseUrl">The base URL of the API</param>
        public HQAPIClientConfiguration(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        /// <summary>
        /// Creates a new client configuration with the specified API URL
        /// </summary>
        /// <param name="baseUrl">The base URL of the API</param>
        /// <param name="oauthTokenManager">The OAuth Token Manager</param>
        public HQAPIClientConfiguration(string baseUrl, OAuthTokenManager oauthTokenManager)
            : this(baseUrl)
        {
            OAuthTokenManager = oauthTokenManager;
        }

        /// <summary>
        /// Sets the OAuth Token Manager of this client configuration
        /// </summary>
        /// <param name="oauthTokenManager"></param>
        public void SetOAuthTokenManager(OAuthTokenManager oauthTokenManager)
        {
            OAuthTokenManager = oauthTokenManager;
        }

        /// <summary>
        /// Creates a new token manager in the current client configuration without a pre-shared or a token from a previous session.
        /// </summary>
        /// <param name="appId">The app id of this client, in the form of {customer_id}-{client_id}</param>
        /// <param name="appSecret">The app secret of this client</param>
        /// <returns></returns>
        public OAuthTokenManager CreateOAuthTokenManager(string appId, string appSecret)
        {
            OAuthTokenManager = new Authentication.OAuthTokenManager(this, appId, appSecret);
            return OAuthTokenManager;
        }

        /// <summary>
        /// Creates a new token manager in the current client configuration with a pre-shared token or a token from a previous session.
        /// </summary>
        /// <param name="appId">The app id of this client, in the form of {customer_id}-{client_id}</param>
        /// <param name="appSecret">The app secret of this client</param>
        /// <param name="accessToken">The pre-shared access token (typically of the Sync User) or an already existing access token from a previous session</param>
        /// <returns></returns>
        public OAuthTokenManager CreateOAuthTokenManager(string appId, string appSecret, string accessToken)
        {
            OAuthTokenManager = new Authentication.OAuthTokenManager(this, appId, appSecret, accessToken);
            return OAuthTokenManager;
        }

        /// <summary>
        /// Creates a new token manager in the current client configuration with a pre-shared token or a token from a previous session.
        /// </summary>
        /// <param name="appId">The app id of this client, in the form of {customer_id}-{client_id}</param>
        /// <param name="appSecret">The app secret of this client</param>
        /// <param name="accessToken">The pre-shared access token (typically of the Sync User) or an already existing access token from a previous session</param>
        /// <param name="refreshToken">The pre-shared refresh token (typically of the Sync User) or an already existing refresh token from a previous session</param>
        /// <param name="expiresOn">The expiration date of the access token</param>
        /// <returns></returns>
        public OAuthTokenManager CreateOAuthTokenManager(string appId, string appSecret, string accessToken, string refreshToken, DateTime expiresOn)
        {
            OAuthTokenManager = new Authentication.OAuthTokenManager(this, appId, appSecret, accessToken, refreshToken, expiresOn);
            return OAuthTokenManager;
        }

        /// <summary>
        /// Returns the current valid credentials of this client configuration.
        /// </summary>
        /// <returns></returns>
        public IAPICredentials GetCurrentCredentials()
        {
            if (Credentials != null)
                return Credentials;

            if (OAuthTokenManager != null)
                return OAuthTokenManager.GetCurrentCredentials();

            return null;
        }
    }
}
