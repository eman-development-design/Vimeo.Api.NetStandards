using System;

namespace Vimeo.Api.NetStandards.Client
{
    public class BaseClient
    {
        protected const string BaseUrl = "https://api.vimeo.com";

        protected string ClientId { get; set; }

        protected string ClientSecret { get; set; }

        protected string AccessToken { get; set; }

        protected void ThrowIfUnauthorized()
        {
            if (string.IsNullOrWhiteSpace(AccessToken))
            {
                throw new InvalidOperationException("Please authenticate via OAuth to obtain an access token.");
            }
        }
    }
}