namespace ServiceClients.Kraken.Model
{
    /// <summary>
    /// Enum Strategy
    /// </summary>
    public enum Strategy
    {
        /// <summary>
        /// Resize to exact width and height. Aspect ratio will not be maintained.
        /// </summary>
        exact,

        /// <summary>
        /// Exact height will be set, width will be adjusted according to aspect ratio.
        /// </summary>
        portrait,

        /// <summary>
        /// Exact width will be set, height will be adjusted according to aspect ratio.
        /// </summary>
        landscape,

        /// <summary>
        /// The best strategy (portrait or landscape) will be selected for a given image according to its aspect ratio.
        /// </summary>
        auto,

        /// <summary>
        /// This option will crop and resize your images to fit the desired width and height.
        /// </summary>
        fit,

        /// <summary>
        /// This option will crop your images, from the center, to the exact size you specify with no distortion.
        /// </summary>
        crop,

        /// <summary>
        /// This strategy will first crop the image by its shorter dimension to make it a square, then resize it to the specified size.
        /// </summary>
        square,

        /// <summary>
        /// This strategy allows you to resize the image to fit the specified bounds while preserving the aspect ratio (just like auto strategy).
        /// </summary>
        fill
    }
}