using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class BearerTokenCredentials : IAPICredentials
    {
        private string _bearerToken { get; set; }
        public BearerTokenCredentials(string bearerToken)
        {
            _bearerToken = bearerToken;
        }

        public string GetAuthorizationCode()
        {
            return string.Format("Bearer {0}", _bearerToken);
        }
    }
}
