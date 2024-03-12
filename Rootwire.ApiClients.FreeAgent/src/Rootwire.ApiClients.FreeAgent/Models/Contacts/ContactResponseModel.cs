using System.Text.Json.Serialization;
using Rootwire.ApiClients.FreeAgent.Entities.Contacts;

namespace Rootwire.ApiClients.FreeAgent.Models.Contacts;

public class ContactResponseModel
{
    [JsonPropertyName("contact")]
    public Contact Contact { get; set; }
}