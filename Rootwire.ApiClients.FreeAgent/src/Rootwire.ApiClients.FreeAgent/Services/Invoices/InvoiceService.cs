using System.Text.Json;
using RestSharp;
using Rootwire.ApiClients.FreeAgent.Infrastructure.Public;
using Rootwire.ApiClients.FreeAgent.Models.Invoices;

namespace Rootwire.ApiClients.FreeAgent.Services.Invoices;

public class InvoiceService
{
    private readonly IFreeAgentClient _client;

    public InvoiceService(IFreeAgentClient client)
    {
        _client = client;
    }

    public string BasePath => "/v2/invoices";
    
    
    // Create
    public async Task<RestResponse<InvoiceResponseModel>> CreateAsync(InvoiceCreateOptions createOptions)
    {
        var request = new RestRequest(BasePath, Method.Post);
        
        InvoiceCreateModel invoiceCreateModel = new InvoiceCreateModel(createOptions);
        
        request.AddBody(invoiceCreateModel);

        var response = await _client.RestClient.ExecuteAsync<InvoiceResponseModel>(request);

        return response;
    }
    
    // GetOne
    public async Task<RestResponse<InvoiceResponseModel>> GetByIdAsync(int id)
    {
        var request = new RestRequest($"{BasePath}/{id}");

        var response = await _client.RestClient.ExecuteAsync<InvoiceResponseModel>(request);

        return response;
    }
    
    // GetMany
    public async Task<RestResponse<InvoiceListResponseModel>> GetAllAsync()
    {
        var request = new RestRequest(BasePath, Method.Get);

        var response = await _client.RestClient.ExecuteAsync<InvoiceListResponseModel>(request);

        return response;
    }

    public async Task<RestResponse<InvoiceListResponseModel>> GetAllByContactIdAsync(int contactId)
    {
        var request = new RestRequest(BasePath, Method.Get);

        var contactUri = $"{_client.ApiBase}/v2/contacts/{contactId}";
        
        request.AddParameter("contact", contactUri);

        var response = await _client.RestClient.ExecuteAsync<InvoiceListResponseModel>(request);

        return response;
    }
    
    // Update 
    public async Task<RestResponse> UpdateInvoiceAsync(int id, InvoiceUpdateOptions options)
    {
        var request = new RestRequest($"{BasePath}/{id}", Method.Put);

        InvoiceUpdateModel invoiceUpdateModel = new InvoiceUpdateModel(options);

        var payload = JsonSerializer.Serialize(invoiceUpdateModel);

        request.AddJsonBody(payload);

        var response = await _client.RestClient.ExecuteAsync(request);

        return response;
    }
    
    // Delete

    public async Task<RestResponse> DeleteByIdAsync(int id)
    {
        var request = new RestRequest($"{BasePath}/{id}", Method.Delete);
        var response = await _client.RestClient.ExecuteAsync(request);

        return response;
    }
    
    
}