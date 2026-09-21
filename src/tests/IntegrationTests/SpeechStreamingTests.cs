using System.Net;

namespace Murf.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechStream_ReturnsAudioBytes_WithoutProviderAccess()
    {
        using var transport = new HttpClient(new AudioHandler(request =>
        {
            Assert.AreEqual("/v1/speech/stream", request.RequestUri?.AbsolutePath);
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent([0x52, 0x49, 0x46, 0x46])
            };
        }));
        using var client = new MurfClient("test-key", transport);
        await using var audio = await client.SubpackageTextToSpeech.StreamAsStreamAsync(
            new GenerateSpeechStreamingRequest { Text = "hello", VoiceId = "en-US-natalie" });
        using var output = new MemoryStream();
        await audio.CopyToAsync(output);

        CollectionAssert.AreEqual(new byte[] { 0x52, 0x49, 0x46, 0x46 }, output.ToArray());
    }

    private sealed class AudioHandler(Func<HttpRequestMessage, HttpResponseMessage> respond) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            => Task.FromResult(respond(request));
    }
}
