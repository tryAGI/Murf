#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageDubbingSubpackageDubbingJobsCreateDubbingJobCommandApiCommand
{
    private static Option<byte[]?> File { get; } = new(
        name: @"--file")
    {
        Description = @"The file to upload",
    };

    private static Option<string?> FileUrl { get; } = new(
        name: @"--file-url")
    {
        Description = @"",
    };

    private static Option<string?> SourceLocale { get; } = new(
        name: @"--source-locale")
    {
        Description = @"Source locale",
    };

    private static Option<global::System.Collections.Generic.IList<string>> TargetLocales { get; } = new(
        name: @"--target-locales")
    {
        Description = @"List of target locales",
        Required = true,
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"",
    };

    private static Option<string?> FileName { get; } = new(
        name: @"--file-name")
    {
        Description = @"",
    };

    private static Option<global::Murf.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority?> Priority { get; } = new(
        name: @"--priority")
    {
        Description = @"Priority of the job. Allowed values: LOW, NORMAL, HIGH",
    };

    private static Option<string?> WebhookSecret { get; } = new(
        name: @"--webhook-secret")
    {
        Description = @"",
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

                    private static string FormatResponse(ParseResult parseResult, global::Murf.ApiJobResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Murf.ApiJobResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-dubbing-job", @"Create");
                        command.Options.Add(File);
                        command.Options.Add(FileUrl);
                        command.Options.Add(SourceLocale);
                        command.Options.Add(TargetLocales);
                        command.Options.Add(WebhookUrl);
                        command.Options.Add(FileName);
                        command.Options.Add(Priority);
                        command.Options.Add(WebhookSecret);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Murf.CreateDubbingJobRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Murf.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var file = CliRuntime.WasSpecified(parseResult, File) ? parseResult.GetValue(File) : __requestBase is not null ? __requestBase.File : default;
                        var fileUrl = CliRuntime.WasSpecified(parseResult, FileUrl) ? parseResult.GetValue(FileUrl) : __requestBase is not null ? __requestBase.FileUrl : default;
                        var sourceLocale = CliRuntime.WasSpecified(parseResult, SourceLocale) ? parseResult.GetValue(SourceLocale) : __requestBase is not null ? __requestBase.SourceLocale : default;
                        var targetLocales = parseResult.GetRequiredValue(TargetLocales);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : __requestBase is not null ? __requestBase.WebhookUrl : default;
                        var fileName = CliRuntime.WasSpecified(parseResult, FileName) ? parseResult.GetValue(FileName) : __requestBase is not null ? __requestBase.FileName : default;
                        var priority = CliRuntime.WasSpecified(parseResult, Priority) ? parseResult.GetValue(Priority) : __requestBase is not null ? __requestBase.Priority : default;
                        var webhookSecret = CliRuntime.WasSpecified(parseResult, WebhookSecret) ? parseResult.GetValue(WebhookSecret) : __requestBase is not null ? __requestBase.WebhookSecret : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageDubbingSubpackageDubbingJobs.CreateDubbingJobAsync(
                                    file: file,
                                    fileUrl: fileUrl,
                                    sourceLocale: sourceLocale,
                                    targetLocales: targetLocales,
                                    webhookUrl: webhookUrl,
                                    fileName: fileName,
                                    priority: priority,
                                    webhookSecret: webhookSecret,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Murf.SourceGenerationContext.Default,
                                        @"TargetLocales",
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