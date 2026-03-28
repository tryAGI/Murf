namespace Murf.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MurfClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MURF_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MURF_API_KEY environment variable is not found.");

        var client = new MurfClient(apiKey);
        
        return client;
    }
}
