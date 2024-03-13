using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Rootwire.ApiClients.FreeAgent.Entities.Contacts;

namespace Rootwire.ApiClients.FreeAgent.Models.Contacts;

public class ContactListResponseModel
{
    [JsonPropertyName("contacts")]
    public List<Contact> Contacts { get; set; }
}