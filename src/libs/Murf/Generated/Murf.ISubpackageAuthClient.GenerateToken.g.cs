#nullable enable

namespace Murf
{
    public partial interface ISubpackageAuthClient
    {
        /// <summary>
        /// Generate auth token<br/>
        /// Generates an auth token for authenticating your requests
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Murf.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Murf.AuthTokenResponse> GenerateTokenAsync(
            global::Murf.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}