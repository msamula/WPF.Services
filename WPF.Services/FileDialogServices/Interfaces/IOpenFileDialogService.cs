namespace WPF.Services.FileDialogServices.Interfaces
{
    /// <summary>
    /// Service interface for opening file dialogs.
    /// </summary>
    public interface IOpenFileDialogService
    {
        /// <summary>
        /// Opens a file dialog for single file selection.
        /// </summary>
        /// <param name="fileDialogOptions">The dialog options; if null, default options are used.</param>
        /// <returns>The selected file path, or null if cancelled.</returns>
        string? OpenFile(FileDialogOptions? fileDialogOptions = null);

        /// <summary>
        /// Opens a file dialog for multiple file selection.
        /// </summary>
        /// <param name="fileDialogOptions">The dialog options; if null, default options are used.</param>
        /// <returns>An array of selected file paths, or an empty array if cancelled.</returns>
        string[] OpenFiles(FileDialogOptions? fileDialogOptions = null);
    }
}