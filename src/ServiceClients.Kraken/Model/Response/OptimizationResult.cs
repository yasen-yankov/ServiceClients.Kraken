using Newtonsoft.Json;

namespace ServiceClients.Kraken.Model.Response
{
    /// <summary>
    /// Class OptimizationResult.
    /// </summary>
    public class OptimizationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationResult"/> class.
        /// </summary>
        internal OptimizationResult()
        {
        }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the size of the original image.
        /// </summary>
        /// <value>The size of the original image.</value>
        [JsonProperty("original_size")]
        public int OriginalSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the kraked image.
        /// </summary>
        /// <value>The size of the kraked image.</value>
        [JsonProperty("kraked_size")]
        public int KrakedSize { get; set; }

        /// <summary>
        /// Gets or sets the saved bytes.
        /// </summary>
        /// <value>The saved bytes.</value>
        [JsonProperty("saved_bytes")]
        public int SavedBytes { get; set; }

        /// <summary>
        /// Gets or sets the kraked image URL.
        /// </summary>
        /// <value>The kraked image URL.</value>
        [JsonProperty("kraked_url")]
        public string KrakedUrl { get; set; }

        /// <summary>
        /// Gets or sets the width of the original image.
        /// </summary>
        /// <value>The width of the original image.</value>
        [JsonProperty("original_width")]
        public int OriginalWidth { get; set; }

        /// <summary>
        /// Gets or sets the height of the original image.
        /// </summary>
        /// <value>The height of the original image.</value>
        [JsonProperty("original_height")]
        public int OriginalHeight { get; set; }

        /// <summary>
        /// Gets or sets the width of the kraked image.
        /// </summary>
        /// <value>The width of the kraked image.</value>
        [JsonProperty("kraked_width")]
        public int KrakedWidth { get; set; }

        /// <summary>
        /// Gets or sets the height of the kraked image.
        /// </summary>
        /// <value>The height of the kraked image.</value>
        [JsonProperty("kraked_height")]
        public int KrakedHeight { get; set; }
    }
}