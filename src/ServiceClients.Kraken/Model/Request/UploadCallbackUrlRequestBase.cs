using Newtonsoft.Json;
using System;

namespace ServiceClients.Kraken.Model.Request
{
    /// <summary>
    /// Class UploadCallbackUrlRequestBase.
    /// </summary>
    /// <seealso cref="ServiceClients.Kraken.Model.Request.UploadRequestBase" />
    public abstract class UploadCallbackUrlRequestBase : UploadRequestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCallbackUrlRequestBase"/> class.
        /// </summary>
        public UploadCallbackUrlRequestBase()
        {
            this.Wait = false;
        }

        /// <summary>
        /// Gets or sets the callback URL.
        /// </summary>
        /// <value>The callback URL.</value>
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; set; }
    }
}