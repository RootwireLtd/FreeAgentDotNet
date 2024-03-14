using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using RestSharp.Serializers.Json;
using Rootwire.ApiClients.FreeAgent.Entities._interfaces;

namespace Rootwire.ApiClients.FreeAgent.Infrastructure.Public;

public class FreeAgentClient : IFreeAgentClient
{
  
    public FreeAgentClient(
        string accessToken, 
        string? apiBase = null)
    {

        var serializerOptions = new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters = { new StringToDecimalConverter() },

        };
        
        ApiBase = apiBase ?? DefaultApiBase;

        RestClient = new RestClient(new RestClientOptions(ApiBase)
        {
            Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(accessToken, "Bearer"),
            
        },
            configureSerialization: s => s.UseSystemTextJson(serializerOptions));

    }

    public static string DefaultApiBase = "https://api.freeagent.com";
    
    public string ApiBase { get; }
    public IRestClient RestClient { get; }
    
    
    
}