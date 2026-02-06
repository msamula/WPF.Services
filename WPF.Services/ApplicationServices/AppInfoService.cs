using System.Reflection;

namespace WPF.Services.ApplicationServices
{
    /// <summary>
    /// Service for retrieving application assembly metadata.
    /// </summary>
    public class AppInfoService : IAppInfoService
    {
        /// <inheritdoc/>
        public string? GetProductName() => Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyProductAttribute>()?.Product;

        /// <inheritdoc/>
        public string? GetAssemblyVersion() => Assembly.GetEntryAssembly()?.GetName()?.Version?.ToString();

        /// <inheritdoc/>
        public string? GetCompanyName() => Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company;

        /// <inheritdoc/>
        public string? GetProductDescription() => Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description;

        /// <inheritdoc/>
        public string? GetProductCopyright() => Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright;
    }
}
