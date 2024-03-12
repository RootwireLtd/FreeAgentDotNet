using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.FreeAgent.Entities.Categories;

public class CategoryIncome
{
    [JsonPropertyName("url")] public Uri Url { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("nominal_code")] public string NominalCode { get; set; }
    [JsonPropertyName("auto_sales_tax_rate")] public string AutoSalesTaxRate { get; set; }
}