using System;
using System.Collections.Generic;

namespace ServiceClients.Kraken.Model.Response
{
    /// <summary>
    /// Interface IOptimizationResultResponse.
    /// </summary>
    /// <seealso cref="ServiceClients.Kraken.Model.Response.IUploadResponse" />
    interface IOptimizationResultResponse : IUploadResponse
    {
        /// <summary>
        /// Gets or sets the optimization result. Used when there are no resize settings in the request.
        /// </summary>
        /// <value>The result.</value>
        OptimizationResult Result { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of id and optimization result. Used when there is one or more resize settings in the request.
        /// </summary>
        /// <value>The results.</value>
        IDictionary<Guid, OptimizationResult> Results { get; set; }
    }
}