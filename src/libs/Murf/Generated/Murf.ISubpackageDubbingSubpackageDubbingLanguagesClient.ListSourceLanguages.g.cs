#nullable enable

namespace Murf
{
    public partial interface ISubpackageDubbingSubpackageDubbingLanguagesClient
    {
        /// <summary>
        /// List Source Languages
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Murf.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Murf.SourceLocaleResponse>> ListSourceLanguagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}