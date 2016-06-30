using ServiceClients.Kraken.Model.Request;
using ServiceClients.Kraken.Model.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceClients.Kraken
{
    /// <summary>
    /// Interface IKrakenClient
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IKrakenClient : IDisposable
    {
        /// <summary>
        /// Direct image upload.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;UploadResponse&gt;.</returns>
        Task<UploadResponse> DirectUpload(DirectUploadRequest request);

        /// <summary>
        /// Direct image upload.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;UploadResponse&gt;.</returns>
        Task<UploadResponse> DirectUpload(DirectUploadRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Direct image upload with call back URL response.
        /// With the Callback URL the HTTPS connection will be terminated immediately and a unique id will be returned 
        /// in the response body. After the optimization is over Kraken will POST a message to the callback_url specified
        /// in the request in a JSON format application/json. The ID in the response will reflect the ID in the results
        /// posted to your Callback URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;UploadCallbackUrlResponse&gt;.</returns>
        Task<UploadCallbackUrlResponse> DirectUpload(DirectUploadCallbackUrlRequest request);

        /// <summary>
        /// Direct image upload with call back URL response.
        /// With the Callback URL the HTTPS connection will be terminated immediately and a unique id will be returned 
        /// in the response body. After the optimization is over Kraken will POST a message to the callback_url specified
        /// in the request in a JSON format application/json. The ID in the response will reflect the ID in the results
        /// posted to your Callback URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;UploadCallbackUrlResponse&gt;.</returns>
        Task<UploadCallbackUrlResponse> DirectUpload(DirectUploadCallbackUrlRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Upload with image URL. Kraken will download the image from the provided URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;UploadResponse&gt;.</returns>
        Task<UploadResponse> ImageUrlUpload(ImageUrlUploadRequest request);

        /// <summary>
        /// Upload with image URL. Kraken will download the image from the provided URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;UploadResponse&gt;.</returns>
        Task<UploadResponse> ImageUrlUpload(ImageUrlUploadRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Upload with image URL. Kraken will download the image from the provided URL.
        /// With the Callback URL the HTTPS connection will be terminated immediately and a unique id will be returned 
        /// in the response body. After the optimization is over Kraken will POST a message to the callback_url specified
        /// in the request in a JSON format application/json. The ID in the response will reflect the ID in the results
        /// posted to your Callback URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;UploadCallbackUrlResponse&gt;.</returns>
        Task<UploadCallbackUrlResponse> ImageUrlUpload(ImageUrlUploadCallbackUrlRequest request);

        /// <summary>
        /// Upload with image URL. Kraken will download the image from the provided URL.
        /// With the Callback URL the HTTPS connection will be terminated immediately and a unique id will be returned 
        /// in the response body. After the optimization is over Kraken will POST a message to the callback_url specified
        /// in the request in a JSON format application/json. The ID in the response will reflect the ID in the results
        /// posted to your Callback URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;UploadCallbackUrlResponse&gt;.</returns>
        Task<UploadCallbackUrlResponse> ImageUrlUpload(ImageUrlUploadCallbackUrlRequest request, CancellationToken cancellationToken);
    }
}