/*
order: 30
title: Translation
slug: translation

Translate text between languages using Murf AI.
*/

namespace Murf.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TranslateText()
    {
        using var client = GetAuthenticatedClient();

        //// Translate text to a target language using the Murf translation API.
        var response = await client.SubpackageText.TranslateAsync(
            targetLanguage: "es-ES",
            texts: ["Hello, how are you?"]);

        //// The response contains the translated text.
        response.Translations.Should().NotBeNullOrEmpty();
        response.Translations![0].TranslatedText.Should().NotBeNullOrEmpty();
    }
}
