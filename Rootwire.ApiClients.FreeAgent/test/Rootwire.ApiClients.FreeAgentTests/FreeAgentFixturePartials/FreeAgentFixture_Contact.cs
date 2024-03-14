namespace Rootwire.ApiClients.FreeAgentTests;

public static partial class FreeAgentFixtures
{
    public const string ContactListJson = """
                                          {
                                              "contacts": [
                                                  {
                                                      "url": "https://api.sandbox.freeagent.com/v2/contacts/151560",
                                                      "organisation_name": "Test Org 3",
                                                      "active_projects_count": 0,
                                                      "created_at": "2024-03-13T07:53:14.000Z",
                                                      "updated_at": "2024-03-13T07:53:14.000Z",
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
                                                  },
                                                  {
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
                                                  },
                                                  {
                                                      "url": "https://api.sandbox.freeagent.com/v2/contacts/149407",
                                                      "organisation_name": "TestOrg 2",
                                                      "active_projects_count": 0,
                                                      "created_at": "2024-03-12T09:01:05.000Z",
                                                      "updated_at": "2024-03-13T07:53:02.000Z",
                                                      "email": "test@test.com",
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
                                              ]
                                          }
                                          """;

    public const string ContactItemJson = """
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