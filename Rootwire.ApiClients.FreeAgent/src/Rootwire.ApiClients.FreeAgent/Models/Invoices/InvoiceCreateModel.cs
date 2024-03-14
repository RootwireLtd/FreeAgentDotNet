using System.Text.Json.Serialization;
using Rootwire.ApiClients.FreeAgent.Services.Invoices;

namespace Rootwire.ApiClients.FreeAgent.Models.Invoices;

public class InvoiceCreateModel
{
    [JsonPropertyName("invoice")] public InvoiceCreateOptions Contact { get; set; }

    public InvoiceCreateModel(InvoiceCreateOptions options)
    {
        Contact = options;
    }
}