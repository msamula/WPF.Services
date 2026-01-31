using Microsoft.Win32;
using WPF.Services.FileDialogServices.Interfaces;

namespace WPF.Services.FileDialogServices
{
    public class OpenFolderDialogService : IOpenFolderDialogService
    {
        /// <summary>
        /// Opens a folder selection dialog.
        /// </summary>
        /// <param name="title">Dialog title</param>
        /// <param name="specialFolder">Initial directory</param>
        /// <returns>Selected folder path, or null if cancelled</returns>
        public string? OpenFolder(string title = "Select folder to open ...", Environment.SpecialFolder specialFolder = Environment.SpecialFolder.Desktop)
        {
            var openFolderDialog = new OpenFolderDialog()
            {
                Title = title,
                InitialDirectory = Environment.GetFolderPath(specialFolder)
            };

            bool? result = openFolderDialog.ShowDialog();

            if (result.HasValue && result.Value)
            {
                return openFolderDialog.FolderName;
            }

            return null;
        }
    }
}
