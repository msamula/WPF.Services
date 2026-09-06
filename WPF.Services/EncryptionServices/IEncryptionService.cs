namespace WPF.Services.EncryptionServices
{
    /// <summary>
    /// Provides methods for encrypting and decrypting strings.
    /// </summary>
    public interface IEncryptionService
    {
        /// <summary>
        /// Encrypts the specified plain text.
        /// </summary>
        /// <param name="plainText">The plain text to encrypt.</param>
        /// <returns>The encrypted text, typically Base64-encoded.</returns>
        string Encrypt(string plainText);

        /// <summary>
        /// Decrypts the specified text that was previously produced by <see cref="Encrypt(string)"/>.
        /// </summary>
        /// <param name="cipherText">The encrypted text.</param>
        /// <returns>The original plain text.</returns>
        string Decrypt(string cipherText);
    }
}
