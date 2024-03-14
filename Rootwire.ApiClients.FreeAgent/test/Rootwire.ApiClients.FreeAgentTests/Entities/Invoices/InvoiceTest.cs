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

        InvoiceListResponseModel invoiceListResponseModel = System.Text.Json.JsonSerializer.Deserialize<InvoiceListResponseModel>(jsonElement);

        Assert.NotNull(invoiceListResponseModel);
        Assert.IsType<InvoiceListResponseModel>(invoiceListResponseModel);
        Assert.Equal("https://api.freeagent.com/v2/invoices/1", invoiceListResponseModel.Invoices[0].Url.ToString());
        Assert.Equal(true,invoiceListResponseModel.Invoices[0].PaymentMethods.Paypal);
        Assert.Equal(false,invoiceListResponseModel.Invoices[0].PaymentMethods.Stripe);
    }
}