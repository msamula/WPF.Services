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
        /// <returns>The product name, or null if not available.</returns>
        string? GetProductName();

        /// <summary>
        /// Gets the version from the assembly.
        /// </summary>
        /// <returns>The assembly version, or null if not available.</returns>
        string? GetAssemblyVersion();

        /// <summary>
        /// Gets the company name from the assembly.
        /// </summary>
        /// <returns>The company name or the authors, or null if not available.</returns>
        string? GetCompanyName();

        /// <summary>
        /// Gets the product description from the assembly.
        /// </summary>
        /// <returns>The product description, or null if the description is not available.</returns>
        string? GetProductDescription();

        /// <summary>
        /// Gets the copyright information from the assembly.
        /// </summary>
        /// <returns>The copyright string, or null if it is not available.</returns>
        string? GetProductCopyright();
    }
}