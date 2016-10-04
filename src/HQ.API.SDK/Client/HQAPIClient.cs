using Config;
using System.Net.Http;

namespace HQ.API.SDK
{
    /// <summary>
    /// The HQ API Client provides access to the resources of the HQ API.
    /// </summary>
    public partial class HQAPIClient
    {
        private HQAPIClientConfiguration _configuration { get; set; }

        /// <summary>
        /// Creates a new client with the provided client configuration.
        /// </summary>
        /// <param name="configuration"></param>
        public HQAPIClient(HQAPIClientConfiguration configuration) : this(configuration.BaseUrl)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Updates the configuration of this client, used by all future requests. The base url cannot be updated this way.
        /// </summary>
        /// <param name="configuration"></param>
        public void SetConfiguration(HQAPIClientConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Prepares the request and adds authentication details
        /// </summary>
        /// <param name="request"></param>
        /// <param name="url"></param>
        partial void PrepareRequest(HttpClient request, ref string url)
        {
            if (_configuration != null && _configuration.GetCurrentCredentials() != null)
                request.DefaultRequestHeaders.Add("Authorization", _configuration.GetCurrentCredentials().GetAuthorizationCode());
        }

        /// <summary>
        /// Processes the response before it is being parsed
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        partial void ProcessResponse(HttpClient request, HttpResponseMessage response)
        {

        }
    }
}
