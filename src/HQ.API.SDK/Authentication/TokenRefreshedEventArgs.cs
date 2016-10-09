using Authentication.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class TokenRefreshedEventArgs : EventArgs
    {
        public AccessTokenWrapper TokenResponse { get; private set; }
        public TokenRefreshedEventArgs(AccessTokenWrapper refreshTokenWrapper)
        {
            TokenResponse = refreshTokenWrapper;
        }
    }
}
