using System.Text.Json.Serialization;
using Rootwire.ApiClients.FreeAgent.Entities._base;

namespace Rootwire.ApiClients.FreeAgent.Entities.Categories;

public class CategoryGeneral : FreeAgentEntity
{
    [JsonPropertyName("url")] public Uri Url { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("nominal_code")] public string NominalCode { get; set; }
}