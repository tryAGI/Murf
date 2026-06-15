#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageTextToSpeechGenerateCommandApiCommand
{
    private static Option<double?> AudioDuration { get; } = new(
        name: @"--audio-duration")
    {
        Description = @"This parameter allows specifying the duration (in seconds) for the generated audio. If the value is 0, this parameter will be ignored. Only available for Gen2 model.",
    };

    private static Option<string?> ChannelType { get; } = new(
        name: @"--channel-type")
    {
        Description = @"Valid values: STEREO, MONO",
    };

    private static Option<bool?> EncodeAsBase64 { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--encode-as-base64",
        description: @"Set to true to receive audio in response as a Base64 encoded string instead of a url. This enables zero retention of audio data on Murf's servers.");

    private static Option<string?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Format of the generated audio file. Valid values: MP3, WAV, FLAC, ALAW, ULAW, PCM, OGG",
    };

    private static Option<global::Murf.GenerateSpeechRequestModelVersion?> ModelVersion { get; } = new(
        name: @"--model-version")
    {
        Description = @"Valid values: GEN2. Audio will be generated using the new and advanced GEN2 model. Outputs from GEN2 sound more natural and high-quality compared to earlier models.",
    };

    private static Option<string?> MultiNativeLocale { get; } = new(
        name: @"--multi-native-locale")
    {
        Description = @"This field is superseded by `locale` field. Please migrate to `locale` field to ensure compatibility with future API versions.

Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.
Valid values: ""en-US"", ""en-UK"", ""es-ES"", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.",
    };

    private static Option<string?> Locale { get; } = new(
        name: @"--locale")
    {
        Description = @"Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.
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
        Description = @"Valid values are 8000, 24000, 44100, 48000",
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

    private static Option<bool?> WordDurationsAsOriginalText { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--word-durations-as-original-text",
        description: @"If set to true, the word durations in response will return words as the original input text. (English only)");
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

                    private static string FormatResponse(ParseResult parseResult, global::Murf.GenerateSpeechResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Murf.GenerateSpeechResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate", @"Synthesize Speech
Returns a url to the generated audio file along with other associated properties.");
                        command.Options.Add(AudioDuration);
                        command.Options.Add(ChannelType);
                        command.Options.Add(EncodeAsBase64);
                        command.Options.Add(Format);
                        command.Options.Add(ModelVersion);
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
                        command.Options.Add(WordDurationsAsOriginalText);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Murf.GenerateSpeechRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Murf.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var audioDuration = CliRuntime.WasSpecified(parseResult, AudioDuration) ? parseResult.GetValue(AudioDuration) : __requestBase is not null ? __requestBase.AudioDuration : default;
                        var channelType = CliRuntime.WasSpecified(parseResult, ChannelType) ? parseResult.GetValue(ChannelType) : __requestBase is not null ? __requestBase.ChannelType : default;
                        var encodeAsBase64 = CliRuntime.WasSpecified(parseResult, EncodeAsBase64) ? parseResult.GetValue(EncodeAsBase64) : __requestBase is not null ? __requestBase.EncodeAsBase64 : default;
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : __requestBase is not null ? __requestBase.Format : default;
                        var modelVersion = CliRuntime.WasSpecified(parseResult, ModelVersion) ? parseResult.GetValue(ModelVersion) : __requestBase is not null ? __requestBase.ModelVersion : default;
                        var multiNativeLocale = CliRuntime.WasSpecified(parseResult, MultiNativeLocale) ? parseResult.GetValue(MultiNativeLocale) : __requestBase is not null ? __requestBase.MultiNativeLocale : default;
                        var locale = CliRuntime.WasSpecified(parseResult, Locale) ? parseResult.GetValue(Locale) : __requestBase is not null ? __requestBase.Locale : default;
                        var pitch = CliRuntime.WasSpecified(parseResult, Pitch) ? parseResult.GetValue(Pitch) : __requestBase is not null ? __requestBase.Pitch : default;
                        var pronunciationDictionary = CliRuntime.WasSpecified(parseResult, PronunciationDictionary) ? parseResult.GetValue(PronunciationDictionary) : __requestBase is not null ? __requestBase.PronunciationDictionary : default;
                        var rate = CliRuntime.WasSpecified(parseResult, Rate) ? parseResult.GetValue(Rate) : __requestBase is not null ? __requestBase.Rate : default;
                        var sampleRate = CliRuntime.WasSpecified(parseResult, SampleRate) ? parseResult.GetValue(SampleRate) : __requestBase is not null ? __requestBase.SampleRate : default;
                        var style = CliRuntime.WasSpecified(parseResult, Style) ? parseResult.GetValue(Style) : __requestBase is not null ? __requestBase.Style : default;
                        var text = parseResult.GetRequiredValue(Text);
                        var variation = CliRuntime.WasSpecified(parseResult, Variation) ? parseResult.GetValue(Variation) : __requestBase is not null ? __requestBase.Variation : default;
                        var voiceId = parseResult.GetRequiredValue(VoiceId);
                        var wordDurationsAsOriginalText = CliRuntime.WasSpecified(parseResult, WordDurationsAsOriginalText) ? parseResult.GetValue(WordDurationsAsOriginalText) : __requestBase is not null ? __requestBase.WordDurationsAsOriginalText : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageTextToSpeech.GenerateAsync(
                                    audioDuration: audioDuration,
                                    channelType: channelType,
                                    encodeAsBase64: encodeAsBase64,
                                    format: format,
                                    modelVersion: modelVersion,
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
                                    wordDurationsAsOriginalText: wordDurationsAsOriginalText,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Murf.SourceGenerationContext.Default,
                                        @"WordDurations",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Murf.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}