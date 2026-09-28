#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageAuthApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"subpackage-auth", @"subpackage_auth endpoint commands.");
                         command.Subcommands.Add(SubpackageAuthGenerateTokenCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}