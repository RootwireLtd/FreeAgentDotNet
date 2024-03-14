using System.Text.Json.Serialization;
using Rootwire.ApiClients.FreeAgent.Entities.Invoices;

namespace Rootwire.ApiClients.FreeAgent.Models.Invoices;

public class InvoiceListResponseModel
{
    [JsonPropertyName("invoices")]
    public List<Invoice> Invoices { get; set; }
}