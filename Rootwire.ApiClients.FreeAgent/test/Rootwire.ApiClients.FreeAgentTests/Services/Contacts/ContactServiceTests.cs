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
    public async Task GetById()
    {
        var response = await _service.GetByIdAsync(145970);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("TESTORG - KEEP THIS", response.Data.Contact.OrganisationName);
    }
    
    
    [Fact]
    public async Task GetAll()
    {
        var response = await _service.GetAllAsync();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(response.Data.Contacts);
        Assert.NotEmpty(response.Data.Contacts);
    }

    [Fact]
    public async Task Create()
    {
        var contactResponseModel = await _service.CreateAsync(_createOptions);
        Assert.NotNull(contactResponseModel);
        Assert.Equal(HttpStatusCode.Created, contactResponseModel.StatusCode);
    }

}