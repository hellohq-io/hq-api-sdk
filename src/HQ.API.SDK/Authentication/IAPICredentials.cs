using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public interface IAPICredentials
    {
        string GetAuthorizationCode();
    }
}
