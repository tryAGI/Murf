#nullable enable

using System.CommandLine;
using Murf.CLI;
using Murf.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the Murf SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(SubpackageAuthApiGroupCommand.Create());
rootCommand.Subcommands.Add(SubpackageDubbingSubpackageDubbingJobsApiGroupCommand.Create());
rootCommand.Subcommands.Add(SubpackageDubbingSubpackageDubbingLanguagesApiGroupCommand.Create());
rootCommand.Subcommands.Add(SubpackageDubbingSubpackageDubbingProjectsApiGroupCommand.Create());
rootCommand.Subcommands.Add(SubpackageTextApiGroupCommand.Create());
rootCommand.Subcommands.Add(SubpackageTextToSpeechApiGroupCommand.Create());
rootCommand.Subcommands.Add(SubpackageVoiceChangerApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);