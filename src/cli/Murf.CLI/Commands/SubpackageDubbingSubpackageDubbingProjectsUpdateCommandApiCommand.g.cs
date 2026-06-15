#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageDubbingSubpackageDubbingProjectsUpdateCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>> TargetLocales { get; } = new(
        name: @"--target-locales")
    {
        Description = @"List of target locales",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Murf.ApiProjectResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Murf.ApiProjectResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update", @"Update");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(TargetLocales);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var targetLocales = parseResult.GetRequiredValue(TargetLocales);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SubpackageDubbingSubpackageDubbingProjects.UpdateAsync(
                                    projectId: projectId,
                                    targetLocales: targetLocales,
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