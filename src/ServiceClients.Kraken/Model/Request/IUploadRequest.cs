namespace ServiceClients.Kraken.Model.Request
{
    /// <summary>
    /// Interface IUploadRequest
    /// </summary>
    public interface IUploadRequest
    {
        /// <summary>
        /// Gets the authentication settings.
        /// </summary>
        /// <value>The authentication.</value>
        Auth Auth { get; }
    }
}