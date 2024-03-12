﻿using System.Text.Json;
using Rootwire.ApiClients.FreeAgent.Entities.Contacts;
using Rootwire.ApiClients.FreeAgent.Models.Contacts;

namespace Rootwire.ApiClients.FreeAgentTests.Entities.Contacts;

public class ContactTest : BaseFreeAgentTest
{

    [Fact]
    public void Deserialize()
    {
        string json = this.GetFixture("v2/contacts/145970");

        JsonElement jsonElement = JsonDocument.Parse(json).RootElement;

        ContactResponseModel contactResponseModel = System.Text.Json.JsonSerializer.Deserialize<ContactResponseModel>(jsonElement);

        Assert.NotNull(contactResponseModel);
        Assert.IsType<ContactResponseModel>(contactResponseModel);
        Assert.NotNull(contactResponseModel.Contact.Url);
        Assert.Equal(145970, contactResponseModel.Contact.GetResourceId());
    }
}