using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types;
using Vimeo.Api.NetStandards.Types.MetaData;
using Vimeo.Api.NetStandards.Types.Video;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Video Entity
    /// </summary>
    [PublicAPI]
    public class Video
    {
        /// <summary>
        /// Video Uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Video Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Video Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Video Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Video Duration
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Video Width
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Video Language
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Video Height
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Video Embed Properties
        /// </summary>
        [JsonProperty("embed")]
        public Embed Embed { get; set; }

        /// <summary>
        /// Creation Time
        /// </summary>
        [JsonProperty("created_time")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Modified Time
        /// </summary>
        [JsonProperty("modified_time")]
        public DateTime ModifiedTime { get; set; }

        [JsonProperty("release_time")]
        public DateTime ReleaseTime { get; set; }

        /// <summary>
        /// Content Rating
        /// </summary>
        [JsonProperty("content_rating")]
        public List<string> ContentRating { get; set; }

        /// <summary>
        /// License
        /// </summary>
        [JsonProperty("license")]
        public string License { get; set; }

        /// <summary>
        /// Privacy
        /// </summary>
        [JsonProperty("privacy")]
        public Privacy Privacy { get; set; }

        /// <summary>
        /// Pictures
        /// </summary>
        [JsonProperty("pictures")]
        public Picture Pictures { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Stats
        /// </summary>
        [JsonProperty("stats")]
        public VideoStats Stats { get; set; }

        /// <summary>
        /// Categories
        /// </summary>
        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// MetaData
        /// </summary>
        [JsonProperty("metadata")]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// User
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <summary>
        /// Review Page
        /// </summary>
        [JsonProperty("review_page", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ReviewPage ReviewPage { get; set; }

        [JsonProperty("parent_folder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SubCategory ParentFolder { get; set; } // todo: verify the type is correct.

        /// <summary>
        /// Last user action event date
        /// </summary>
        [JsonProperty("last_user_action_event_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime LastUserActionEventDate { get; set; }

        /// <summary>
        /// Files
        /// </summary>
        [JsonProperty("files", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<File> Files { get; set; }

        /// <summary>
        /// Download List
        /// </summary>
        [JsonProperty("download", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<File> Download { get; set; }

        /// <summary>
        /// App
        /// </summary>
        [JsonProperty("app", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public App App { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Resource Key
        /// </summary>
        [JsonProperty("resource_key")]
        public string ResourceKey { get; set; }

        /// <summary>
        /// Upload
        /// </summary>
        [JsonProperty("upload")]
        public VideoUpload Upload { get; set; }

        /// <summary>
        /// Transcode
        /// </summary>
        [JsonProperty("transcode")]
        public Transcode Transcode { get; set; }

        /// <summary>
        /// Embed Presets
        /// </summary>
        [JsonProperty("embed_presets")]
        public EmbedPresets EmbedPresets { get; set; }
    }
}