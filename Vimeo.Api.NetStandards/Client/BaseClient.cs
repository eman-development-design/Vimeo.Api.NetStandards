using System.Net.Http;
using System.Net.Http.Headers;

namespace Vimeo.Api.NetStandards.Client
{
    /// <summary>
    /// Base Client
    /// </summary>
    public class BaseClient
    {
        /// <summary>
        /// Base API Url
        /// </summary>
        protected const string BaseUrl = "https://api.vimeo.com";

        protected HttpClient Client;

        private readonly string _authorization;

        /// <summary>
        /// Base Client constructor
        /// </summary>
        /// <param name="accessToken">Access Token provided by Vimeo</param>
        public BaseClient(string accessToken)
        {
            _authorization = $"bearer {accessToken}";

            InitClient();
        }

        /// <summary>
        /// Initialise our client
        /// </summary>
        private void InitClient()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.vimeo.*+json;version=3.4"));
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", _authorization);
        }
    }
}