using System.Text.Json;

namespace WPF.Services.JsonServices
{
    public interface IJsonService
    {
        /// <summary>
        /// Asynchronously reads an entire JSON file and deserializes it into a collection.
        /// Use this for smaller files where memory consumption is not a primary concern.
        /// </summary>
        /// <typeparam name="T">The type of objects in the collection.</typeparam>
        /// <param name="path">The full path to the JSON file.</param>
        /// <param name="options">Options to control serializer behavior.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>A collection of <typeparamref name="T"/>, or null if deserialization fails.</returns>
        /// <exception cref="FileNotFoundException">Thrown when the file path does not exist.</exception>
        Task<IEnumerable<T>?> ReadJsonAsync<T>(string path, JsonSerializerOptions? options = null, CancellationToken cancellationToken = default) where T : class;

        /// <summary>
        /// Streams a JSON array from a file one element at a time.
        /// Use this for large datasets to maintain a low memory footprint.
        /// </summary>
        /// <typeparam name="T">The type of objects to stream.</typeparam>
        /// <param name="path">The full path to the JSON file.</param>
        /// <param name="options">Options to control serializer behavior.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>An asynchronous stream of <typeparamref name="T"/>.</returns>
        /// <exception cref="FileNotFoundException">Thrown when the file path does not exist.</exception>
        IAsyncEnumerable<T> StreamJsonAsync<T>(string path, JsonSerializerOptions? options = null, CancellationToken cancellationToken = default) where T : class;

        /// <summary>
        /// Asynchronously serializes a collection of <typeparamref name="T"/> to JSON and writes it to a file.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the collection.</typeparam>
        /// <param name="directorypath">The directory in which the file will be created.</param>
        /// <param name="filename">The file name without extension; the JSON extension is appended automatically.</param>
        /// <param name="value">The collection to serialize.</param>
        /// <param name="options">Optional serializer options. If <see langword="null"/>, default options are used.</param>
        /// <param name="cancellationToken">A token to cancel the write operation.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        Task WriteJsonAsync<T>(string directorypath, string filename, IEnumerable<T> value, JsonSerializerOptions? options = null, CancellationToken cancellationToken = default);
    }
}