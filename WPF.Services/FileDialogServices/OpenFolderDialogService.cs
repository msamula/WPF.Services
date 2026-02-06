using Microsoft.Win32;
using WPF.Services.FileDialogServices.Interfaces;

namespace WPF.Services.FileDialogServices
{
    /// <summary>
    /// Service for handling folder open dialogs in WPF applications.
    /// </summary>
    public class OpenFolderDialogService : IOpenFolderDialogService
    {
        /// <inheritdoc/>
        public string? OpenFolder(string? title = null, string? initialDirectory = null)
        {
            var openFolderDialog = new OpenFolderDialog()
            {
                Title = title,
                InitialDirectory = initialDirectory
            };

            return openFolderDialog.ShowDialog() == true ? openFolderDialog.FolderName : null;
        }

        /// <inheritdoc/>
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
