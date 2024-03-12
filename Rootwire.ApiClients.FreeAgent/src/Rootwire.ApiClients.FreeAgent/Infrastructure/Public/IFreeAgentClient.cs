using RestSharp;
using Rootwire.ApiClients.FreeAgent.Entities._interfaces;

namespace Rootwire.ApiClients.FreeAgent.Infrastructure.Public;

public interface IFreeAgentClient
{
    public string ApiBase { get; }
    
    public IRestClient RestClient { get; }
}