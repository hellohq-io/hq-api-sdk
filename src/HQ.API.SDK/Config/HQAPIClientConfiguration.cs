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
        public HQAPIClientConfiguration(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        public string BaseUrl { get; private set; }
        public IAPICredentials Credentials { get; set; }
    }
}
