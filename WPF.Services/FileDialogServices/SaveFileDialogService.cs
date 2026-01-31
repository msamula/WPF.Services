using WPF.Services.FileDialogServices.Interfaces;

namespace WPF.Services.FileDialogServices
{
    /// <summary>
    /// Service for handling file save dialogs in WPF applications.
    /// </summary>
    public class SaveFileDialogService : ISaveFileDialogService
    {
        /// <summary>
        /// Opens a save file dialog.
        /// </summary>
        /// <param name="fileDialogOptions">The dialog options; if null, default options are used.</param>
        /// <returns>The selected file path, or null if cancelled.</returns>
        public string? SaveFile(FileDialogOptions? fileDialogOptions = null)
        {
            fileDialogOptions ??= new FileDialogOptions() { Title = "Save file as ..." };

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog()
            {
                Title = fileDialogOptions.Title,
                FileName = fileDialogOptions.Filename,
                DefaultExt = fileDialogOptions.DefaultExt,
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
