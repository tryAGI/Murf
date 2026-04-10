#nullable enable

namespace Murf
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// List Voices<br/>
        /// Returns a list of available voices for speech synthesis
        /// </summary>
        /// <param name="model">
        /// Default Value: GEN2
        /// </param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Murf.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Murf.ApiVoice>> GetVoicesAsync(
            string? model = default,
            string? token = default,
            global::Murf.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}