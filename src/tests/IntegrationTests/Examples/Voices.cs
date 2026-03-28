/*
order: 20
title: Voices
slug: voices

List available Murf AI voices for speech synthesis.
*/

namespace Murf.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListVoices()
    {
        using var client = GetAuthenticatedClient();

        //// List available voices for text-to-speech synthesis.
        var voices = await client.SubpackageTextToSpeech.GetVoicesAsync(
            model: "GEN2");

        //// The response contains a list of available voices with metadata.
        voices.Should().NotBeEmpty();
        voices[0].VoiceId.Should().NotBeNullOrEmpty();
        voices[0].DisplayName.Should().NotBeNullOrEmpty();
    }
}
