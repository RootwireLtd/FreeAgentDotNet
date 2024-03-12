using System.Text.Json;
using Rootwire.ApiClients.FreeAgent.Models.Categories;
using Rootwire.ApiClients.FreeAgent.Models.Contacts;

namespace Rootwire.ApiClients.FreeAgentTests.Entities.Categories;

public class CategoryTest : BaseFreeAgentTest
{
    [Fact]
    public void Deserialize()
    {
        string json = this.GetFixture("v2/categories");

        JsonElement jsonElement = JsonDocument.Parse(json).RootElement;

        CategoryListResponseModel categoryListResponseModel = System.Text.Json.JsonSerializer.Deserialize<CategoryListResponseModel>(jsonElement);

        Assert.NotNull(categoryListResponseModel);
        Assert.IsType<CategoryListResponseModel>(categoryListResponseModel);
        Assert.NotNull(categoryListResponseModel.GeneralCategories);
        Assert.NotNull(categoryListResponseModel.IncomeCategories);
        Assert.NotNull(categoryListResponseModel.AdminExpenseCategories);
        Assert.NotNull(categoryListResponseModel.CostOfSalesCategories);
        Assert.Equal(67, categoryListResponseModel.GeneralCategories.Count);
        Assert.Equal(2, categoryListResponseModel.IncomeCategories.Count);
        Assert.Equal(41, categoryListResponseModel.AdminExpenseCategories.Count);
        Assert.Equal(5, categoryListResponseModel.CostOfSalesCategories.Count);
    }
}