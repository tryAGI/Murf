#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static partial class SubpackageVoiceChangerApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"subpackage-voice-changer", @"subpackage_voiceChanger endpoint commands.");
                         command.Subcommands.Add(SubpackageVoiceChangerConvertCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}