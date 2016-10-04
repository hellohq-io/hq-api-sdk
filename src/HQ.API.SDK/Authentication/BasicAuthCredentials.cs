using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    /// <summary>
    /// An implementation of IAPICredentials for HTTP Basic Authentication
    /// </summary>
    public class BasicAuthCredentials : IAPICredentials
    {
        private string _userName { get; set; }
        private string _password { get; set; }

        /// <summary>
        /// Creates a new HTTP Basic Authentication object
        /// </summary>
        /// <param name="userName">The username</param>
        /// <param name="password">The user's password</param>
        public BasicAuthCredentials(string userName, string password)
        {
            _userName = userName;
            _password = password;
        }

        /// <summary>
        /// Returns the HTTP Basic Authenentication code
        /// </summary>
        /// <returns></returns>
        public string GetAuthorizationCode()
        {
            string code = string.Format("{0}:{1}", _userName, _password);
            string encoded = Base64Encode(code);
            return string.Format("Basic {0}", encoded);
        }

        /// <summary>
        /// Encodes the provided plaintext string with Base64 encoding.
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
