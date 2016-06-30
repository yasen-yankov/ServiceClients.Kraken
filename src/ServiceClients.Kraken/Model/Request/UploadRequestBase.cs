using Newtonsoft.Json;
using System.Collections.Generic;

namespace ServiceClients.Kraken.Model.Request
{
    /// <summary>
    /// Class UploadRequestBase.
    /// </summary>
    /// <seealso cref="ServiceClients.Kraken.Model.Request.IUploadRequest" />
    public abstract class UploadRequestBase : IUploadRequest
    {
        /// <summary>
        /// Gets or sets whether lossy algorithm should be used.
        /// </summary>
        /// <value><c>true</c> if lossy; otherwise, <c>false</c>.</value>
        [JsonProperty("lossy")]
        public bool Lossy { get; set; }

        /// <summary>
        /// Gets or sets whether automatic image orientation should be used.
        /// </summary>
        /// <value><c>true</c> if [automatic orient]; otherwise, <c>false</c>.</value>
        [JsonProperty("auto_orient")]
        public bool AutoOrient { get; set; }

        /// <summary>
        /// Gets or sets the chroma sub-sampling scheme.
        /// 4:2:0 —	Kraken.io's default for lossy JPEG compression. Suitable for most images - this sampling scheme will yield the smallest possible file size.
        /// 4:2:2 —	The two colour(chroma) components are sampled at half the sample rate of brightness(luma), thereby halving the horizontal chroma resolution.
        /// 4:4:4 —	Each of the three colour components have the same sample rate as the luma channel, thus there is no chroma subsampling taking place.Use this scheme to disable chroma subsampling for the highest quality result, at the expense of a slightly larger file size.
        /// </summary>
        /// <value>The sampling scheme.</value>
        [JsonProperty("sampling_scheme")]
        public string SamplingScheme { get; set; }

        /// <summary>
        /// Gets or sets convert settings for converting different images from one type/format to another.
        /// </summary>
        /// <value>The convert.</value>
        [JsonProperty("convert")]
        public Convert Convert { get; set; }

        /// <summary>
        /// Gets or sets whether to re-compress JPEG, PNG or GIF files into WebP format.
        /// </summary>
        /// <value><c>true</c> if [web p]; otherwise, <c>false</c>.</value>
        [JsonProperty("webp")]
        public bool WebP { get; set; }

        /// <summary>
        /// Gets or sets the list of resize settings.
        /// </summary>
        /// <value>The resizes.</value>
        [JsonProperty("resize")]
        public IList<Resize> Resizes { get; set; } = new List<Resize>();

        /// <summary>
        /// Gets or sets the azure data store settings.
        /// </summary>
        /// <value>The azure data store.</value>
        [JsonProperty("azure_store")]
        public AzureDataStore AzureDataStore { get; set; }

        /// <summary>
        /// Gets or sets the S3 data store settings.
        /// </summary>
        /// <value>The s3 data store.</value>
        [JsonProperty("s3_store")]
        public S3DataStore S3DataStore { get; set; }

        /// <summary>
        /// Gets the authentication settings.
        /// </summary>
        /// <value>The authentication.</value>
        [JsonProperty("auth")]
        public Auth Auth { get; internal set; } = new Auth();

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="UploadRequestBase"/> is wait.
        /// </summary>
        /// <value><c>true</c> if wait; otherwise, <c>false</c>.</value>
        [JsonProperty("wait")]
        internal bool Wait { get; set; } = true;

        /// <summary>
        /// Should serialize the list of resize settings.
        /// </summary>
        /// <returns><c>true</c> if resize settings count is more than zero, <c>false</c> otherwise.</returns>
        public bool ShouldSerializeResizes()
        {
            return this.Resizes.Count > 0;
        }
    }
}