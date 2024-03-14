using Rootwire.ApiClients.FreeAgent.Services.Invoices;

namespace Rootwire.ApiClients.FreeAgent.Models.Invoices;

public class InvoiceUpdateModel : InvoiceCreateModel
{
    public InvoiceUpdateModel(InvoiceCreateOptions options) : base(options)
    {
    }
}