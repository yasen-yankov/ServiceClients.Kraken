using System.Net;

namespace ServiceClients.Kraken.Model.Response
{
    /// <summary>
    /// Class UploadResponseBase.
    /// </summary>
    /// <seealso cref="ServiceClients.Kraken.Model.Response.IUploadResponse" />
    public abstract class UploadResponseBase : IUploadResponse
    {
        /// <summary>
        /// Gets or sets the upload response error message. Will be empty if the request was processed successfully.
        /// </summary>
        /// <value>The error message.</value>
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets whether the request was processed successfully.
        /// </summary>
        /// <value><c>true</c> if request was processed successfully; otherwise, <c>false</c>.</value>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the response HTTP status code.
        /// </summary>
        /// <value>The HTTP status code.</value>
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}