using System.Text.Json.Serialization;
using Rootwire.ApiClients.FreeAgent.Entities._base;

namespace Rootwire.ApiClients.FreeAgent.Entities.Categories;

public class CategoryGeneral : FreeAgentEntity
{
    [JsonPropertyName("url")] public Uri Url { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("nominal_code")] public string NominalCode { get; set; }
    
    [JsonPropertyName("parsed_id")] public string Id => GetResourceId();

    public string GetResourceId()
    {
        var segments = Url.Segments;

        var resourceId = segments[segments.Length - 1].TrimEnd('/');

        return resourceId;
    }
}