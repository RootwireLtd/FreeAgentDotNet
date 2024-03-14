using System.Text.Json;
using Rootwire.ApiClients.FreeAgent.Models.Invoices;

namespace Rootwire.ApiClients.FreeAgentTests.Entities.Invoices;

public class InvoiceTest : BaseFreeAgentTest
{
    [Fact]
    public void Deserialize()
    {
        string json = this.GetFixture("v2/invoices");

        JsonElement jsonElement = JsonDocument.Parse(json).RootElement;

        InvoiceListResponseModel invoiceListResponseModel = System.Text.Json.JsonSerializer.Deserialize<InvoiceListResponseModel>(jsonElement, _jsonSerializerOptions);

        Assert.NotNull(invoiceListResponseModel);
        Assert.IsType<InvoiceListResponseModel>(invoiceListResponseModel);
        Assert.Equal("https://api.sandbox.freeagent.com/v2/invoices/522684", invoiceListResponseModel.Invoices[0].Url.ToString());
    }

    [Fact]
    public void DeserializeOne()
    {
        string json = this.GetFixture("v2/invoices/522695");

        JsonElement jsonElement = JsonDocument.Parse(json).RootElement;

        InvoiceResponseModel invoiceResponseModel =
            System.Text.Json.JsonSerializer.Deserialize<InvoiceResponseModel>(jsonElement, _jsonSerializerOptions);

        Assert.NotNull(invoiceResponseModel);
        Assert.IsType<InvoiceResponseModel>(invoiceResponseModel);
        Assert.Equal((decimal)79.25, invoiceResponseModel.Invoice.NetValue);
        Assert.Equal((decimal)1.0, invoiceResponseModel.Invoice.ExchangeRate);
        Assert.Equal((decimal)0.0, invoiceResponseModel.Invoice.PaidValue);
        Assert.Equal((decimal)79.25, invoiceResponseModel.Invoice.DueValue);
        Assert.Equal(2, invoiceResponseModel.Invoice.InvoiceItems.Count);
        
    }
}