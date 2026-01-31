namespace WPF.Services.FileDialogServices.Interfaces
{
    /// <summary>
    /// Service interface for opening folder selection dialog.
    /// </summary>
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