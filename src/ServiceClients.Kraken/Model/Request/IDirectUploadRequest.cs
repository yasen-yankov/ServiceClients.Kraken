namespace ServiceClients.Kraken.Model.Request
{
    /// <summary>
    /// Interface IDirectUploadRequest
    /// </summary>
    public interface IDirectUploadRequest
    {
        /// <summary>
        /// Gets or sets the image content.
        /// </summary>
        /// <value>The content.</value>
        byte[] Content { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        string FileName { get; set; }
    }
}