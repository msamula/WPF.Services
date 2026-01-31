using Microsoft.Win32;
using WPF.Services.FileDialogServices.Interfaces;

namespace WPF.Services.FileDialogServices
{
    /// <summary>
    /// Service for handling folder open dialogs in WPF applications.
    /// </summary>
    public class OpenFolderDialogService : IOpenFolderDialogService
    {
        /// <summary>
        /// Opens a folder selection dialog.
        /// </summary>
        /// <param name="title">Dialog title</param>
        /// <param name="initialDirectory">Initial directory</param>
        /// <returns>Selected folder path, or null if cancelled</returns>
        public string? OpenFolder(string? title = null, string? initialDirectory = null)
        {
            var openFolderDialog = new OpenFolderDialog()
            {
                Title = title,
                InitialDirectory = initialDirectory
            };

            return openFolderDialog.ShowDialog() == true ? openFolderDialog.FolderName : null;
        }

        /// <summary>
        /// Opens a folder selection dialog.
        /// </summary>
        /// <param name="specialFolder">Initial directory</param>
        /// <param name="title">Dialog title</param>
        /// <returns>Selected folder path, or null if cancelled</returns>
        public string? OpenFolder(Environment.SpecialFolder specialFolder, string? title = null)
        {
            var openFolderDialog = new OpenFolderDialog()
            {
                Title = title,
                InitialDirectory = Environment.GetFolderPath(specialFolder)
            };

            return openFolderDialog.ShowDialog() == true ? openFolderDialog.FolderName : null;
        }
    }
}
