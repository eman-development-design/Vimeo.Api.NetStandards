using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Vimeo.Api.NetStandards.Constants;

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
        private const string BaseUrl = "https://api.vimeo.com";

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
        /// Build endpoint URL
        /// </summary>
        /// <param name="endpoint">endpoint uri</param>
        /// <returns></returns>
        protected static string BuildUrl(string endpoint)
        {
            return $"{BaseUrl}/{endpoint}";
        }

        /// <summary>
        /// Builds our GET API URL
        /// </summary>
        /// <param name="endpoint">endpoint uri</param>
        /// <param name="fields">List of fields we want to return</param>
        /// <param name="page">current page number</param>
        /// <param name="perPage">Item per page</param>
        /// <param name="sort">sort by column</param>
        /// <param name="sortDirection">sort direction</param>
        /// <param name="filter">Filter by a subset of data</param>
        /// <param name="contentRatingFilter">Filter by Video's Content Rating</param>
        /// <returns>Complete API URL string</returns>
        protected static string BuildGetUrl(string endpoint, string[] fields = null, int? page = null, int? perPage = null,
                                            string sort = null, SortDirection? sortDirection = null, string filter = null,
                                            string[] contentRatingFilter = null)
        {
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            if (fields != null)
            {
                queryString["fields"] = string.Join(",", fields);
            }

            if (page != null)
            {
                queryString["page"] = page.Value.ToString();

            }

            if (perPage != null)
            {
                queryString["per_page"] = perPage.ToString();
            }

            if (!string.IsNullOrEmpty(sort))
            {
                queryString["sort"] = sort;
            }

            if (sortDirection != null)
            {
                queryString["direction"] = sortDirection.Value.ToString();
            }

            if (filter != null)
            {
                queryString["filter"] = filter;
            }

            if (contentRatingFilter != null)
            {
                queryString["filter_content_rating"] = string.Join(",", contentRatingFilter);
            }


            return queryString.Count == 0 ?
                $"{BaseUrl}/{endpoint}" :
                $"{BaseUrl}/{endpoint}?{queryString}";
        }

        /// <summary>
        /// Initialise our client
        /// </summary>
        private void InitClient()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.vimeo.*+json;version=3.4"));
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", _authorization);
        }
    }
}