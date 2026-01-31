using WPF.Services.FileDialogServices.Interfaces;

namespace WPF.Services.FileDialogServices
{
    /// <summary>
    /// Service for handling file open dialogs in WPF applications.
    /// </summary>
    public class OpenFileDialogService : IOpenFileDialogService
    {
        /// <summary>
        /// Opens a file dialog for single file selection.
        /// </summary>
        /// <param name="fileDialogOptions">The dialog options; if null, default options are used.</param>
        /// <returns>The selected file path, or null if cancelled.</returns>
        public string? OpenFile(FileDialogOptions? fileDialogOptions)
        {
            fileDialogOptions ??= new FileDialogOptions();

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog()
            {
                Title = fileDialogOptions.Title,
                FileName = fileDialogOptions.Filename,
                DefaultExt = fileDialogOptions.DefaultExt,
                Filter = fileDialogOptions.Filter,
                Multiselect = false,
                ValidateNames = true,
                CheckFileExists = true,
                CheckPathExists = true
            };

            return dlg.ShowDialog() == true ? dlg.FileName : null;
        }

        /// <summary>
        /// Opens a file dialog for multiple file selection.
        /// </summary>
        /// <param name="fileDialogOptions">The dialog options; if null, default options are used.</param>
        /// <returns>An array of selected file paths, or an empty array if cancelled.</returns>
        public string[] OpenFiles(FileDialogOptions? fileDialogOptions)
        {
            fileDialogOptions ??= new FileDialogOptions();

            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                Title = fileDialogOptions.Title,
                FileName = fileDialogOptions.Filename,
                DefaultExt = fileDialogOptions.DefaultExt,
                Filter = fileDialogOptions.Filter,
                Multiselect = true,
                ValidateNames = true,
                CheckFileExists = true,
                CheckPathExists = true
            };

            return dlg.ShowDialog() == true ? dlg.FileNames : [];
        }
    }
}
