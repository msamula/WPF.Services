using WPF.Services.FileDialogServices.Interfaces;

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

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog()
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
