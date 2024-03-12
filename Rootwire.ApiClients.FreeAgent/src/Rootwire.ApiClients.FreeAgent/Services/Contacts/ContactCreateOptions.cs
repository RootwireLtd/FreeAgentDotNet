using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.FreeAgent.Services.Contacts;

public class ContactCreateOptions
{
    // Contact Details
    
    [JsonPropertyName("first_name")] public string? FirstName { get; set; }
    [JsonPropertyName("last_name")] public string? LastName { get; set; }
    [JsonPropertyName("organisation_name")] public string? OrganisationName { get; set; }
    [JsonPropertyName("email")] public string? Email { get; set; }
    [JsonPropertyName("billing_email")] public string? BillingEmail { get; set; }
    [JsonPropertyName("phone_number")] public string? PhoneNumber { get; set; }
    [JsonPropertyName("mobile")] public string? MobileNumber { get; set; }
    
    // Invoicing Address
    [JsonPropertyName("address1")] public string? Address1 { get; set; }
    [JsonPropertyName("address2")] public string? Address2 { get; set; }
    [JsonPropertyName("address3")] public string? Address3 { get; set; }
    [JsonPropertyName("town")] public string? Town { get; set; }
    [JsonPropertyName("region")] public string? Region { get; set; }
    [JsonPropertyName("postcode")] public string? PostCode { get; set; }
    [JsonPropertyName("country")] public string? Country { get; set; }
    
    // Invoicing Options
    [JsonPropertyName("default_payment_terms_in_days")] public int? DefaultPaymentTermInDays { get; set; }
    [JsonPropertyName("uses_contact_level_email_settings")] public bool UsesContactLevelEmailSettings { get; set; } = false;

    [JsonPropertyName("uses_contact_invoice_sequence")]
    public bool UsesContactInvoiceSequence { get; set; } = false;

    [JsonPropertyName("contact_name_on_invoices")]
    public bool ContactNameOnInvoices { get; set; } = true;
    
    [JsonPropertyName("sales_tax_registration_number")] public string? SalesTaxRegistrationNumber { get; set; }
    [JsonPropertyName("locale")] public string Locale { get; set; } = "en";
}