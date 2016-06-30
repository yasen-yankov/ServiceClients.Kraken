using Newtonsoft.Json;

namespace ServiceClients.Kraken.Model
{
    /// <summary>
    /// Holds Azure Data Store parameters.
    /// </summary>
    public class AzureDataStore
    {
        /// <summary>
        /// Gets or sets an Azure Storage Account.
        /// </summary>
        /// <value>The account.</value>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets a unique Azure Storage Access Key.
        /// </summary>
        /// <value>The key.</value>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the name of a destination container on your Azure account.
        /// </summary>
        /// <value>The container.</value>
        [JsonProperty("container")]
        public string Container { get; set; }

        /// <summary>
        /// Gets or sets a destination path in the container (e.g. "images/layout/header.jpg"). Defaults to root "/".
        /// </summary>
        /// <value>The path.</value>
        [JsonProperty("path")]
        public string Path { get; set; } = "/";
    }
}