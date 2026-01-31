namespace WPF.Services.FileDialogServices.Interfaces
{
    /// <summary>
    /// Service interface for saving files via dialog.
    /// </summary>
    public interface ISaveFileDialogService
    {
        /// <summary>
        /// Opens a save file dialog.
        /// </summary>
        /// <param name="fileDialogOptions">The dialog options; if null, default options are used.</param>
        /// <returns>The selected file path, or null if cancelled.</returns>
        string? SaveFile(FileDialogOptions? fileDialogOptions = null);
    }
}