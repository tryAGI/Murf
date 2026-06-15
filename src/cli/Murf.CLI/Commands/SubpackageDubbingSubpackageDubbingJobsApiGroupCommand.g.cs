#nullable enable

using System.CommandLine;

namespace Murf.CLI.Commands;

internal static class SubpackageDubbingSubpackageDubbingJobsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"subpackage-dubbing-subpackage-dubbing-jobs", @"subpackage_dubbing.subpackage_dubbing/jobs endpoint commands.");
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingJobsCreateDubbingJobCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingJobsCreateDubbingJobWithProjectIdCommandApiCommand.Create());
                         command.Subcommands.Add(SubpackageDubbingSubpackageDubbingJobsGetStatusCommandApiCommand.Create());
        return command;
    }
}