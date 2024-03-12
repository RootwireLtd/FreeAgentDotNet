using System.Net;
using Rootwire.ApiClients.FreeAgent.Services.Categories;

namespace Rootwire.ApiClients.FreeAgentTests.Services.Categories;

public class CategoryServiceTests : BaseFreeAgentTest
{
    private const int ContactId = 145970;

    private readonly CategoryService _service;

    public CategoryServiceTests()
    {
        _service = new CategoryService(FreeAgentClient);
    }
    
    [Fact]
    public async Task GetAll()
    {
        var response = await _service.GetAllAsync();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(response.Data.GeneralCategories);
        Assert.NotNull(response.Data.IncomeCategories);
        Assert.NotNull(response.Data.AdminExpenseCategories);
        Assert.NotNull(response.Data.CostOfSalesCategories);
        Assert.NotEqual(0, response.Data.GeneralCategories.Count);
        Assert.NotEqual(0, response.Data.IncomeCategories.Count);
        Assert.NotEqual(0, response.Data.AdminExpenseCategories.Count);
        Assert.NotEqual(0, response.Data.CostOfSalesCategories.Count);
    }
}