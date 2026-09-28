#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageTextApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"subpackage-text", @"subpackage_text endpoint commands.");
                         command.Subcommands.Add(SubpackageTextTranslateCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}