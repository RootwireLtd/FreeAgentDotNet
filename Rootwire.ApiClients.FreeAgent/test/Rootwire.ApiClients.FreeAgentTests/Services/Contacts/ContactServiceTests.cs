using System.Net;
using Rootwire.ApiClients.FreeAgent.Services.Contacts;

namespace Rootwire.ApiClients.FreeAgentTests.Services.Contacts;

public class ContactSharedData
{
    public int TestContactIdValue;
}

public class ContactSharedDataFixture : IClassFixture<ContactSharedData>
{
    public ContactSharedData Data { get; private set; }

    public ContactSharedDataFixture()
    {
        Data = new ContactSharedData();
    }
}

public class ContactServiceTests : BaseFreeAgentTest, IClassFixture<ContactSharedDataFixture>
{
    private readonly ContactService _service;
    private readonly ContactCreateOptions _createOptions;

    private ContactSharedDataFixture _contactSharedDataFixture;

    public ContactServiceTests(ContactSharedDataFixture sharedDataContactSharedDataFixture)
    {
        _service = new ContactService(FreeAgentClient);
        
        _createOptions = new ContactCreateOptions
        {
            OrganisationName = "TestOrg - Made By Test - Delete this",
            Email = "test@test.com",
        };

        _contactSharedDataFixture = sharedDataContactSharedDataFixture;
    }
    
    [Fact]
    public async Task Create()
    {
        var contactResponseModel = await _service.CreateAsync(_createOptions);
        Assert.NotNull(contactResponseModel);
        Assert.Equal(HttpStatusCode.Created, contactResponseModel.StatusCode);

        _contactSharedDataFixture.Data.TestContactIdValue = contactResponseModel.Data.Contact.GetResourceId();
    }
    
    [Fact]
    public async Task GetById()
    {
        var response = await _service.GetByIdAsync(_contactSharedDataFixture.Data.TestContactIdValue);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("TestOrg - Made By Test - Delete this", response.Data.Contact.OrganisationName);
        Assert.Equal("test@test.com", response.Data.Contact.Email);
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
    public async Task Delete()
    {
        // Create resource to be deleted
        
        var contactResponseModel = await _service.CreateAsync(_createOptions);
        Assert.NotNull(contactResponseModel);
        Assert.Equal(HttpStatusCode.Created, contactResponseModel.StatusCode);

        var resourcetoDeleteId = contactResponseModel.Data.Contact.GetResourceId();
        
        // Confirm resource is found
        
        var getBeforeDeleteResponse = await _service.GetByIdAsync(resourcetoDeleteId);
        Assert.Equal(HttpStatusCode.OK, getBeforeDeleteResponse.StatusCode);
        Assert.Equal("TestOrg - Made By Test - Delete this", getBeforeDeleteResponse.Data.Contact.OrganisationName);
        Assert.Equal("test@test.com", getBeforeDeleteResponse.Data.Contact.Email);
        
        // Delete resource
        
        var deleteResponse = await _service.DeleteAsync(resourcetoDeleteId);
        
        Assert.Equal(HttpStatusCode.OK, deleteResponse.StatusCode);
        
        var getAfterDeleteResponse = await _service.GetByIdAsync(resourcetoDeleteId);
        Assert.Equal(HttpStatusCode.NotFound, getAfterDeleteResponse.StatusCode);
        
        
    }

}