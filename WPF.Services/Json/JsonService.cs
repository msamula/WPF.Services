using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace WPF.Services.Json
{
    public class JsonService : IJsonService
    {
        /// <inheritdoc/>
        public async Task<IEnumerable<T>?> ReadJsonAsync<T>(
            string path,
            JsonSerializerOptions? options = null,
            CancellationToken cancellationToken = default) where T : class
        {
            if (!Path.Exists(path))
            {
                throw new FileNotFoundException($"The file at {path} was not found.");
            }

            using FileStream openStream = File.OpenRead(path);
            return await JsonSerializer.DeserializeAsync<IEnumerable<T>>(openStream, options, cancellationToken);
        }


        /// <inheritdoc/>
        public async IAsyncEnumerable<T> StreamJsonAsync<T>(
            string path,
            JsonSerializerOptions? options = null,
            [EnumeratorCancellation] CancellationToken cancellationToken = default) where T : class
        {
            if (!Path.Exists(path))
            {
                throw new FileNotFoundException($"The file at {path} was not found.");
            }

            using FileStream openStream = File.OpenRead(path);
            var items = JsonSerializer.DeserializeAsyncEnumerable<T>(openStream, options, cancellationToken);

            await foreach (var item in items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
    }
}
