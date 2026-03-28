#nullable enable

namespace Murf
{
    public partial interface ISubpackageDubbingSubpackageDubbingProjectsClient
    {
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Murf.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Murf.ApiProjectResponse> UpdateAsync(
            string projectId,

            global::Murf.ApiUpdateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="targetLocales">
        /// List of target locales
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Murf.ApiProjectResponse> UpdateAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> targetLocales,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}