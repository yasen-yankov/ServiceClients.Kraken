using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ServiceClients.Kraken.Model
{
    /// <summary>
    /// Holds convert settings parameters.
    /// </summary>
    public class Convert
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Convert"/> class.
        /// </summary>
        public Convert()
        {
            BackgroundColor = "#ffffff";
        }

        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        /// <value>The format.</value>
        [JsonProperty("format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ImageFormat Format { get; set; }

        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>The color of the background.</value>
        [JsonProperty("background")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to keep the extension.
        /// </summary>
        /// <value><c>true</c> if [keep extension]; otherwise, <c>false</c>.</value>
        [JsonProperty("keep_extension")]
        public bool KeepExtension { get; set; }
    }
}