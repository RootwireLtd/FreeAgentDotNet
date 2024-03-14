using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.FreeAgent.Entities.Invoices;

public class Invoice
{
    [JsonPropertyName("url")]
    public Uri Url { get; set; }
    [JsonPropertyName("contact")]
    public Uri Contact { get; set; }
    [JsonPropertyName("dated_on")] public DateOnly DatedOn { get; set; }
    [JsonPropertyName("due_on")] public DateOnly DueOn { get; set; }
    [JsonPropertyName("reference")] public string Reference { get; set; }
    [JsonPropertyName("currency")] public string Currency { get; set; }
    [JsonPropertyName("exchange_rate")] public string ExchangeRate { get; set; }
    [JsonPropertyName("net_value")] public string NetValue { get; set; }
    [JsonPropertyName("sales_tax_value")] public string SalesTaxValue { get; set; }
    [JsonPropertyName("total_value")] public string TotalValue { get; set; }
    [JsonPropertyName("paid_value")] public string PaidValue { get; set; }
    [JsonPropertyName("due_value")] public string DueValue { get; set; }
    [JsonPropertyName("status")] public string Status { get; set; }
    [JsonPropertyName("long_status")] public string LongStatus { get; set; }
    [JsonPropertyName("comments")] public string Comments { get; set; }
    [JsonPropertyName("omit_header")] public bool OmitHeader { get; set; }
    [JsonPropertyName("send_thank_you_email")]
    public bool SendThankYouEmail { get; set; }
    [JsonPropertyName("send_reminder_emails")]
    public bool SendReminderEmails { get; set; }
    [JsonPropertyName("send_new_invoice_emails")]
    public bool SendNewInvoiceEmails { get; set; }
    [JsonPropertyName("bank_account")] public Uri BankAccount { get; set; }
    [JsonPropertyName("always_show_bic_and_iban")]
    public bool AlwaysShowBicAndIban { get; set; }
    [JsonPropertyName("ec_status")] public string EcStatus { get; set; }
    [JsonPropertyName("payment_methods")] public InvoicePaymentMethods PaymentMethods { get; set; }
    [JsonPropertyName("created_at")] public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; set; }
    
     // Required
    [JsonPropertyName("payment_terms_in_days")] public required int PaymentTermsInDays { get; set; }

    // Optional
    
    [JsonPropertyName("project")] public Uri? Project { get; set; }
    [JsonPropertyName("property")] public Uri? Property { get; set; }

    [JsonPropertyName("include_timeslips")]
    public string? IncludeTimeSlips { get; set; } = null;
    [JsonPropertyName("include_expenses")] public string? IncludeExpenses { get; set; } = null;
    [JsonPropertyName("include_estimates")]
    public string? IncludeEstimates { get; set; } = null;
    
    // CIS
    [JsonPropertyName("cis_rate")] public string? CisRate { get; set; } = null;
    [JsonPropertyName("cis_deduction_rate")]
    public Decimal? CisDeductionRate { get; set; } = null;
    [JsonPropertyName("cis_deduction_suffered")]
    public Decimal? CisDeductionSuffered { get; set; } = null;
    
    
    // Flags

    [JsonPropertyName("send_thank_you_emails")]
    public bool? SendthankYouEmails { get; set; } = null;
    
    // 
    [JsonPropertyName("discount_percent")] public Decimal? DiscountPercent { get; set; } = null;
    [JsonPropertyName("contact_name")] public string? ContactName { get; set; } = null;

    [JsonPropertyName("client_contact_name")]
    public string? ClientContactName { get; set; } = null;

    [JsonPropertyName("payment_terms")] public string? PaymentTerms { get; set; } = null;
    [JsonPropertyName("po_reference")] public string? PoReference { get; set; } = null;

    [JsonPropertyName("show_project_name")]
    public bool? ShowProjectName { get; set; } = null;
    
    

    [JsonPropertyName("involves_sales_tax")]
    public bool? InvolvesSalesTax = null;

    [JsonPropertyName("is_interim_uk_vat")]
    public bool? IsInterimUkVat { get; set; } = null;

    [JsonPropertyName("paid_on")] public DateOnly? PaidOn { get; set; } = null;
    [JsonPropertyName("written_off_date")] public DateOnly? WrittenOffDate { get; set; }
    [JsonPropertyName("recurrring_invoice")]
    public Uri? RecurringInvoice { get; set; }

    [JsonPropertyName("payment_url")] public Uri? PaymentUri { get; set; } = null;
    [JsonPropertyName("invoice_items")] private List<InvoiceItem?> InvoiceItems { get; set; } = null;
    
    
}