﻿namespace Rootwire.ApiClients.FreeAgentTests;

public static partial class FreeAgentFixtures
{
  private const string InvoiceListJson = """
                                         { "invoices": [
                                           {
                                             "url":"https://api.freeagent.com/v2/invoices/1",
                                             "contact":"https://api.freeagent.com/v2/contacts/2",
                                             "dated_on":"2011-08-29",
                                             "due_on":"2011-09-28",
                                             "reference":"001",
                                             "currency":"GBP",
                                             "exchange_rate":"1.0",
                                             "net_value":"0.0",
                                             "sales_tax_value":"0.0",
                                             "total_value": "200.0",
                                             "paid_value": "50.0",
                                             "due_value": "150.0",
                                             "status":"Open",
                                             "long_status":"Open – due in about 1 month",
                                             "comments":"An example invoice comment.",
                                             "omit_header":false,
                                             "send_thank_you_emails":false,
                                             "send_reminder_emails":false,
                                             "send_new_invoice_emails": false,
                                             "bank_account": "https://api.freeagent.com/v2/bank_accounts/1",
                                             "always_show_bic_and_iban": false,
                                             "payment_terms_in_days":30,
                                             "ec_status":"EC Goods",
                                             "payment_methods": {
                                               "paypal": true,
                                               "stripe": false
                                             },
                                             "created_at":"2011-08-29T00:00:00Z",
                                             "updated_at":"2011-08-29T00:00:00Z"
                                           }
                                         ]}
                                         """;

  private const string InvoiceSingleJson = """

                                           """;
}