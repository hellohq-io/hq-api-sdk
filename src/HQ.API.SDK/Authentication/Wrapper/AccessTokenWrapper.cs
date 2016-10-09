using Newtonsoft.Json;
using System;

namespace Authentication.Wrapper
{
    /// <summary>
    /// A wrapper for the access and refresh token
    /// </summary>
    public class AccessTokenWrapper
    {
        /// <summary>
        /// The access token used to access the API resources
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// The type of the access token, usually Bearer
        /// </summary>
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// The expiration timespan of this access token
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// The refresh token, which is used to get a new access token after it expired
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// The id of the user this token is valid for
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// The username of the user this token is valid for
        /// </summary>
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// Returns a TimeSpan object from the ExpiresIn string.
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetExpirationTimeSpan()
        {
            int sec = int.Parse(ExpiresIn);
            return new TimeSpan(0, 0, sec);
        }
    }
}
