namespace PhonesWebApplication.UnitTests.UnitTestsForServices;

public class PhoneServicesTests
{
    private ApplicationDbContext _context;
    private IPhoneServices _phoneServices;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _phoneServices = new PhoneServices(_context);
    }

    [TearDown]
    public void Teardown()
    {
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }

    [Test]
    public async Task AddPhones_ReturnsOkResult_WhenCalled()
    {
        var phone = new Phone { Id = 1, PhoneName = "Phone 1" };

        var result = await _phoneServices.AddPhones(phone);

        Assert.IsInstanceOf<bool>(result);
        Assert.IsTrue(result);
    }

    [Test]
    public async Task DeletePhone_ReturnsOkResult_WhenCalled()
    {
        var phone = new Phone { Id = 1, PhoneName = "Phone 1" };
        _context.Phones.Add(phone);
        await _context.SaveChangesAsync();

        var result = await _phoneServices.DeletePhone(phone.Id);

        Assert.IsInstanceOf<bool>(result);
        Assert.IsTrue(result);
        var deletedPhone = await _context.Phones.FindAsync(phone.Id);
        Assert.IsNull(deletedPhone);
    }

    [Test]
    public async Task UpdatePhone_WithValidId_ReturnsOkResult()
    {
        var phone = new Phone { Id = 1, PhoneName = "Phone 1" };
        _context.Phones.Add(phone);
        await _context.SaveChangesAsync();
        var updatedPhone = new Phone { Id = 1, PhoneName = "Updated Phone" };

        var result = await _phoneServices.UpdatePhone(phone.Id, updatedPhone);

        Assert.IsInstanceOf<bool>(result);
        Assert.IsTrue(result);
        var retrievedPhone = await _context.Phones.FindAsync(phone.Id);
        Assert.AreEqual(updatedPhone.PhoneName, retrievedPhone.PhoneName);
    }

    [Test]
    public async Task UpdatePhone_WithInvalidId_ReturnsNotFoundResult()
    {
        var invalidId = 999;
        var updatedPhone = new Phone { Id = 1, PhoneName = "Updated Phone" };

        var result = await _phoneServices.UpdatePhone(invalidId, updatedPhone);

        Assert.IsInstanceOf<bool>(result);
        Assert.IsFalse(result);
    }

    [Test]
    public async Task GetPhoneById_WithValidId_ReturnsPhone()
    {
        var phone = new Phone { Id = 1, PhoneName = "Phone 1" };
        _context.Phones.Add(phone);
        await _context.SaveChangesAsync();

        var result = await _phoneServices.GetPhoneById(phone.Id);

        Assert.IsInstanceOf<Phone>(result);
        Assert.AreEqual(phone, result);
    }

    [Test]
    public async Task GetPhoneById_WithInvalidId_ReturnsNull()
    {
        var invalidId = 999;

        var result = await _phoneServices.GetPhoneById(invalidId);

        Assert.IsNull(result);
    }
}