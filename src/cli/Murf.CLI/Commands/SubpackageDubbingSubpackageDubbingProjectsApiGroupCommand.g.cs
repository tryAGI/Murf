#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageDubbingSubpackageDubbingProjectsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"subpackage-dubbing-subpackage-dubbing-projects", @"subpackage_dubbing.subpackage_dubbing/projects endpoint commands.");
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingProjectsCreateDubbingProjectCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingProjectsListCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingProjectsUpdateCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}