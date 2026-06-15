#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static class SubpackageTextApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-text", @"subpackage_text endpoint commands.");
                         command.Subcommands.Add(SubpackageTextTranslateCommandApiCommand.Create());
        return command;
    }
}