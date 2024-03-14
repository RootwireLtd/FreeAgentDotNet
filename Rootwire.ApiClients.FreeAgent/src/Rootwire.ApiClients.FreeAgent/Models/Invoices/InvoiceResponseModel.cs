using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Rootwire.ApiClients.FreeAgent.Entities.Invoices;

namespace Rootwire.ApiClients.FreeAgent.Models.Invoices;

public class InvoiceResponseModel
{
    [JsonPropertyName("invoice")] public Invoice Invoice { get; set; }
}