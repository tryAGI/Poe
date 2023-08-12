using Poe;

namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public void Generate()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("POE_API_KEY") ??
            throw new AssertInconclusiveException("POE_API_KEY environment variable is not found.");

        using var client = new HttpClient();
        var api = new PoeApi(apiKey, client);
    }
}
