#nullable enable

namespace Murf
{
    public partial interface ISubpackageDubbingSubpackageDubbingJobsClient
    {
        /// <summary>
        /// Get Status
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Murf.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Murf.DubJobStatusResponse> GetStatusAsync(
            string jobId,
            global::Murf.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}