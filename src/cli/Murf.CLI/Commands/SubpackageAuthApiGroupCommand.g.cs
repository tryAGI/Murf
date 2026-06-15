#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static class SubpackageAuthApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-auth", @"subpackage_auth endpoint commands.");
                         command.Subcommands.Add(SubpackageAuthGenerateTokenCommandApiCommand.Create());
        return command;
    }
}