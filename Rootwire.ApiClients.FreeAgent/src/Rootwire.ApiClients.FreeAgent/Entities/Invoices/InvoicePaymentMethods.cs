using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.FreeAgent.Entities.Invoices;

public class InvoicePaymentMethods
{
    /// <summary>
    /// Payable online using Paypal
    /// </summary>
    [JsonPropertyName("paypal")] public bool Paypal { get; set; }
    /// <summary>
    /// Payable using a previously authorised GoCardless Direct Debit Mandate.
    /// </summary>
    [JsonPropertyName("gocardless_preauth")] public bool GoCardlessPreAuth { get; set; }
    /// <summary>
    /// Payable online using Stripe
    /// </summary>
    [JsonPropertyName("stripe")] public bool Stripe { get; set; }
}