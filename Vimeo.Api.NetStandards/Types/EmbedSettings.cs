using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Embed Settings
    /// </summary>
    public class EmbedSettings
    {
        /// <summary>
        /// Buttons
        /// </summary>
        [JsonProperty("buttons")]
        public EmbedButton Buttons { get; set; }

        /// <summary>
        /// Logos
        /// </summary>
        [JsonProperty("logos")]
        public EmbedLogo Logos { get; set; }

        /// <summary>
        /// Outro
        /// </summary>
        [JsonProperty("outro")]
        public string Outro { get; set; }

        /// <summary>
        /// Auto Pause
        /// </summary>
        [JsonProperty("autopause")]
        public bool AutoPause { get; set; }

        /// <summary>
        /// Auto Play
        /// </summary>
        [JsonProperty("autoplay")]
        public bool AutoPlay { get; set; }

        /// <summary>
        /// Background
        /// </summary>
        [JsonProperty("background")]
        public bool Background { get; set; }

        /// <summary>
        /// Cards
        /// </summary>
        [JsonProperty("cards")]
        public List<string> Cards { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// Loop
        /// </summary>
        [JsonProperty("loop")]
        public bool Loop { get; set; }

        /// <summary>
        /// Muted
        /// </summary>
        [JsonProperty("muted")]
        public bool Muted { get; set; }

        /// <summary>
        /// Outro Secondary Link Name
        /// </summary>
        [JsonProperty("outro_secondary_link_name")]
        public string OutroSecondaryLinkName { get; set; }

        /// <summary>
        /// Outro Secondary Link URL
        /// </summary>
        [JsonProperty("outro_secondary_link_url")]
        public string OutroSecondaryLinkUrl { get; set; }

        /// <summary>
        /// Outro Text Title
        /// </summary>
        [JsonProperty("outro_text_title")]
        public string OutroTextTitle { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty("link")]
        public bool Link { get; set; }

        /// <summary>
        /// Overlay Email Capture
        /// </summary>
        [JsonProperty("overlay_email_capture")]
        public int OverlayEmailCapture { get; set; }

        /// <summary>
        /// Overlay Email Capture Confirmation
        /// </summary>
        [JsonProperty("overlay_email_capture_confirmation")]
        public string OverlayEmailCaptureConfirmation { get; set; }

        /// <summary>
        /// Overlay Email Capture Text
        /// </summary>
        [JsonProperty("overlay_email_capture_text")]
        public string OverlayEmailCaptureText { get; set; }

        /// <summary>
        /// Plays Inline
        /// </summary>
        [JsonProperty("playsinline")]
        public bool PlaysInline { get; set; }

        /// <summary>
        /// Responsive
        /// </summary>
        [JsonProperty("responsive")]
        public bool Responsive { get; set; }

        /// <summary>
        /// Show 360 Label
        /// </summary>
        [JsonProperty("show_360_label")]
        public bool Show360Label { get; set; }

        /// <summary>
        /// Badge
        /// </summary>
        [JsonProperty("badge")]
        public bool Badge { get; set; }

        /// <summary>
        /// Byline
        /// </summary>
        [JsonProperty("byline")]
        public string Byline { get; set; }

        /// <summary>
        /// Byline Badge
        /// </summary>
        [JsonProperty("byline_badge")]
        public bool BylineBadge { get; set; }

        /// <summary>
        /// Collections Button
        /// </summary>
        [JsonProperty("collections_button")]
        public bool CollectionsButton { get; set; }

        /// <summary>
        /// Show Compass
        /// </summary>
        [JsonProperty("show_compass")]
        public bool ShowCompass { get; set; }

        /// <summary>
        /// Fullscreen Button
        /// </summary>
        [JsonProperty("fullscreen_button")]
        public bool FullscreenButton { get; set; }

        /// <summary>
        /// Playbar
        /// </summary>
        [JsonProperty("playbar")]
        public bool Playbar { get; set; }

        /// <summary>
        /// Portrait
        /// </summary>
        [JsonProperty("portrait")]
        public string Portrait { get; set; }

        /// <summary>
        /// Scaling Button
        /// </summary>
        [JsonProperty("scaling_button")]
        public bool ScalingButton { get; set; }

        /// <summary>
        /// Speed
        /// </summary>
        [JsonProperty("speed")]
        public bool Speed { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Volume
        /// </summary>
        [JsonProperty("volume")]
        public bool Volume { get; set; }

        /// <summary>
        /// Transparent
        /// </summary>
        [JsonProperty("transparent")]
        public bool Transparent { get; set; }

        /// <summary>
        /// Allow Title Override
        /// </summary>
        [JsonProperty("allow_title_override")]
        public bool AllowTitleOverride { get; set; }

        /// <summary>
        /// Outro Background Id
        /// </summary>
        [JsonProperty("outro_background_id")]
        public long OutroBackgroundId { get; set; }

        /// <summary>
        /// Outro Version
        /// </summary>
        [JsonProperty("outro_version")]
        public int OutroVersion { get; set; }

        /// <summary>
        /// Email Capture TimeCode
        /// </summary>
        [JsonProperty("email_capture_timecode")]
        public string EmailCaptureTimeCode { get; set; }

        /// <summary>
        /// Email Capture during playback
        /// </summary>
        [JsonProperty("email_capture_during_playback")]
        public bool EmailCaptureDuringPlayback { get; set; }

        /// <summary>
        /// Color Original
        /// </summary>
        [JsonProperty("color_original")]
        public bool ColorOriginal { get; set; }

        /// <summary>
        /// Stream Clips
        /// </summary>
        [JsonProperty("stream_clips")]
        public List<StreamClip> StreamClips { get; set; }
    }
}