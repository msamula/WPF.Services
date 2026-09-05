using Microsoft.Win32;
using WPF.Services.FileDialogServices.Interfaces;
using WPF.Services.FileDialogServices.Models;

namespace WPF.Services.FileDialogServices
{
    /// <summary>
    /// Service for handling file save dialogs in WPF applications.
    /// </summary>
    public class SaveFileDialogService : ISaveFileDialogService
    {

        /// <inheritdoc/>
        public string? SaveFile(FileDialogOptions? fileDialogOptions = null)
        {
            fileDialogOptions ??= new FileDialogOptions();

            SaveFileDialog dlg = new SaveFileDialog()
            {
                Title = fileDialogOptions.Title,
                FileName = fileDialogOptions.Filename,
                Filter = fileDialogOptions.Filter,
                ValidateNames = true,
                CheckPathExists = true,
                OverwritePrompt = true,
                AddExtension = true
            };

            return dlg.ShowDialog() == true ? dlg.FileName : null;
        }
    }
}
