using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.FreeAgent.Entities.Contacts;

public class Contact
{
    [JsonPropertyName("url")]
    public Uri Url { get; set; }
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }
    [JsonPropertyName("organisation_name")]
    public string? OrganisationName { get; set; }
    [JsonPropertyName("active_projects_count")]
    public int? ActiveProjectsCount { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [JsonPropertyName("contact_name_on_invoices")]
    public bool? ContactNameOnInvoices { get; set; }
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("charge_sales_tax")]
    public string? ChargeSalesTax { get; set; }

    [JsonPropertyName("locale")] 
    public string Locale { get; set; } = "en";
    
    [JsonPropertyName("account_balance")]
    public string AccountBalance { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
    [JsonPropertyName("uses_contact_invoice_sequence")]
    public bool UsesContactInvoiceSequence { get; set; }
    [JsonPropertyName("emails_invoices_automatically")]
    public bool EmailsInvoicesAutomatically { get; set; }
    [JsonPropertyName("emails_payment_reminders")]
    public bool EmailsPaymentReminderes { get; set; }
    [JsonPropertyName("emails_thank_you_notes")]
    public bool EmailsThankYouNotes { get; set; }

    [JsonPropertyName("uses_contact_level_email_settings")]
    public bool UsesContactLevelEmailSettings { get; set; }

    public int GetResourceId()
    {
        var segments = Url.Segments;

        int.TryParse(segments[segments.Length - 1].TrimEnd('/'), out var resourceId);

        return resourceId;
    }
}