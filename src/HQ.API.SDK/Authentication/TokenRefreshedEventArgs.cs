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
        public TokenRefreshedEventArgs(AccessTokenWrapper refreshTokenWrapper)
        {

        }
    }
}
