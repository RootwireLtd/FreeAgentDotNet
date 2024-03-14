using System.Net;
using Rootwire.ApiClients.FreeAgent.Entities.Invoices;
using Rootwire.ApiClients.FreeAgent.Models.Invoices;
using Rootwire.ApiClients.FreeAgent.Services.Invoices;

namespace Rootwire.ApiClients.FreeAgentTests.Services.Invoices;


public class InvoiceServiceTests : BaseFreeAgentTest
{
    private readonly InvoiceService _invoiceService;
    private readonly InvoiceCreateOptions _invoiceCreateOptions;

    public InvoiceServiceTests()
    {
        _invoiceService = new InvoiceService(FreeAgentClient);
        _invoiceCreateOptions = new InvoiceCreateOptions()
        {
            Contact = new Uri("https://rootwiretestenv.sandbox.freeagent.com/contacts/151730"),
            DatedOn = new DateOnly(2024, 03, 14),
            PaymentTermsInDays = 10,
            
            Reference = Guid.NewGuid().ToString(),
            Currency = "GBP",
            Comments = "Test Invoice Comment",
            
            DiscountPercent = (Decimal)1.5,
            ContactName = "Test Contact Name",
            ClientContactName = "Test Client Contact Name",
            
            ShowProjectName = true,
            OmitHeader = true,
            AlwaysShowBicAndIban = true,
            PaymentTerms = "Custom Payment Terms Test",
            PoReference = "Test PO Reference",
            
            InvoiceItems = new List<InvoiceItemCreateOptions?>()
            {
                new InvoiceItemCreateOptions()
                {
                    Category = new Uri("https://rootwiretestenv.sandbox.freeagent.com/categories/002"),
                    Description = "Test Invoice Item 1",
                    Quantity = 3,
                    Price = (decimal)10.5
                },
                new InvoiceItemCreateOptions()
                {
                    Category = new Uri("https://rootwiretestenv.sandbox.freeagent.com/categories/002"),
                    Description = "Test Invoice Item 2",
                    Quantity = 32,
                    Price = (decimal)1.53
                }
            }
            
        };
    }

    [Fact]
    public async Task Create()
    {
        var invoiceResponseModel = await _invoiceService.CreateAsync(_invoiceCreateOptions);
        Assert.NotNull(invoiceResponseModel);
        Assert.Equal(HttpStatusCode.Created, invoiceResponseModel.StatusCode);

        await _invoiceService.DeleteByIdAsync(invoiceResponseModel.Data.Invoice.Id);
    }

    [Fact]
    public async Task GetAll()
    {
        var resposne = await _invoiceService.GetAllAsync();
        Assert.Equal(HttpStatusCode.OK, resposne.StatusCode);
        Assert.NotNull(resposne.Data);
        Assert.NotNull(resposne.Data.Invoices);
    }
}