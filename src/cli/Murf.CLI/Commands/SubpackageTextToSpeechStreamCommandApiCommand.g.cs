#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageTextToSpeechStreamCommandApiCommand
{
    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use for audio output. Defaults to FALCON for all the regions except US-East. Valid values: FALCON, GEN2",
    };

    private static Option<string?> ChannelType { get; } = new(
        name: @"--channel-type")
    {
        Description = @"Valid values: STEREO, MONO",
    };

    private static Option<string?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Format of the generated audio file.Valid values: MP3, FLAC, WAV, ALAW, ULAW, OGG, PCM",
    };

    private static Option<string?> MultiNativeLocale { get; } = new(
        name: @"--multi-native-locale")
    {
        Description = @"This field is superseded by `locale` field. Please migrate to `locale` field to ensure compatibility with future API versions.

Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.
Valid values: ""en-US"", ""en-UK"", ""es-ES"", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.",
    };

    private static Option<string?> Locale { get; } = new(
        name: @"--locale")
    {
        Description = @"Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.
Valid values: ""en-US"", ""en-UK"", ""es-ES"", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.",
    };

    private static Option<int?> Pitch { get; } = new(
        name: @"--pitch")
    {
        Description = @"Pitch of the voiceover",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, global::Murf.PronunciationDetail>?> PronunciationDictionary { get; } = new(
        name: @"--pronunciation-dictionary")
    {
        Description = @"An object used to define custom pronunciations.

 Example 1: {""live"":{""type"": ""IPA"", ""pronunciation"": ""laɪv""}}.

 Example 2: {""2022"":{""type"": ""SAY_AS"", ""pronunciation"": ""twenty twenty two""}}",
    };

    private static Option<int?> Rate { get; } = new(
        name: @"--rate")
    {
        Description = @"Speed of the voiceover",
    };

    private static Option<double?> SampleRate { get; } = new(
        name: @"--sample-rate")
    {
        Description = @"Valid values are 8000, 16000, 24000, 44100, 48000. Defaults to 24000 for Falcon model and 44100 for Gen2 model.",
    };

    private static Option<string?> Style { get; } = new(
        name: @"--style")
    {
        Description = @"The voice style to be used for voiceover generation.",
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"The text that is to be synthesised. e.g. 'Hello there [pause 1s] friend'",
        Required = true,
    };

    private static Option<int?> Variation { get; } = new(
        name: @"--variation")
    {
        Description = @"Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.",
    };

    private static Option<string> VoiceId { get; } = new(
        name: @"--voice-id")
    {
        Description = @"Use the GET /v1/speech/voices API to find supported voiceIds. You can use either the voiceId (e.g. en-US-natalie) or just the voice actor's name (e.g. natalie).",
        Required = true,
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Murf.TextToSpeechStreamResponse200 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Murf.TextToSpeechStreamResponse200 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"stream", @"Stream Speech
Synthesize speech with ultra-low latency over a streaming connection.
Choose the `Base URL` from the URL dropdown (Global URL or a pinned Region)

**Note**: Global URL auto-routes to the nearest region.
| Region         | URL                                       | Default Concurrency |
| ------------------------- | ---------------------------------------------- | -------------------- |
| Global (Routes to the nearest server) | `https://global.api.murf.ai/v1/speech/stream`     | Region specific concurrency |
| US-East                   | `https://us-east.api.murf.ai/v1/speech/stream`    | 15 |
| US-West                   | `https://us-west.api.murf.ai/v1/speech/stream`    | 2 |
| India                     | `https://in.api.murf.ai/v1/speech/stream`         | 2 |
| Canada                    | `https://ca.api.murf.ai/v1/speech/stream`         | 2 |
| South Korea               | `https://kr.api.murf.ai/v1/speech/stream`         | 2 |
| UAE                       | `https://me.api.murf.ai/v1/speech/stream`         | 2 |
| Japan                     | `https://jp.api.murf.ai/v1/speech/stream`         | 2 |
| Australia                 | `https://au.api.murf.ai/v1/speech/stream`         | 2 |
| EU (Central)              | `https://eu-central.api.murf.ai/v1/speech/stream` | 2 |
| UK                        | `https://uk.api.murf.ai/v1/speech/stream`         | 2 |
| South America (São Paulo) | `https://sa-east.api.murf.ai/v1/speech/stream`    | 2 |
");
                        command.Options.Add(Model);
                        command.Options.Add(ChannelType);
                        command.Options.Add(Format);
                        command.Options.Add(MultiNativeLocale);
                        command.Options.Add(Locale);
                        command.Options.Add(Pitch);
                        command.Options.Add(PronunciationDictionary);
                        command.Options.Add(Rate);
                        command.Options.Add(SampleRate);
                        command.Options.Add(Style);
                        command.Options.Add(Text);
                        command.Options.Add(Variation);
                        command.Options.Add(VoiceId);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Murf.GenerateSpeechStreamingRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Murf.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var channelType = CliRuntime.WasSpecified(parseResult, ChannelType) ? parseResult.GetValue(ChannelType) : (__requestBase is { } __ChannelTypeBaseValue ? __ChannelTypeBaseValue.ChannelType : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var multiNativeLocale = CliRuntime.WasSpecified(parseResult, MultiNativeLocale) ? parseResult.GetValue(MultiNativeLocale) : (__requestBase is { } __MultiNativeLocaleBaseValue ? __MultiNativeLocaleBaseValue.MultiNativeLocale : default);
                        var locale = CliRuntime.WasSpecified(parseResult, Locale) ? parseResult.GetValue(Locale) : (__requestBase is { } __LocaleBaseValue ? __LocaleBaseValue.Locale : default);
                        var pitch = CliRuntime.WasSpecified(parseResult, Pitch) ? parseResult.GetValue(Pitch) : (__requestBase is { } __PitchBaseValue ? __PitchBaseValue.Pitch : default);
                        var pronunciationDictionary = CliRuntime.WasSpecified(parseResult, PronunciationDictionary) ? parseResult.GetValue(PronunciationDictionary) : (__requestBase is { } __PronunciationDictionaryBaseValue ? __PronunciationDictionaryBaseValue.PronunciationDictionary : default);
                        var rate = CliRuntime.WasSpecified(parseResult, Rate) ? parseResult.GetValue(Rate) : (__requestBase is { } __RateBaseValue ? __RateBaseValue.Rate : default);
                        var sampleRate = CliRuntime.WasSpecified(parseResult, SampleRate) ? parseResult.GetValue(SampleRate) : (__requestBase is { } __SampleRateBaseValue ? __SampleRateBaseValue.SampleRate : default);
                        var style = CliRuntime.WasSpecified(parseResult, Style) ? parseResult.GetValue(Style) : (__requestBase is { } __StyleBaseValue ? __StyleBaseValue.Style : default);
                        var text = parseResult.GetRequiredValue(Text);
                        var variation = CliRuntime.WasSpecified(parseResult, Variation) ? parseResult.GetValue(Variation) : (__requestBase is { } __VariationBaseValue ? __VariationBaseValue.Variation : default);
                        var voiceId = parseResult.GetRequiredValue(VoiceId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageTextToSpeech.StreamAsync(
                                    model: model,
                                    channelType: channelType,
                                    format: format,
                                    multiNativeLocale: multiNativeLocale,
                                    locale: locale,
                                    pitch: pitch,
                                    pronunciationDictionary: pronunciationDictionary,
                                    rate: rate,
                                    sampleRate: sampleRate,
                                    style: style,
                                    text: text,
                                    variation: variation,
                                    voiceId: voiceId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Murf.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}