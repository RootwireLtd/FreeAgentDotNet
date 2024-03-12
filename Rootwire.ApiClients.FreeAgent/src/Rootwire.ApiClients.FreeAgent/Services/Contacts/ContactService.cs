using System.Text.Json;
using RestSharp;
using Rootwire.ApiClients.FreeAgent.Entities.Contacts;
using Rootwire.ApiClients.FreeAgent.Infrastructure.Public;
using Rootwire.ApiClients.FreeAgent.Models.Contacts;

namespace Rootwire.ApiClients.FreeAgent.Services.Contacts;

public class ContactService
{
    private readonly IFreeAgentClient _client;
    public string BasePath => "/v2/contacts";


    public ContactService(IFreeAgentClient client)
    {
        _client = client;
    }
    
    public async Task<RestResponse<ContactResponseModel>> CreateAsync(ContactCreateOptions createOptions)
    {
        var request = new RestRequest(BasePath, Method.Post);
        ContactCreateModel contactCreateModel = new ContactCreateModel(createOptions);

        var payload = JsonSerializer.Serialize(contactCreateModel);
        request.AddJsonBody(payload);

        var response = await _client.RestClient.ExecuteAsync<ContactResponseModel>(request);

        return response;
    }

    public async Task<RestResponse<ContactResponseModel>> GetByIdAsync(int id)
    {
        var request = new RestRequest($"{BasePath}/{id}", Method.Get);

        var response = await _client.RestClient.ExecuteAsync<ContactResponseModel>(request);

        return response;
    }

    public async Task<RestResponse<ContactListResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<RestResponse<ContactResponseModel>> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
    
}