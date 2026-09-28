#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageDubbingSubpackageDubbingLanguagesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"subpackage-dubbing-subpackage-dubbing-languages", @"subpackage_dubbing.subpackage_dubbing/languages endpoint commands.");
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingLanguagesListDestinationLanguagesCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingLanguagesListSourceLanguagesCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}