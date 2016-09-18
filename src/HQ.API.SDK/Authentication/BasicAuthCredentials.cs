using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class BasicAuthCredentials : IAPICredentials
    {
        private string _userName { get; set; }
        private string _password { get; set; }

        public BasicAuthCredentials(string userName, string password)
        {
            _userName = userName;
            _password = password;
        }

        public string GetAuthorizationCode()
        {
            string code = string.Format("{0}:{1}", _userName, _password);
            string encoded = Base64Encode(code);
            return string.Format("Basic {0}", encoded);
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
