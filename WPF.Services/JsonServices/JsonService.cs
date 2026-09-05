using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace WPF.Services.JsonServices
{
    public class JsonService : IJsonService
    {
        /// <inheritdoc/>
        public async Task<IEnumerable<T>?> ReadJsonAsync<T>(
            string path,
            JsonSerializerOptions? options = null,
            CancellationToken cancellationToken = default) where T : class
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(path);

            if (!Path.Exists(path))
            {
                throw new FileNotFoundException($"The file at {path} was not found.");
            }

            await using FileStream openStream = File.OpenRead(path);
            return await JsonSerializer.DeserializeAsync<IEnumerable<T>>(openStream, options, cancellationToken);
        }


        /// <inheritdoc/>
        public async IAsyncEnumerable<T> StreamJsonAsync<T>(
            string path,
            JsonSerializerOptions? options = null,
            [EnumeratorCancellation] CancellationToken cancellationToken = default) where T : class
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(path);

            if (!Path.Exists(path))
            {
                throw new FileNotFoundException($"The file at {path} was not found.");
            }

            await using FileStream openStream = File.OpenRead(path);
            var items = JsonSerializer.DeserializeAsyncEnumerable<T>(openStream, options, cancellationToken);

            await foreach (var item in items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }

        /// <inheritdoc/>
        public async Task WriteJsonAsync<T>(
            string directorypath,
            string filename,
            IEnumerable<T> value,
            JsonSerializerOptions? options = null,
            CancellationToken cancellationToken = default)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(directorypath);
            ArgumentException.ThrowIfNullOrWhiteSpace(filename);

            Directory.CreateDirectory(directorypath);

            string filepath = Path.Combine(directorypath, filename + JsonServiceConstants.JsonExtension);
            await using FileStream filestream = File.Create(filepath);
            await JsonSerializer.SerializeAsync(filestream, value, options, cancellationToken).ConfigureAwait(false);
        }
    }
}
