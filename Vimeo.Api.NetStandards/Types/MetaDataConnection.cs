using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Metadata Connection Type
    /// </summary>
    public class MetaDataConnection
    {
        /// <summary>
        /// Activities
        /// </summary>
        [JsonProperty("activities", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Activities { get; set; }

        /// <summary>
        /// Albums
        /// </summary>
        [JsonProperty("albums", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Albums { get; set; }

        /// <summary>
        /// Appearances
        /// </summary>
        [JsonProperty("appearances", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Appearances { get; set; }

        /// <summary>
        /// Block
        /// </summary>
        [JsonProperty("block", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Block { get; set; }

        /// <summary>
        /// Categories
        /// </summary>
        [JsonProperty("categories", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Categories { get; set; }

        /// <summary>
        /// Channels
        /// </summary>
        [JsonProperty("channels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Channels { get; set; }

        /// <summary>
        /// Comments
        /// </summary>
        [JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Comments { get; set; }

        /// <summary>
        /// Credits
        /// </summary>
        [JsonProperty("credits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Credits { get; set; }

        /// <summary>
        /// Feed
        /// </summary>
        [JsonProperty("feed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Feed { get; set; }

        /// <summary>
        /// Folders
        /// </summary>
        [JsonProperty("folders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Folders { get; set; }

        /// <summary>
        /// Followers
        /// </summary>
        [JsonProperty("followers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Followers { get; set; }

        /// <summary>
        /// Following
        /// </summary>
        [JsonProperty("following", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Following { get; set; }

        /// <summary>
        /// Groups
        /// </summary>
        [JsonProperty("groups", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Groups { get; set; }

        /// <summary>
        /// Likes
        /// </summary>
        [JsonProperty("likes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Likes { get; set; }

        /// <summary>
        /// Moderated Channels
        /// </summary>
        [JsonProperty("moderated_channels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection ModeratedChannels { get; set; }

        /// <summary>
        /// Pictures
        /// </summary>
        [JsonProperty("pictures", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Pictures { get; set; }

        /// <summary>
        /// Portfolios
        /// </summary>
        [JsonProperty("portfolios", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Portfolios { get; set; }

        /// <summary>
        /// Shared
        /// </summary>
        [JsonProperty("shared", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Shared { get; set; }

        /// <summary>
        /// Text Tracks
        /// </summary>
        [JsonProperty("texttracks", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection TextTracks { get; set; }

        // todo: related

        /// <summary>
        /// Recommendations
        /// </summary>
        [JsonProperty("recommendations", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Recommendations { get; set; }

        /// <summary>
        /// Users
        /// </summary>
        [JsonProperty("users", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Users { get; set; }

        /// <summary>
        /// Videos
        /// </summary>
        [JsonProperty("videos", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection Videos { get; set; }

        /// <summary>
        /// Watch Later
        /// </summary>
        [JsonProperty("watchlater", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Connection WatchLater { get; set; }

        /// <summary>
        /// Watched Videos
        /// </summary>
        [JsonProperty("watched_videos")]
        public Connection WatchedVideos { get; set; }
    }
}