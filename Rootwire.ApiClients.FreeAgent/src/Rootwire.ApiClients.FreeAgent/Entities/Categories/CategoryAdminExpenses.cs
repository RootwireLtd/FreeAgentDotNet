using System.Text.Json.Serialization;
using Rootwire.ApiClients.FreeAgent.Entities._base;

namespace Rootwire.ApiClients.FreeAgent.Entities.Categories;

public class CategoryAdminExpenses : FreeAgentEntity
{
    [JsonPropertyName("url")] public Uri Url { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("nominal_code")] public string NominalCode { get; set; }
    [JsonPropertyName("allowable_for_tax")] public bool AllowableForTax { get; set; }
    [JsonPropertyName("tax_reporting_name")] public string TaxReportingName { get; set; }
    [JsonPropertyName("auto_sales_tax_rate")] public string AutoSalesTaxRate { get; set; }
}