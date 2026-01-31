namespace WPF.Services.FileDialogServices.Interfaces
{
    /// <summary>
    /// Service interface for opening folder selection dialogs.
    /// </summary>
    /// <remarks>
    /// This service provides a user-friendly way to let users select a folder from the file system.
    /// </remarks>
    public interface IOpenFolderDialogService
    {
        /// <summary>
        /// Opens a folder selection dialog and returns the selected folder path.
        /// </summary>
        /// <param name="title">The dialog window title. Defaults to "Select folder to open ...".</param>
        /// <param name="specialFolder">
        /// The initial folder location. Defaults to <see cref="Environment.SpecialFolder.Desktop"/>.
        /// Use this to navigate users to common locations like Documents, Downloads, etc.
        /// </param>
        /// <returns>
        /// The full path of the selected folder, or null if the user cancelled the dialog.
        /// </returns>
        string? OpenFolder(string title = "Select folder to open ...", Environment.SpecialFolder specialFolder = Environment.SpecialFolder.Desktop);
    }
}   