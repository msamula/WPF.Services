using System.Security.Cryptography;
using System.Text;

namespace WPF.Services.EncryptionServices
{
    /// <summary>
    /// Windows-specific implementation of <see cref="IEncryptionService"/> that uses the
    /// Data Protection API (DPAPI) to encrypt and decrypt strings. The encryption key is
    /// managed transparently by Windows and is bound to either the current user account
    /// or the local machine, depending on the configured <see cref="DataProtectionScope"/>.
    /// </summary>
    public class DpapiEncryptionService : IEncryptionService
    {
        private readonly DataProtectionScope _scope;

        public DpapiEncryptionService(DataProtectionScope scope = DataProtectionScope.CurrentUser)
        {
            _scope = scope;
        }

        /// <inheritdoc/>
        public string Encrypt(string plainText)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(plainText);

            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encrypted = ProtectedData.Protect(data, null, _scope);
            return Convert.ToBase64String(encrypted);
        }

        /// <inheritdoc/>
        public string Decrypt(string cipherText)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(cipherText);

            byte[] encrypted = Convert.FromBase64String(cipherText);
            byte[] decrypted = ProtectedData.Unprotect(encrypted, null, _scope);
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
