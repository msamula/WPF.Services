namespace WPF.Services.FileDialogServices
{
    /// <summary>
    /// Represents a set of options for configuring a file dialog.
    /// </summary>
    public class FileDialogOptions
    {
        /// <summary>
        /// Gets or sets the dialog title.
        /// </summary>
        public string Title { get; set; } = "Select file to open ...";

        /// <summary>
        /// Gets or sets the default file name.
        /// </summary>
        public string Filename { get; set; } = "Document";

        /// <summary>
        /// Gets or sets the default file extension.
        /// </summary>
        public string DefaultExt { get; set; } = ".txt";

        /// <summary>
        /// Gets or sets the file type filter.
        /// </summary>
        public string Filter { get; set; } = "Text documents (.txt)|*.txt";
    }
}
