using System.Text.Json.Serialization;
using Rootwire.ApiClients.FreeAgent.Services.Contacts;

namespace Rootwire.ApiClients.FreeAgent.Models.Contacts;

public class ContactCreateModel
{
    [JsonPropertyName("contact")] public ContactCreateOptions Contact { get; set; }

    public ContactCreateModel(ContactCreateOptions options)
    {
        Contact = options;
    }
}