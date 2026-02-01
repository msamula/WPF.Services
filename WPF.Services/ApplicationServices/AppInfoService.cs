using System.Reflection;

namespace WPF.Services.ApplicationServices
{
    /// <summary>
    /// Service for retrieving application assembly metadata.
    /// </summary>
    public class AppInfoService : IAppInfoService
    {
        /// <inheritdoc/>
        public string? GetProductName(Assembly executingAssembly) => executingAssembly.GetCustomAttribute<AssemblyProductAttribute>()?.Product;

        /// <inheritdoc/>
        public string? GetAssemblyVersion(Assembly executingAssembly) => executingAssembly.GetName().Version?.ToString();

        /// <inheritdoc/>
        public string? GetCompanyName(Assembly executingAssembly) => executingAssembly.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company;
    }
}
