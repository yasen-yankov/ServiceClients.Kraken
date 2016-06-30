using Newtonsoft.Json;
using System;

namespace ServiceClients.Kraken.Model.Request
{
    /// <summary>
    /// Configure upload request with URL where the image will be downloaded from.
    /// </summary>
    /// <seealso cref="ServiceClients.Kraken.Model.Request.UploadRequestBase" />
    /// <seealso cref="ServiceClients.Kraken.Model.Request.IImageUrlUploadRequest" />
    public class ImageUrlUploadRequest : UploadRequestBase, IImageUrlUploadRequest
    {
        /// <summary>
        /// Gets or sets the URL where Kraken will download the image from.
        /// </summary>
        /// <value>The image URL.</value>
        [JsonProperty("url")]
        public Uri ImageUrl { get; set; }
    }
}