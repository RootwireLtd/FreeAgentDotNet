using Rootwire.ApiClients.FreeAgent.Infrastructure.Public;

namespace Rootwire.ApiClients.FreeAgentTests;

public class BaseFreeAgentTest
{
    public BaseFreeAgentTest()
    {
        var freeAgentClient = new FreeAgentClient(Constants.AccessToken, Constants.TestBaseUrl);
        FreeAgentClient = freeAgentClient;
    }
    
    protected IFreeAgentClient FreeAgentClient { get; }
    
    protected string GetFixture(string path)
    {
        return FreeAgentFixtures.GetFixture(path);
    }
}