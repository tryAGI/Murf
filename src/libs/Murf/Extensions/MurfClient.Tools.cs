using Microsoft.Extensions.AI;

namespace Murf;

/// <summary>
/// Extensions for using MurfClient as MEAI tools with any IChatClient.
/// </summary>
public static class MurfToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates speech from text using Murf AI,
    /// suitable for use as a tool with any IChatClient.
    /// Returns a URL to the generated audio file along with metadata.
    /// </summary>
    /// <param name="client">The Murf client to use for speech generation.</param>
    /// <param name="voiceId">
    /// Default voice ID to use (e.g. "en-US-natalie" or "natalie").
    /// Can be overridden by the LLM's function call.
    /// </param>
    /// <param name="format">Audio format (default: MP3). Valid values: MP3, WAV, FLAC, ALAW, ULAW, PCM, OGG.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsTextToSpeechTool(
        this MurfClient client,
        string voiceId = "en-US-natalie",
        string format = "MP3")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, string? voice, string? locale, CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageTextToSpeech.GenerateAsync(
                    text: text,
                    voiceId: voice ?? voiceId,
                    format: format,
                    locale: locale,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSpeechResponse(response);
            },
            name: "MurfTextToSpeech",
            description: "Generates natural-sounding speech audio from text using Murf AI. " +
                         "Returns a URL to the generated audio file. " +
                         "Supports 150+ voices across 35 languages with customizable pitch, speed, and style.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available Murf AI voices,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Murf client to use.</param>
    /// <param name="model">Model filter (default: GEN2). Valid values: FALCON, GEN2.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListVoicesTool(
        this MurfClient client,
        string model = "GEN2")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? gender, string? locale, CancellationToken cancellationToken) =>
            {
                var voices = await client.SubpackageTextToSpeech.GetVoicesAsync(
                    model: model,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatVoiceList(voices, gender, locale);
            },
            name: "MurfListVoices",
            description: "Lists available Murf AI voices with their IDs, names, genders, languages, and available styles. " +
                         "Optionally filter by gender (MALE/FEMALE) or locale (e.g. en-US, es-ES).");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that translates text using Murf AI,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Murf client to use for translation.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsTranslateTool(
        this MurfClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, string targetLanguage, CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageText.TranslateAsync(
                    targetLanguage: targetLanguage,
                    texts: [text],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTranslationResponse(response);
            },
            name: "MurfTranslate",
            description: "Translates text into a specified target language using Murf AI. " +
                         "Provide the text and target language code (e.g. 'es-ES', 'fr-FR', 'de-DE').");
    }

    private static string FormatSpeechResponse(GenerateSpeechResponse response)
    {
        var parts = new List<string>
        {
            $"Audio URL: {response.AudioFile}",
            $"Duration: {response.AudioLengthInSeconds:F1}s",
            $"Remaining characters: {response.RemainingCharacterCount}",
        };

        if (response.ConsumedCharacterCount is not null)
        {
            parts.Add($"Consumed characters: {response.ConsumedCharacterCount}");
        }

        if (!string.IsNullOrWhiteSpace(response.Warning))
        {
            parts.Add($"Warning: {response.Warning}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatVoiceList(
        IList<ApiVoice> voices,
        string? gender,
        string? locale)
    {
        var filtered = voices.AsEnumerable();

        if (!string.IsNullOrWhiteSpace(gender))
        {
            var genderUpper = gender.ToUpperInvariant();
            filtered = filtered.Where(v =>
                v.Gender?.ToString()?.Equals(genderUpper, StringComparison.OrdinalIgnoreCase) == true);
        }

        if (!string.IsNullOrWhiteSpace(locale))
        {
            filtered = filtered.Where(v =>
                v.Locale?.Equals(locale, StringComparison.OrdinalIgnoreCase) == true ||
                v.SupportedLocales?.ContainsKey(locale) == true);
        }

        var voiceList = filtered.ToList();
        var parts = new List<string> { $"Available voices ({voiceList.Count}):" };

        foreach (var voice in voiceList)
        {
            var entry = $"- {voice.DisplayName} ({voice.VoiceId})";
            if (voice.Gender is not null)
            {
                entry += $" [{voice.Gender}]";
            }

            if (voice.Locale is not null)
            {
                entry += $" [{voice.Locale}]";
            }

            if (voice.AvailableStyles is { Count: > 0 })
            {
                entry += $" Styles: {string.Join(", ", voice.AvailableStyles)}";
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }

    private static string FormatTranslationResponse(MurfApiTranslationResponse response)
    {
        var parts = new List<string>();

        if (response.Translations is { Count: > 0 })
        {
            foreach (var translation in response.Translations)
            {
                parts.Add($"Translated text: {translation.TranslatedText}");
                if (!string.IsNullOrWhiteSpace(translation.SourceText))
                {
                    parts.Add($"Source text: {translation.SourceText}");
                }
            }
        }

        if (response.Metadata is not null)
        {
            if (response.Metadata.CharacterCount is not null)
            {
                parts.Add($"Source length: {response.Metadata.CharacterCount.TotalSourceTextLength}");
                parts.Add($"Translated length: {response.Metadata.CharacterCount.TotalTranslatedTextLength}");
            }

            if (response.Metadata.CreditsUsed is not null)
            {
                parts.Add($"Credits used: {response.Metadata.CreditsUsed}");
            }
        }

        return string.Join("\n", parts);
    }
}
