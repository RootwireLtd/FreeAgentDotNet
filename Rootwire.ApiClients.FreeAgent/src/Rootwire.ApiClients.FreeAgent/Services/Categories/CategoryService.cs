using RestSharp;
using Rootwire.ApiClients.FreeAgent.Infrastructure.Public;
using Rootwire.ApiClients.FreeAgent.Models.Categories;

namespace Rootwire.ApiClients.FreeAgent.Services.Categories;

public class CategoryService
{
    private readonly IFreeAgentClient _client;
    public string BasePath => "/v2/categories";

    public CategoryService(IFreeAgentClient client)
    {
        _client = client;
    }
    
    // Create
    
    // GetOne
    
    // GetMany
    public async Task<RestResponse<CategoryListResponseModel>> GetAllAsync()
    {
        var request = new RestRequest(BasePath, Method.Get);

        var response = await _client.RestClient.ExecuteAsync<CategoryListResponseModel>(request);

        return response;
    }
    
    // Update 
    
    // Delete

    
    
    
}