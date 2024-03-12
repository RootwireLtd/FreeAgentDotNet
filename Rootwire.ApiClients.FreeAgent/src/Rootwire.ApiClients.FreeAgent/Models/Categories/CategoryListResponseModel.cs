using System.Text.Json.Serialization;
using Rootwire.ApiClients.FreeAgent.Entities.Categories;

namespace Rootwire.ApiClients.FreeAgent.Models.Categories;

public class CategoryListResponseModel
{
    [JsonPropertyName("admin_expenses_categories")]
    public List<CategoryAdminExpenses> AdminExpenseCategories { get; set; }
    [JsonPropertyName("cost_of_sales_categories")]
    public List<CategoryCostOfSales> CostOfSalesCategories { get; set; }
    [JsonPropertyName("income_categories")] public List<CategoryIncome> IncomeCategories { get; set; }
    [JsonPropertyName("general_categories")] public List<CategoryGeneral> GeneralCategories { get; set; }
}