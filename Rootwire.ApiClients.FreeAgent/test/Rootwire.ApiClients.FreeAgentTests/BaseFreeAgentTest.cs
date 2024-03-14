using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Rootwire.ApiClients.FreeAgent.Infrastructure.Public;

namespace Rootwire.ApiClients.FreeAgentTests;

public class BaseFreeAgentTest
{

    protected JsonSerializerOptions _jsonSerializerOptions;
    
    public BaseFreeAgentTest()
    {
        var freeAgentClient = new FreeAgentClient(Constants.AccessToken, Constants.TestBaseUrl);
        FreeAgentClient = freeAgentClient;

        _jsonSerializerOptions = new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters = { new StringToDecimalConverter() },
        };

    }
    
    protected IFreeAgentClient FreeAgentClient { get; }
    
    protected string GetFixture(string path)
    {
        return FreeAgentFixtures.GetFixture(path);
    }
}