using RestSharp;
using RestSharp.Authenticators.OAuth2;
using Rootwire.ApiClients.FreeAgent.Entities._interfaces;

namespace Rootwire.ApiClients.FreeAgent.Infrastructure.Public;

public class FreeAgentClient : IFreeAgentClient
{
  
    public FreeAgentClient(
        string accessToken, 
        string? apiBase = null)
    {
        ApiBase = apiBase ?? DefaultApiBase;

        RestClient = new RestClient(new RestClientOptions(ApiBase)
        {
            Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(accessToken, "Bearer")
        });

    }

    public static string DefaultApiBase = "https://api.freeagent.com";
    
    public string ApiBase { get; }
    public IRestClient RestClient { get; }
    
    
    
}