using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rootwire.ApiClients.FreeAgent.Entities._interfaces;

namespace Rootwire.ApiClients.FreeAgent.Entities._base;

public abstract class FreeAgentEntity : IFreeAgentEntity
{
    [JsonIgnore]
    public JObject RawJObject { get; protected set; }
    
    
}