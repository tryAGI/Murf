#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static class SubpackageTextToSpeechApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-text-to-speech", @"subpackage_textToSpeech endpoint commands.");
                         command.Subcommands.Add(SubpackageTextToSpeechGenerateCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageTextToSpeechGetVoicesCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageTextToSpeechStreamCommandApiCommand.Create());
        return command;
    }
}