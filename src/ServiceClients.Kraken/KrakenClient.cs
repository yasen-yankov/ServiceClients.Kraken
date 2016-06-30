using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using ServiceClients.Kraken.Model.Request;
using ServiceClients.Kraken.Model.Response;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceClients.Kraken
{
    /// <summary>
    /// Class KrakenClient.
    /// </summary>
    /// <seealso cref="ServiceClients.Kraken.IKrakenClient" />
    public class KrakenClient : IKrakenClient
    {
        /// <summary>
        /// The default base URL of the API.
        /// </summary>
        private static readonly string DEFAULT_BASE_URL = "https://api.kraken.io";
        /// <summary>
        /// The direct upload endpoint of the API.
        /// </summary>
        private static readonly string DIRECT_UPLOAD_ENDPOINT = "{0}/v1/upload";
        /// <summary>
        /// The image URL endpoint of the API.
        /// </summary>
        private static readonly string IMAGE_URL_ENDPOINT = "{0}/v1/url";

        /// <summary>
        /// The API key.
        /// </summary>
        private readonly string apiKey;
        /// <summary>
        /// The API secret.
        /// </summary>
        private readonly string apiSecret;
        /// <summary>
        /// The direct upload URL.
        /// </summary>
        private readonly string directUploadUrl;

        /// <summary>
        /// The image URL.
        /// </summary>
        private readonly string imageUrl;

        /// <summary>
        /// The HTTP client.
        /// </summary>
        private readonly HttpClient httpClient;

        /// <summary>
        /// The json media type formatter.
        /// </summary>
        private readonly JsonSerializerSettings jsonSerializerSettings;

        /// <summary>
        /// The disposed value.
        /// </summary>
        private bool disposedValue = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="KrakenClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="apiSecret">The API secret.</param>
        public KrakenClient(string apiKey, string apiSecret)
            : this(apiKey, apiSecret, KrakenClient.DEFAULT_BASE_URL)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KrakenClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="apiSecret">The API secret.</param>
        /// <param name="baseUrl">The base URL.</param>
        public KrakenClient(string apiKey, string apiSecret, string baseUrl)
        {
            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
            this.directUploadUrl = string.Format(KrakenClient.DIRECT_UPLOAD_ENDPOINT, baseUrl);
            this.imageUrl = string.Format(KrakenClient.IMAGE_URL_ENDPOINT, baseUrl);

            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            this.jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new StringEnumConverter
                        {
                            CamelCaseText = true
                        }
                    },
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        /// <summary>
        /// Direct image upload.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;UploadResponse&gt;.</returns>
        public Task<UploadResponse> DirectUpload(DirectUploadRequest request)
        {
            return this.DirectUpload(request, default(CancellationToken));
        }

        /// <summary>
        /// Direct image upload.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;UploadResponse&gt;.</returns>
        public Task<UploadResponse> DirectUpload(DirectUploadRequest request, CancellationToken cancellationToken)
        {
            return this.Upload(request, this.directUploadUrl, cancellationToken);
        }

        /// <summary>
        /// Direct image upload with call back URL response.
        /// With the Callback URL the HTTPS connection will be terminated immediately and a unique id will be returned
        /// in the response body. After the optimization is over Kraken will POST a message to the callback_url specified
        /// in the request in a JSON format application/json. The ID in the response will reflect the ID in the results
        /// posted to your Callback URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;UploadCallbackUrlResponse&gt;.</returns>
        public Task<UploadCallbackUrlResponse> DirectUpload(DirectUploadCallbackUrlRequest request)
        {
            return this.DirectUpload(request, default(CancellationToken));
        }

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
        public Task<UploadCallbackUrlResponse> DirectUpload(DirectUploadCallbackUrlRequest request, CancellationToken cancellationToken)
        {
            return this.UploadCallbackUrl(request, this.directUploadUrl, cancellationToken);
        }

        /// <summary>
        /// Upload with image URL. Kraken will download the image from the provided URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;UploadResponse&gt;.</returns>
        public Task<UploadResponse> ImageUrlUpload(ImageUrlUploadRequest request)
        {
            return this.ImageUrlUpload(request, default(CancellationToken));
        }

        /// <summary>
        /// Upload with image URL. Kraken will download the image from the provided URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;UploadResponse&gt;.</returns>
        public Task<UploadResponse> ImageUrlUpload(ImageUrlUploadRequest request, CancellationToken cancellationToken)
        {
            return this.Upload(request, this.imageUrl, cancellationToken);
        }

        /// <summary>
        /// Upload with image URL. Kraken will download the image from the provided URL.
        /// With the Callback URL the HTTPS connection will be terminated immediately and a unique id will be returned
        /// in the response body. After the optimization is over Kraken will POST a message to the callback_url specified
        /// in the request in a JSON format application/json. The ID in the response will reflect the ID in the results
        /// posted to your Callback URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;UploadCallbackUrlResponse&gt;.</returns>
        public Task<UploadCallbackUrlResponse> ImageUrlUpload(ImageUrlUploadCallbackUrlRequest request)
        {
            return this.ImageUrlUpload(request, default(CancellationToken));
        }

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
        public Task<UploadCallbackUrlResponse> ImageUrlUpload(ImageUrlUploadCallbackUrlRequest request, CancellationToken cancellationToken)
        {
            return this.UploadCallbackUrl(request, this.imageUrl, cancellationToken);
        }

        /// <summary>
        /// Makes a direct upload using the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;UploadResponse&gt;.</returns>
        private Task<UploadResponse> Upload(IUploadRequest request, string url, CancellationToken cancellationToken)
        {
            Task<UploadResponse> response = this.Execute<IUploadRequest, UploadResponse>(
                request,
                url,
                HttpMethod.Post,
                default(CancellationToken));

            return response;
        }

        /// <summary>
        /// Makes an upload with image URL. Kraken will download the image from the provided URL.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;UploadCallbackUrlResponse&gt;.</returns>
        private Task<UploadCallbackUrlResponse> UploadCallbackUrl(IUploadRequest request, string url, CancellationToken cancellationToken)
        {
            Task<UploadCallbackUrlResponse> response = this.Execute<IUploadRequest, UploadCallbackUrlResponse>(
                request,
                url,
                HttpMethod.Post,
                default(CancellationToken));

            return response;
        }

        /// <summary>
        /// Executes the specified upload request.
        /// </summary>
        /// <typeparam name="TRequest">The type of the t request.</typeparam>
        /// <typeparam name="TResponse">The type of the t response.</typeparam>
        /// <param name="uploadRequest">The upload request.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="method">The method.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;TResponse&gt;.</returns>
        private async Task<TResponse> Execute<TRequest, TResponse>(TRequest uploadRequest, string uri, HttpMethod method, CancellationToken cancellationToken) 
            where TRequest : class, IUploadRequest
            where TResponse : class, IUploadResponse
        {
            uploadRequest.Auth.ApiKey = this.apiKey;
            uploadRequest.Auth.ApiSecret = this.apiSecret;

            using (var requestMessage = new HttpRequestMessage(method, uri))
            {
                string uploadRequestSerialized = JsonConvert.SerializeObject(uploadRequest, jsonSerializerSettings);
                StringContent uploadRequestContent = new StringContent(uploadRequestSerialized, Encoding.UTF8, "application/json");

                MultipartFormDataContent formContent = new MultipartFormDataContent();
                formContent.Add(uploadRequestContent);

                if (uploadRequest is IDirectUploadRequest)
                {
                    IDirectUploadRequest directUploadRequest = (IDirectUploadRequest)uploadRequest;

                    ByteArrayContent directUploadRequestContent = new ByteArrayContent(directUploadRequest.Content);
                    directUploadRequestContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                    {
                        Name = "file",
                        FileName = directUploadRequest.FileName
                    };

                    formContent.Add(directUploadRequestContent);
                }

                requestMessage.Content = formContent;

                using (HttpResponseMessage responseMessage = await this.httpClient.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false))
                {
                    return await BuildResponse<TResponse>(responseMessage, cancellationToken).ConfigureAwait(false);
                }
            }
        }

        /// <summary>
        /// Builds the response.
        /// </summary>
        /// <typeparam name="TResponse">The type of the t response.</typeparam>
        /// <param name="message">The message.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;TResponse&gt;.</returns>
        private async Task<TResponse> BuildResponse<TResponse>(HttpResponseMessage message, CancellationToken cancellationToken)
            where TResponse : IUploadResponse
        {
            string responseJson = await message.Content.ReadAsStringAsync();
            IUploadResponse response = JsonConvert.DeserializeObject<TResponse>(responseJson, jsonSerializerSettings);

            response.HttpStatusCode = message.StatusCode;

            if (response is IOptimizationResultResponse)
            {
                IOptimizationResultResponse optimizationResultResponse = (IOptimizationResultResponse)response;

                if (optimizationResultResponse.Results == null)
                {
                    OptimizationResult optimizationResult = JsonConvert.DeserializeObject<OptimizationResult>(responseJson, jsonSerializerSettings);
                    optimizationResultResponse.Result = optimizationResult;
                }
            }

            return (TResponse)response;
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this.httpClient.Dispose();
                }

                this.disposedValue = true;
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }
    }
}