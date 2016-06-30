using Newtonsoft.Json;

namespace ServiceClients.Kraken.Model
{
    /// <summary>
    /// Holds authentication parameters.
    /// </summary>
    public class Auth
    {
        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        /// <value>The API key.</value>
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the API secret.
        /// </summary>
        /// <value>The API secret.</value>
        [JsonProperty("api_secret")]
        public string ApiSecret { get; set; }
    }
}