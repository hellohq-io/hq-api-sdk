using Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class HQAPIClientConfiguration
    {
        public string BaseUrl { get; private set; }
        public IAPICredentials Credentials { get; set; }
        public OAuthTokenManager OAuthTokenManager { get; set; }

        public HQAPIClientConfiguration() : this("https://oauth.hqlabs.de")
        {
        }
        public HQAPIClientConfiguration(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
        public HQAPIClientConfiguration(string baseUrl, OAuthTokenManager oauthTokenManager)
            : this(baseUrl)
        {
            OAuthTokenManager = oauthTokenManager;
        }

        public void SetOAuthTokenManager(OAuthTokenManager oauthTokenManager)
        {
            OAuthTokenManager = oauthTokenManager;
        }

        public OAuthTokenManager CreateOAuthTokenManager(string appId, string clientSecret)
        {
            OAuthTokenManager = new Authentication.OAuthTokenManager(this, appId, clientSecret);
            return OAuthTokenManager;
        }

        public OAuthTokenManager CreateOAuthTokenManager(string appId, string clientSecret, string accessToken, string refreshToken, DateTime expiresOn)
        {
            OAuthTokenManager = new Authentication.OAuthTokenManager(this, appId, clientSecret, accessToken, refreshToken, expiresOn);
            return OAuthTokenManager;
        }

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
