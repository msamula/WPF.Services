namespace WPF.Services.FileDialogServices.Interfaces
{
    /// <summary>
    /// Service interface for opening folder selection dialogs.
    /// </summary>
    public interface IOpenFolderDialogService
    {
        /// <summary>
        /// Opens a folder selection dialog.
        /// </summary>
        /// <param name="title">Dialog title</param>
        /// <param name="initialDirectory">Initial directory</param>
        /// <returns>Selected folder path, or null if cancelled</returns>
        string? OpenFolder(string? title = null, string? initialDirectory = null);

        /// <summary>
        /// Opens a folder selection dialog.
        /// </summary>
        /// <param name="specialFolder">Initial directory</param>
        /// <param name="title">Dialog title</param>
        /// <returns>Selected folder path, or null if cancelled</returns>
        string? OpenFolder(Environment.SpecialFolder specialFolder, string? title = null);
    }
}   