namespace Rootwire.ApiClients.FreeAgentTests;

public static partial class FreeAgentFixtures
{
    public static string GetFixture(string path)
    {
        if (path == "v2/contacts/145970")
        {
            return ContactItemJson;
        }

        if (path == "v2/contacts/")
        {
            return ContactListJson;
        }

        if (path == "v2/categories")
        {
            return CategoryListJson;
        }

        if (path == "v2/invoices")
        {
            return InvoiceListJson;
        }
        else
        {
            throw new Exception("Fixture not found");
        }
    }
}