using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ServiceClients.Kraken.Model.Response
{
    /// <summary>
    /// Represents an upload response.
    /// </summary>
    /// <seealso cref="ServiceClients.Kraken.Model.Response.UploadResponseBase" />
    /// <seealso cref="ServiceClients.Kraken.Model.Response.IOptimizationResultResponse" />
    public class UploadResponse : UploadResponseBase, IOptimizationResultResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponse" /> class.
        /// </summary>
        internal UploadResponse()
        {
        }

        /// <summary>
        /// Gets or sets the optimization result. Used when there are no resize settings in the request.
        /// </summary>
        /// <value>The result.</value>
        public OptimizationResult Result { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of id and optimization result. Used when there is one or more resize settings in the request.
        /// </summary>
        /// <value>The results.</value>
        [JsonProperty("results")]
        public IDictionary<Guid, OptimizationResult> Results { get; set; }
    }
}