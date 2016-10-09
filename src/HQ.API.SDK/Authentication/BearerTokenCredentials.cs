using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    /// <summary>
    /// An implementation of IAPICredentials for HTTP Bearer Authentication
    /// </summary>
    public class BearerTokenCredentials : IAPICredentials
    {
        private string _bearerToken { get; set; }

        /// <summary>
        /// Creates a new HTTP Bearer Authentication object
        /// </summary>
        /// <param name="bearerToken">The Bearer token</param>
        public BearerTokenCredentials(string bearerToken)
        {
            _bearerToken = bearerToken;
        }

        /// <summary>
        /// Returns the HTTP Bearer Authenentication code
        /// </summary>
        /// <returns></returns>
        public string GetAuthorizationCode()
        {
            return string.Format("Bearer {0}", _bearerToken);
        }
    }
}
