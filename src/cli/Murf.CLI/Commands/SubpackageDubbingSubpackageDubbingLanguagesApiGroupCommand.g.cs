#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static class SubpackageDubbingSubpackageDubbingLanguagesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-dubbing-subpackage-dubbing-languages", @"subpackage_dubbing.subpackage_dubbing/languages endpoint commands.");
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingLanguagesListDestinationLanguagesCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingLanguagesListSourceLanguagesCommandApiCommand.Create());
        return command;
    }
}