using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.FreeAgent.Entities.Categories;

public class CategoryIncome
{
    [JsonPropertyName("url")] public Uri Url { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("nominal_code")] public string NominalCode { get; set; }
    [JsonPropertyName("auto_sales_tax_rate")] public string AutoSalesTaxRate { get; set; }
    
    [JsonPropertyName("parsed_id")] public string Id => GetResourceId();

    public string GetResourceId()
    {
        var segments = Url.Segments;

        var resourceId = segments[segments.Length - 1].TrimEnd('/');

        return resourceId;
    }
}