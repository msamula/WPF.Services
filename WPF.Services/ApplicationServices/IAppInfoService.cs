using System.Reflection;

namespace WPF.Services.ApplicationServices
{
    /// <summary>
    /// Provides access to application assembly metadata information.
    /// </summary>
    public interface IAppInfoService
    {
        /// <summary>
        /// Gets the product name from the assembly.
        /// </summary>
        /// <param name="executingAssembly">The assembly to extract information from.</param>
        /// <returns>The product name, or null if not available.</returns>
        string? GetProductName(Assembly executingAssembly);

        /// <summary>
        /// Gets the version from the assembly.
        /// </summary>
        /// <param name="executingAssembly">The assembly to extract information from.</param>
        /// <returns>The assembly version, or null if not available.</returns>
        string? GetAssemblyVersion(Assembly executingAssembly);

        /// <summary>
        /// Gets the company name from the assembly.
        /// </summary>
        /// <param name="executingAssembly">The assembly to extract information from.</param>
        /// <returns>The company name or the authors, or null if not available.</returns>
        string? GetCompanyName(Assembly executingAssembly);
    }
}