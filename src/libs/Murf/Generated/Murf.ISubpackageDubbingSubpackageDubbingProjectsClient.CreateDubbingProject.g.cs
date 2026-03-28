#nullable enable

namespace Murf
{
    public partial interface ISubpackageDubbingSubpackageDubbingProjectsClient
    {
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Murf.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Murf.ApiProjectResponse> CreateDubbingProjectAsync(

            global::Murf.ApiCreateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="name">
        /// Your Project Name
        /// </param>
        /// <param name="sourceLocale">
        /// Source Locale
        /// </param>
        /// <param name="dubbingType"></param>
        /// <param name="description"></param>
        /// <param name="targetLocales">
        /// List of target locales
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Murf.ApiProjectResponse> CreateDubbingProjectAsync(
            string name,
            global::Murf.ApiCreateProjectRequestDubbingType dubbingType,
            global::System.Collections.Generic.IList<string> targetLocales,
            string? sourceLocale = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}