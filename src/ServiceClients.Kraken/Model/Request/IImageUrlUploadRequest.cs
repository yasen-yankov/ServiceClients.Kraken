using System;

namespace ServiceClients.Kraken.Model.Request
{
    /// <summary>
    /// Interface IImageUrlUploadRequest
    /// </summary>
    public interface IImageUrlUploadRequest
    {
        /// <summary>
        /// Gets or sets the URL where Kraken will download the image from.
        /// </summary>
        /// <value>The image URL.</value>
        Uri ImageUrl { get; set; }
    }
}