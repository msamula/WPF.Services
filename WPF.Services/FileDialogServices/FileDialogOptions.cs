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
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the default file name.
        /// </summary>
        public string Filename { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the file type filter.
        /// Example: "Text documents (.txt)|*.txt"
        /// Example: "Text documents (.txt)|*.txt|DICOM Image (.dcm)|*.dcm"
        /// </summary>
        public string Filter { get; set; } = string.Empty;
    }
}
