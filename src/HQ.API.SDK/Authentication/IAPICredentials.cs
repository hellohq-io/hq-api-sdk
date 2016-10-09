using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    /// <summary>
    /// Provides authorization information for concrete authorization mechanisms
    /// </summary>
    public interface IAPICredentials
    {
        /// <summary>
        /// Returns the HTTP Authorization header value for the corresponding concrete authorization mechanism
        /// </summary>
        /// <returns></returns>
        string GetAuthorizationCode();
    }
}
