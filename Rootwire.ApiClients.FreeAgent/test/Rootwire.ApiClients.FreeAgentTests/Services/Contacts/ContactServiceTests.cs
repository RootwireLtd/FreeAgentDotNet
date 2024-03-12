using System.Net;
using Rootwire.ApiClients.FreeAgent.Services.Contacts;

namespace Rootwire.ApiClients.FreeAgentTests.Services.Contacts;

public class ContactServiceTests : BaseFreeAgentTest
{
    private const int ContactId = 145970;

    private readonly ContactService _service;
    private readonly ContactCreateOptions _createOptions;

    public ContactServiceTests()
    {
        _service = new ContactService(FreeAgentClient);
        
        _createOptions = new ContactCreateOptions
        {
            OrganisationName = "TestOrg",
            Email = "test@test.com",
        };
    }

    [Fact]
    public async Task Create()
    {
        var contactResponseModel = await _service.CreateAsync(_createOptions);
        Assert.NotNull(contactResponseModel);
        Assert.Equal(HttpStatusCode.Created, contactResponseModel.StatusCode);
    }


}