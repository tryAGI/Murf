#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageVoiceChangerConvertCommandApiCommand
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

    private static Option<bool?> EncodeOutputAsBase64 { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--encode-output-as-base64",
        description: @"Set to true to receive audio in response as a Base64 encoded string along with a url.");

    private static Option<byte[]?> File { get; } = new(
        name: @"--file")
    {
        Description = @"The file to upload",
    };

    private static Option<string?> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"The file to upload",
    };

    private static Option<string?> FileUrl { get; } = new(
        name: @"--file-url")
    {
        Description = @"",
    };

    private static Option<string?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Format of the generated audio file. Valid values: MP3, WAV, FLAC, ALAW, ULAW",
    };

    private static Option<string?> MultiNativeLocale { get; } = new(
        name: @"--multi-native-locale")
    {
        Description = @"Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.
Valid values: ""en-US"", ""en-UK"", ""es-ES"", etc.

Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.",
    };

    private static Option<int?> Pitch { get; } = new(
        name: @"--pitch")
    {
        Description = @"Pitch of the voiceover",
    };

    private static Option<string?> PronunciationDictionary { get; } = new(
        name: @"--pronunciation-dictionary")
    {
        Description = @"A JSON string that defines custom pronunciations for specific words or phrases. Each key is a word or phrase, and its value is an object with `type` and `pronunciation`.

Example 1: '{""live"": {""type"": ""IPA"", ""pronunciation"": ""laɪv""}}'

Example 2: '{""2022"": {""type"": ""SAY_AS"", ""pronunciation"": ""twenty twenty two""}}'",
    };

    private static Option<int?> Rate { get; } = new(
        name: @"--rate")
    {
        Description = @"Speed of the voiceover",
    };

    private static Option<bool?> RetainAccent { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--retain-accent",
        description: @"Set to true to retain the original accent of the speaker during voice generation.");

    private static Option<bool?> RetainProsody { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--retain-prosody",
        description: @"Indicates whether to retain the original prosody (intonation, rhythm, and stress) of the input voice in the generated output.");

    private static Option<bool?> ReturnTranscription { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--return-transcription",
        description: @"Set to true to include a textual transcription of the generated audio in the response.");

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

    private static Option<string?> Transcription { get; } = new(
        name: @"--transcription")
    {
        Description = @"This parameter allows specifying a transcription of the audio clip, which will then be used as input for the voice changer",
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

                    private static string FormatResponse(ParseResult parseResult, global::Murf.SpeechToSpeechResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Murf.SpeechToSpeechResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"convert", @"Voice Changer
Returns a url to the generated audio file along with other associated properties.");
                        command.Options.Add(AudioDuration);
                        command.Options.Add(ChannelType);
                        command.Options.Add(EncodeOutputAsBase64);
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(FileUrl);
                        command.Options.Add(Format);
                        command.Options.Add(MultiNativeLocale);
                        command.Options.Add(Pitch);
                        command.Options.Add(PronunciationDictionary);
                        command.Options.Add(Rate);
                        command.Options.Add(RetainAccent);
                        command.Options.Add(RetainProsody);
                        command.Options.Add(ReturnTranscription);
                        command.Options.Add(SampleRate);
                        command.Options.Add(Style);
                        command.Options.Add(Transcription);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Murf.ConvertRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Murf.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var audioDuration = CliRuntime.WasSpecified(parseResult, AudioDuration) ? parseResult.GetValue(AudioDuration) : (__requestBase is { } __AudioDurationBaseValue ? __AudioDurationBaseValue.AudioDuration : default);
                        var channelType = CliRuntime.WasSpecified(parseResult, ChannelType) ? parseResult.GetValue(ChannelType) : (__requestBase is { } __ChannelTypeBaseValue ? __ChannelTypeBaseValue.ChannelType : default);
                        var encodeOutputAsBase64 = CliRuntime.WasSpecified(parseResult, EncodeOutputAsBase64) ? parseResult.GetValue(EncodeOutputAsBase64) : (__requestBase is { } __EncodeOutputAsBase64BaseValue ? __EncodeOutputAsBase64BaseValue.EncodeOutputAsBase64 : default);
                        var file = CliRuntime.WasSpecified(parseResult, File) ? parseResult.GetValue(File) : (__requestBase is { } __FileBaseValue ? __FileBaseValue.File : default);
                        var filename = CliRuntime.WasSpecified(parseResult, Filename) ? parseResult.GetValue(Filename) : (__requestBase is { } __FilenameBaseValue ? __FilenameBaseValue.Filename : default);
                        var fileUrl = CliRuntime.WasSpecified(parseResult, FileUrl) ? parseResult.GetValue(FileUrl) : (__requestBase is { } __FileUrlBaseValue ? __FileUrlBaseValue.FileUrl : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var multiNativeLocale = CliRuntime.WasSpecified(parseResult, MultiNativeLocale) ? parseResult.GetValue(MultiNativeLocale) : (__requestBase is { } __MultiNativeLocaleBaseValue ? __MultiNativeLocaleBaseValue.MultiNativeLocale : default);
                        var pitch = CliRuntime.WasSpecified(parseResult, Pitch) ? parseResult.GetValue(Pitch) : (__requestBase is { } __PitchBaseValue ? __PitchBaseValue.Pitch : default);
                        var pronunciationDictionary = CliRuntime.WasSpecified(parseResult, PronunciationDictionary) ? parseResult.GetValue(PronunciationDictionary) : (__requestBase is { } __PronunciationDictionaryBaseValue ? __PronunciationDictionaryBaseValue.PronunciationDictionary : default);
                        var rate = CliRuntime.WasSpecified(parseResult, Rate) ? parseResult.GetValue(Rate) : (__requestBase is { } __RateBaseValue ? __RateBaseValue.Rate : default);
                        var retainAccent = CliRuntime.WasSpecified(parseResult, RetainAccent) ? parseResult.GetValue(RetainAccent) : (__requestBase is { } __RetainAccentBaseValue ? __RetainAccentBaseValue.RetainAccent : default);
                        var retainProsody = CliRuntime.WasSpecified(parseResult, RetainProsody) ? parseResult.GetValue(RetainProsody) : (__requestBase is { } __RetainProsodyBaseValue ? __RetainProsodyBaseValue.RetainProsody : default);
                        var returnTranscription = CliRuntime.WasSpecified(parseResult, ReturnTranscription) ? parseResult.GetValue(ReturnTranscription) : (__requestBase is { } __ReturnTranscriptionBaseValue ? __ReturnTranscriptionBaseValue.ReturnTranscription : default);
                        var sampleRate = CliRuntime.WasSpecified(parseResult, SampleRate) ? parseResult.GetValue(SampleRate) : (__requestBase is { } __SampleRateBaseValue ? __SampleRateBaseValue.SampleRate : default);
                        var style = CliRuntime.WasSpecified(parseResult, Style) ? parseResult.GetValue(Style) : (__requestBase is { } __StyleBaseValue ? __StyleBaseValue.Style : default);
                        var transcription = CliRuntime.WasSpecified(parseResult, Transcription) ? parseResult.GetValue(Transcription) : (__requestBase is { } __TranscriptionBaseValue ? __TranscriptionBaseValue.Transcription : default);
                        var variation = CliRuntime.WasSpecified(parseResult, Variation) ? parseResult.GetValue(Variation) : (__requestBase is { } __VariationBaseValue ? __VariationBaseValue.Variation : default);
                        var voiceId = parseResult.GetRequiredValue(VoiceId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageVoiceChanger.ConvertAsync(
                                    audioDuration: audioDuration,
                                    channelType: channelType,
                                    encodeOutputAsBase64: encodeOutputAsBase64,
                                    file: file,
                                    filename: filename,
                                    fileUrl: fileUrl,
                                    format: format,
                                    multiNativeLocale: multiNativeLocale,
                                    pitch: pitch,
                                    pronunciationDictionary: pronunciationDictionary,
                                    rate: rate,
                                    retainAccent: retainAccent,
                                    retainProsody: retainProsody,
                                    returnTranscription: returnTranscription,
                                    sampleRate: sampleRate,
                                    style: style,
                                    transcription: transcription,
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