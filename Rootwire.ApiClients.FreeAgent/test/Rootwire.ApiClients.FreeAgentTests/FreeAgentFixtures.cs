using Xunit.Sdk;

namespace Rootwire.ApiClients.FreeAgentTests;

public static class FreeAgentFixtures
{
    public static string GetFixture(string path)
    {
        if (path == "v2/contacts/145970")
        {
            return """
                   {
                       "contact": {
                           "url": "https://api.sandbox.freeagent.com/v2/contacts/145970",
                           "organisation_name": "TESTORG - KEEP THIS",
                           "active_projects_count": 0,
                           "created_at": "2024-03-11T17:40:27.000Z",
                           "updated_at": "2024-03-11T17:47:55.000Z",
                           "contact_name_on_invoices": true,
                           "country": "United Kingdom",
                           "charge_sales_tax": "Auto",
                           "locale": "en",
                           "account_balance": "0.0",
                           "status": "Active",
                           "uses_contact_invoice_sequence": false,
                           "emails_invoices_automatically": false,
                           "emails_payment_reminders": false,
                           "emails_thank_you_notes": false,
                           "uses_contact_level_email_settings": false
                       }
                   }
                   """;
        }
        else
        {
            throw new Exception("Fixture not found");
        }
    }
}