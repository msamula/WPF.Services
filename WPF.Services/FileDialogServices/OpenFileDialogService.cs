using WPF.Services.FileDialogServices.Interfaces;

namespace WPF.Services.FileDialogServices
{
    /// <summary>
    /// Service for handling file open dialogs in WPF applications.
    /// </summary>
    public class OpenFileDialogService : IOpenFileDialogService
    {
        /// <inheritdoc/>
        public string? OpenFile(FileDialogOptions? fileDialogOptions = null)
        {
            fileDialogOptions ??= new FileDialogOptions();

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog()
            {
                Title = fileDialogOptions.Title,
                FileName = fileDialogOptions.Filename,
                Filter = fileDialogOptions.Filter,
                Multiselect = false,
                ValidateNames = true,
                CheckFileExists = true,
                CheckPathExists = true
            };

            return dlg.ShowDialog() == true ? dlg.FileName : null;
        }

        /// <inheritdoc/>
        public string[] OpenFiles(FileDialogOptions? fileDialogOptions = null)
        {
            fileDialogOptions ??= new FileDialogOptions();

            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                Title = fileDialogOptions.Title,
                FileName = fileDialogOptions.Filename,
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
