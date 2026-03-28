/*
order: 10
title: Text to Speech
slug: text-to-speech

Generate natural-sounding speech audio from text using Murf AI.
*/

namespace Murf.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateSpeech()
    {
        using var client = GetAuthenticatedClient();

        //// Generate speech from text using the Murf TTS API.
        var response = await client.SubpackageTextToSpeech.GenerateAsync(
            text: "Hello, welcome to Murf AI text to speech.",
            voiceId: "en-US-natalie",
            format: "MP3");

        //// The response contains a URL to the generated audio file and metadata.
        response.AudioFile.Should().NotBeNullOrEmpty();
        response.AudioLengthInSeconds.Should().BeGreaterThan(0);
    }
}
