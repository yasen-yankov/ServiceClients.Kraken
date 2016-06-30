using Newtonsoft.Json;

namespace ServiceClients.Kraken.Model.Response
{
    /// <summary>
    /// Represents an upload response for request with call back URL.
    /// </summary>
    /// <seealso cref="ServiceClients.Kraken.Model.Response.UploadResponseBase" />
    public class UploadCallbackUrlResponse : UploadResponseBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCallbackUrlResponse"/> class.
        /// </summary>
        internal UploadCallbackUrlResponse()
        {
        }

        /// <summary>
        /// Gets or sets the Id of the request made with call back URL.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}