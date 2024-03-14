using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.FreeAgent.Services.Invoices;

public class InvoiceItemCreateOptions
{
    [JsonPropertyName("description")] public string Description { get; set; }
    
    [JsonPropertyName("item_type")] public string? ItemType { get; set; }
    [JsonPropertyName("quantity")] public Decimal? Quantity { get; set; }
    
    [JsonPropertyName("price")] public Decimal? Price { get; set; } = null;
    [JsonPropertyName("sales_tax_rate")] public Decimal? SalesTaxRate { get; set; }
    [JsonPropertyName("second_sales_tax_rate")] public Decimal? SecondSalesTaxRate { get; set; }
    [JsonPropertyName("sales_tax_status")] public string? SalesTaxStatus { get; set; }
    [JsonPropertyName("stock_item")] public Uri? StockItem { get; set; }
    [JsonPropertyName("category")] public Uri? Category { get; set; }
    [JsonPropertyName("project")] public Uri? Project { get; set; }
}