#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static class SubpackageVoiceChangerApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-voice-changer", @"subpackage_voiceChanger endpoint commands.");
                         command.Subcommands.Add(SubpackageVoiceChangerConvertCommandApiCommand.Create());
        return command;
    }
}