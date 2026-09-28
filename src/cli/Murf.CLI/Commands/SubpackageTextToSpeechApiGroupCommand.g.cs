#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageTextToSpeechApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"subpackage-text-to-speech", @"subpackage_textToSpeech endpoint commands.");
                         command.Subcommands.Add(SubpackageTextToSpeechGenerateCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageTextToSpeechGetVoicesCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageTextToSpeechStreamCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}