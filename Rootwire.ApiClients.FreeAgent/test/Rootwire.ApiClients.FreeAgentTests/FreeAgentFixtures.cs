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

        if (path == "v2/categories")
        {
            return """
                   {
                       "admin_expenses_categories": [
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/285",
                               "description": "Accommodation and Meals",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "285",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Travel and subsistence expenses",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/292",
                               "description": "Accountancy Fees",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "292",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Accountancy fees",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/288",
                               "description": "Advertising and Promotion",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "288",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Advertising and promotional costs",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/363",
                               "description": "Bank/Finance Charges",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "363",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Finance charges",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/359",
                               "description": "Books and Journals",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "359",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Stationery",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/335",
                               "description": "Business Entertaining",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "335",
                               "allowable_for_tax": false,
                               "tax_reporting_name": "Business entertaining",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/360",
                               "description": "Charitable Donations",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "360",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Charitable donations",
                               "auto_sales_tax_rate": "Outside of the scope of VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/278",
                               "description": "Childcare Vouchers",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "278",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Staff welfare",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/270",
                               "description": "Computer Hardware",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "270",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "IT and computer consumables",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/269",
                               "description": "Computer Software",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "269",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Computer software costs",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/293",
                               "description": "Consultancy Fees",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "293",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "General consultancy fees",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/372",
                               "description": "Corporation Tax Penalty",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "372",
                               "allowable_for_tax": false,
                               "tax_reporting_name": "Late payment of tax",
                               "auto_sales_tax_rate": "Outside of the scope of VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/294",
                               "description": "Formation Costs",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "294",
                               "allowable_for_tax": false,
                               "tax_reporting_name": "Other legal and professional fees",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/364",
                               "description": "Insurance",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "364",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Insurance",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/362",
                               "description": "Interest Payable",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "362",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Interest Payable and similar charges",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/273",
                               "description": "Internet & Telephone",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "273",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Telecommunications costs",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/291",
                               "description": "Leasing Payments",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "291",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Hire and leasing of other assets",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/290",
                               "description": "Legal and Professional Fees",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "290",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Legal fees",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/249",
                               "description": "Mileage",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "249",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Vehicle running costs",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/274",
                               "description": "Mobile Phone",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "274",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Telecommunications costs",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/283",
                               "description": "Motor Expenses",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "283",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Vehicle running costs",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/250",
                               "description": "Office Costs",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "250",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "General maintenance",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/271",
                               "description": "Office Equipment",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "271",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Consumable items",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/272",
                               "description": "Other Computer Costs",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "272",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Computer software costs",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/373",
                               "description": "PAYE/NI Penalty",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "373",
                               "allowable_for_tax": false,
                               "tax_reporting_name": "Late payment of tax",
                               "auto_sales_tax_rate": "Outside of the scope of VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/351",
                               "description": "Pension (Annuity)",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "351",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Staff pensions, defined contribution schemes",
                               "auto_sales_tax_rate": "Outside of the scope of VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/350",
                               "description": "Pension (Personal/Stakeholder)",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "350",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Staff pensions, defined contribution schemes",
                               "auto_sales_tax_rate": "Outside of the scope of VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/358",
                               "description": "Postage",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "358",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Postage costs",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/276",
                               "description": "Printing",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "276",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Printing costs",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/390",
                               "description": "Realized Currency Exchange Gain/Loss",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "390",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Gain (loss) on foreign currency transactions",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/251",
                               "description": "Rent",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "251",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Rent of premises",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/289",
                               "description": "Staff Entertaining",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "289",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Staff entertaining",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/282",
                               "description": "Staff Training",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "282",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Staff training",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/277",
                               "description": "Stationery",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "277",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Stationery",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/361",
                               "description": "Subscriptions",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "361",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Subscriptions to professional and trade bodies",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/280",
                               "description": "Sundries",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "280",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Sundry expenses",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/365",
                               "description": "Travel",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "365",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Travel and subsistence expenses",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/391",
                               "description": "Unrealized Currency Exchange Gain/Loss",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "391",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Gain (loss) on foreign currency transactions",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/366",
                               "description": "Use Of Home",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "366",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Use of residence for business purposes",
                               "auto_sales_tax_rate": "Zero rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/371",
                               "description": "VAT Penalty",
                               "group_description": "Admin expenses (normally Zero-VAT)",
                               "nominal_code": "371",
                               "allowable_for_tax": false,
                               "tax_reporting_name": "Late payment of tax",
                               "auto_sales_tax_rate": "Outside of the scope of VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/268",
                               "description": "Web Hosting",
                               "group_description": "Admin expenses (normally VATable)",
                               "nominal_code": "268",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Computer software costs",
                               "auto_sales_tax_rate": "Standard rate"
                           }
                       ],
                       "cost_of_sales_categories": [
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/102",
                               "description": "Commission Paid",
                               "group_description": "Cost of sales (normally VATable)",
                               "nominal_code": "102",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Commissions Payable",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/101",
                               "description": "Cost of Sales",
                               "group_description": "Cost of sales (normally VATable)",
                               "nominal_code": "101",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Purchases",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/104",
                               "description": "Equipment Hire",
                               "group_description": "Cost of sales (normally VATable)",
                               "nominal_code": "104",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Material Costs",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/103",
                               "description": "Materials",
                               "group_description": "Cost of sales (normally VATable)",
                               "nominal_code": "103",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Purchases",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/150",
                               "description": "Subcontractor Costs",
                               "group_description": "Cost of sales (normally VATable)",
                               "nominal_code": "150",
                               "allowable_for_tax": true,
                               "tax_reporting_name": "Subcontractor Costs",
                               "auto_sales_tax_rate": "Standard rate"
                           }
                       ],
                       "income_categories": [
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/001",
                               "description": "Sales",
                               "group_description": "Income (normally VATable)",
                               "nominal_code": "001",
                               "auto_sales_tax_rate": "Standard rate"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/002",
                               "description": "test",
                               "group_description": "Income (normally VATable)",
                               "nominal_code": "002",
                               "auto_sales_tax_rate": "Standard rate"
                           }
                       ],
                       "general_categories": [
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/051",
                               "description": "Interest Received",
                               "nominal_code": "051",
                               "tax_reporting_name": "Interest Received"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/055",
                               "description": "Flat Rate Scheme Surplus",
                               "nominal_code": "055",
                               "tax_reporting_name": "Turnover"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/056",
                               "description": "Refund of Other Tax Received",
                               "nominal_code": "056",
                               "tax_reporting_name": "Other Income"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/057",
                               "description": "PAYE/NI Online Filing Incentive Claimed",
                               "nominal_code": "057",
                               "tax_reporting_name": "Other Income"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/058",
                               "description": "Grant Income",
                               "nominal_code": "058",
                               "tax_reporting_name": "Other Income"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/401",
                               "description": "Salaries",
                               "nominal_code": "401",
                               "tax_reporting_name": "Wages and salaries"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/402",
                               "description": "Employer NICs",
                               "nominal_code": "402",
                               "tax_reporting_name": "Employer's National Insurance, staff"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/403",
                               "description": "Staff Pensions",
                               "nominal_code": "403",
                               "tax_reporting_name": "Staff pensions, defined contribution schemes"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/404",
                               "description": "Net Salary Expense",
                               "nominal_code": "404",
                               "tax_reporting_name": "Wages and salaries"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/405",
                               "description": "PAYE/NI Expense",
                               "nominal_code": "405",
                               "tax_reporting_name": "Wages and salaries"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/407",
                               "description": "Directors' Salaries",
                               "nominal_code": "407",
                               "tax_reporting_name": "Director's remuneration"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/408",
                               "description": "Directors' Employer NICs",
                               "nominal_code": "408",
                               "tax_reporting_name": "Employer's National Insurance, directors"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/409",
                               "description": "Directors' Staff Pensions",
                               "nominal_code": "409",
                               "tax_reporting_name": "Director pensions, defined contribution schemes"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/450",
                               "description": "Bad Debts Written Off",
                               "nominal_code": "450",
                               "tax_reporting_name": "Bad debts written off"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/460",
                               "description": "Depreciation Charge",
                               "nominal_code": "460",
                               "tax_reporting_name": "Depreciation of tangible fixed assets"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/461",
                               "description": "Loss/Gain on Disposal of Capital Asset",
                               "nominal_code": "461",
                               "tax_reporting_name": "Gain (loss) from disposal of tangible fixed assets"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/502",
                               "description": "Corporation Tax Expense",
                               "nominal_code": "502",
                               "tax_reporting_name": "Corporation tax"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/503",
                               "description": "Deferred Corporation Tax Expense",
                               "nominal_code": "503",
                               "tax_reporting_name": "Corporation tax"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/599",
                               "description": "Error",
                               "nominal_code": "599",
                               "tax_reporting_name": "Error"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/601",
                               "description": "Capital Asset Brought Forward",
                               "nominal_code": "601",
                               "tax_reporting_name": "Fixed assets brought forward"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/602",
                               "description": "Capital Asset Purchase",
                               "nominal_code": "602",
                               "tax_reporting_name": "Fixed asset purchases"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/604",
                               "description": "Disposal of Capital Asset",
                               "nominal_code": "604",
                               "tax_reporting_name": "Fixed asset disposals"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/605",
                               "description": "Capital Asset Depreciation Brought Forward",
                               "nominal_code": "605",
                               "tax_reporting_name": "Fixed asset depreciation brought forward"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/606",
                               "description": "Capital Asset Depreciation in Year",
                               "nominal_code": "606",
                               "tax_reporting_name": "Fixed asset depreciation in year"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/607",
                               "description": "Depreciation on Disposal of Capital Asset",
                               "nominal_code": "607",
                               "tax_reporting_name": "Fixed asset depreciation on disposals"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/610",
                               "description": "Stock Adjustment",
                               "nominal_code": "610",
                               "tax_reporting_name": "Stock"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/620",
                               "description": "Prepayments",
                               "nominal_code": "620",
                               "tax_reporting_name": "Prepayments and accrued income"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/630",
                               "description": "Investments Brought Forward",
                               "nominal_code": "630",
                               "tax_reporting_name": "Fixed asset investments"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/631",
                               "description": "Investments Additions",
                               "nominal_code": "631",
                               "tax_reporting_name": "Fixed asset investments"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/632",
                               "description": "Investments Revaluations",
                               "nominal_code": "632",
                               "tax_reporting_name": "Fixed asset investments"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/633",
                               "description": "Investments Disposals",
                               "nominal_code": "633",
                               "tax_reporting_name": "Fixed asset investments"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/650",
                               "description": "Provisions of Liabilities",
                               "nominal_code": "650",
                               "tax_reporting_name": "Provisions for liabilities"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/660",
                               "description": "Accruals",
                               "nominal_code": "660",
                               "tax_reporting_name": "Accruals and deferred income"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/670",
                               "description": "Share Premium",
                               "nominal_code": "670"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/681",
                               "description": "Trade Debtors",
                               "nominal_code": "681",
                               "tax_reporting_name": "Debtors"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/682",
                               "description": "Other Debtors",
                               "nominal_code": "682",
                               "tax_reporting_name": "Debtors"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/750",
                               "description": "Bank Account",
                               "nominal_code": "750",
                               "tax_reporting_name": "Bank account"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/760",
                               "description": "Unpresented Items",
                               "nominal_code": "760",
                               "tax_reporting_name": "Money in transit"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/761",
                               "description": "Bank Transfers in Progress",
                               "nominal_code": "761",
                               "tax_reporting_name": "Money in transit"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/790",
                               "description": "Credit Note Reconciliations",
                               "nominal_code": "790",
                               "tax_reporting_name": "Contra"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/794",
                               "description": "Liabilities < 1 Year",
                               "nominal_code": "794",
                               "tax_reporting_name": "Creditors due within one year"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/795",
                               "description": "Liabilities > 1 Year",
                               "nominal_code": "795",
                               "tax_reporting_name": "Creditors due in over one year"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/796",
                               "description": "Trade Creditors",
                               "nominal_code": "796",
                               "tax_reporting_name": "Creditors"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/797",
                               "description": "Other Creditors",
                               "nominal_code": "797",
                               "tax_reporting_name": "Creditors"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/798",
                               "description": "Non-Bill HP Liabilities < 1 Year",
                               "nominal_code": "798",
                               "tax_reporting_name": "Creditors due within one year"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/799",
                               "description": "Non-Bill HP Liabilities > 1 Year",
                               "nominal_code": "799",
                               "tax_reporting_name": "Creditors due in over one year"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/813",
                               "description": "Pension Creditor",
                               "nominal_code": "813",
                               "tax_reporting_name": "Creditors"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/814",
                               "description": "PAYE/NI",
                               "nominal_code": "814",
                               "tax_reporting_name": "Creditors"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/815",
                               "description": "Other Payroll Deductions",
                               "nominal_code": "815",
                               "tax_reporting_name": "Creditors"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/817",
                               "description": "VAT",
                               "nominal_code": "817",
                               "tax_reporting_name": "VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/818",
                               "description": "VAT Reclaimed",
                               "nominal_code": "818",
                               "tax_reporting_name": "VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/819",
                               "description": "VAT Charged",
                               "nominal_code": "819",
                               "tax_reporting_name": "VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/820",
                               "description": "Corporation Tax",
                               "nominal_code": "820",
                               "tax_reporting_name": "Corporation tax"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/823",
                               "description": "Deferred VAT",
                               "nominal_code": "823",
                               "tax_reporting_name": "VAT"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/824",
                               "description": "VAT Mini One Stop Shop",
                               "nominal_code": "824",
                               "tax_reporting_name": "Creditors"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/825",
                               "description": "Deferred Corporation Tax",
                               "nominal_code": "825",
                               "tax_reporting_name": "Corporation tax"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/900",
                               "description": "Smart User Payment",
                               "nominal_code": "900",
                               "tax_reporting_name": "Money due to/from user"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/901",
                               "description": "Capital Account",
                               "nominal_code": "901"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/902",
                               "description": "Salary and Bonuses",
                               "nominal_code": "902",
                               "tax_reporting_name": "Money due to/from user"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/904",
                               "description": "Benefit in Kind",
                               "nominal_code": "904",
                               "tax_reporting_name": "Money due to/from user"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/905",
                               "description": "Expense Account",
                               "nominal_code": "905",
                               "tax_reporting_name": "Money due to/from user"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/907",
                               "description": "Director Loan Account",
                               "nominal_code": "907",
                               "tax_reporting_name": "Money due to/from user"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/908",
                               "description": "Dividend",
                               "nominal_code": "908"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/910",
                               "description": "Unpaid Shares",
                               "nominal_code": "910",
                               "tax_reporting_name": "Called up share capital not paid"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/968",
                               "description": "Profit and Loss",
                               "nominal_code": "968"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/998",
                               "description": "Contra Account",
                               "nominal_code": "998",
                               "tax_reporting_name": "Contra"
                           },
                           {
                               "url": "https://api.sandbox.freeagent.com/v2/categories/999",
                               "description": "Suspense Account",
                               "nominal_code": "999",
                               "tax_reporting_name": "Suspense"
                           }
                       ]
                   }
                   """;
        }
        else
        {
            throw new Exception("Fixture not found");
        }
    }
}