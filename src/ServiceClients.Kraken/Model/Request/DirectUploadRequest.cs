using Newtonsoft.Json;

namespace ServiceClients.Kraken.Model.Request
{
    /// <summary>
    /// Configure upload request with the image content.
    /// </summary>
    /// <seealso cref="ServiceClients.Kraken.Model.Request.UploadRequestBase" />
    /// <seealso cref="ServiceClients.Kraken.Model.Request.IDirectUploadRequest" />
    public class DirectUploadRequest : UploadRequestBase, IDirectUploadRequest
    {
        /// <summary>
        /// Gets or sets the image content.
        /// </summary>
        /// <value>The content.</value>
        [JsonIgnore]
        public byte[] Content { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        [JsonIgnore]
        public string FileName { get; set; }
    }
}