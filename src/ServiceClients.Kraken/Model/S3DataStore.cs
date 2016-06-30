using Newtonsoft.Json;
using System.Collections.Generic;

namespace ServiceClients.Kraken.Model
{
    /// <summary>
    /// Holds S3DataStore parameters.
    /// </summary>
    public class S3DataStore
    {
        /// <summary>
        /// Gets or sets Amazon "Access Key ID".
        /// </summary>
        /// <value>The key.</value>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets Amazon "Secret Access Key".
        /// </summary>
        /// <value>The secret.</value>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or sets the name of a destination bucket on the Amazon S3 account.
        /// </summary>
        /// <value>The bucket.</value>
        [JsonProperty("bucket")]
        public string Bucket { get; set; }

        /// <summary>
        /// Gets or sets the name of the region the S3 bucket is located in.
        /// This field is mandatory if the region is different from the default one (us-east-1).
        /// </summary>
        /// <value>The region.</value>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the destination path in the S3 bucket (e.g. "images/layout/header.jpg").
        /// Defaults to root "/".
        /// </summary>
        /// <value>The path.</value>
        [JsonProperty("path")]
        public string Path { get; set; } = "/";

        /// <summary>
        /// Gets or sets the permissions of a destination object. This can be "public_read" or "private". Defaults to "public_read".
        /// </summary>
        /// <value>The acl.</value>
        [JsonProperty("acl")]
        public string Acl { get; set; } = "public_read";

        /// <summary>
        /// Gets or sets custom headers to pass along with the S3 object (optimized image).
        /// </summary>
        /// <value>The headers.</value>
        [JsonProperty("headers")]
        public KeyValuePair<string, string> Headers { get; set; } = new KeyValuePair<string, string>();
    }
}