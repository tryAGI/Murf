#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(SubpackageAuthApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingJobsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingLanguagesApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingProjectsApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageTextApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageTextToSpeechApiGroupCommand.Create());
                         command.Subcommands.Add(SubpackageVoiceChangerApiGroupCommand.Create());
        return command;
    }
}