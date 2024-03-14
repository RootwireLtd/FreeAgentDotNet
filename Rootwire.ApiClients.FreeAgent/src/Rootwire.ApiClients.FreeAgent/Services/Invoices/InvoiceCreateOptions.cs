using System.Text.Json.Serialization;
using Rootwire.ApiClients.FreeAgent.Entities.Invoices;

namespace Rootwire.ApiClients.FreeAgent.Services.Invoices;

public class InvoiceCreateOptions
{
    
    // Required
    [JsonPropertyName("contact")] public required Uri Contact { get; set; }
    [JsonPropertyName("dated_on")] public required DateOnly DatedOn { get; set; }
    [JsonPropertyName("payment_terms_in_days")] public required int PaymentTermsInDays { get; set; }

    // Optional
    [JsonPropertyName("status")] public string? Status { get; set; }
    [JsonPropertyName("long_status")] public string? LongStatus { get; set; }
    
    [JsonPropertyName("project")] public Uri? Project { get; set; }
    [JsonPropertyName("property")] public Uri? Property { get; set; }

    [JsonPropertyName("include_timeslips")]
    public string? IncludeTimeSlips { get; set; } = null;
    [JsonPropertyName("include_expenses")] public string? IncludeExpenses { get; set; } = null;
    [JsonPropertyName("include_estimates")]
    public string? IncludeEstimates { get; set; } = null;
    [JsonPropertyName("reference")] public string? Reference { get; set; } = null;
    [JsonPropertyName("due_on")] public DateOnly? DueOn { get; set; }
    [JsonPropertyName("currency")] public string? Currency { get; set; } = null;
    
    // CIS
    [JsonPropertyName("cis_rate")] public string? CisRate { get; set; } = null;
    [JsonPropertyName("cis_deduction_rate")]
    public Decimal? CisDeductionRate { get; set; } = null;
    [JsonPropertyName("cis_deduction_suffered")]
    public Decimal? CisDeductionSuffered { get; set; } = null;
    
    [JsonPropertyName("comments")] public string? Comments { get; set; }
    
    // Flags
    
    [JsonPropertyName("send_new_invoice_emails")]
    public bool? SendNewInvoiceEmails { get; set; } = null;
    [JsonPropertyName("send_reminder_emails")]
    public bool? SendReminderEmails { get; set; } = null;

    [JsonPropertyName("send_thank_you_emails")]
    public bool? SendthankYouEmails { get; set; } = null;
    
    // 
    [JsonPropertyName("discount_percent")] public Decimal? DiscountPercent { get; set; } = null;
    [JsonPropertyName("contact_name")] public string? ContactName { get; set; } = null;

    [JsonPropertyName("client_contact_name")]
    public string? ClientContactName { get; set; } = null;

    [JsonPropertyName("payment_terms")] public string? PaymentTerms { get; set; } = null;
    [JsonPropertyName("po_reference")] public string? PoReference { get; set; } = null;
    [JsonPropertyName("bank_account")] public Uri? BankAccount { get; set; } = null;
    [JsonPropertyName("omit_header")] public bool? OmitHeader { get; set; } = null;

    [JsonPropertyName("show_project_name")]
    public bool? ShowProjectName { get; set; } = null;

    [JsonPropertyName("always_show_bic_and_iban")]
    public bool? AlwaysShowBicAndIban { get; set; } = null;

    [JsonPropertyName("ec_status")] public string? EcStatus { get; set; } = null;
    [JsonPropertyName("place_of_supply")] public string? PlaceOfSupply = null;
    [JsonPropertyName("net_value")] public Decimal? NetValue = null;
    [JsonPropertyName("exchange_rate")] public Decimal? ExchangeRate = null;

    [JsonPropertyName("involves_sales_tax")]
    public bool? InvolvesSalesTax = null;
    [JsonPropertyName("sales_tax_value")] public Decimal? SalesTaxValue { get; set; }
    [JsonPropertyName("second_sales_tax_value")] public Decimal? SecondSalesTaxValue { get; set; }
    [JsonPropertyName("total_value")] public Decimal? TotalValue { get; set; } = null;
    [JsonPropertyName("paid_value")] public Decimal? PaidValue { get; set; } = null;
    [JsonPropertyName("due_value")] public Decimal? DueValue { get; set; } = null;

    [JsonPropertyName("is_interim_uk_vat")]
    public bool? IsInterimUkVat { get; set; } = null;

    [JsonPropertyName("paid_on")] public DateOnly? PaidOn { get; set; } = null;
    [JsonPropertyName("written_off_date")] public DateOnly? WrittenOffDate { get; set; }
    [JsonPropertyName("recurrring_invoice")]
    public Uri? RecurringInvoice { get; set; }

    [JsonPropertyName("payment_url")] public Uri? PaymentUri { get; set; } = null;
    [JsonPropertyName("payment_methods")] public InvoicePaymentMethods? PaymentMethods { get; set; } = null;
    [JsonPropertyName("invoice_items")] private List<InvoiceItem?> InvoiceItems { get; set; } = null;








}