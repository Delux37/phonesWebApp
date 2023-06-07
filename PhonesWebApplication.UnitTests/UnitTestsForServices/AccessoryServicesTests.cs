namespace PhonesWebApplication.UnitTests.UnitTestsForServices;

public class AccessoryServicesTests
{
    private ApplicationDbContext _context;
    private IAccessoryServices _accessoryServices;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _context = new ApplicationDbContext(options);
        _accessoryServices = new AccessoryServices(_context);
    }

    [Test]
    public async Task AddAccessory_ReturnsOkResult_WhenCalled()
    {
        var accessory = new Accessory{ Id = 1, AccessoryName = "Service 1" };

        var result = await _accessoryServices.AddAccessory(accessory);

        Assert.IsInstanceOf<bool>(result);
        Assert.IsTrue(result);
    }

    [Test]
    public async Task DeleteAccessory_ReturnsOkResult_WhenCalled()
    {
        var accessory = new Accessory { Id = 2, AccessoryName = "Service 2" };
        _context.Accessories.Add(accessory);
        await _context.SaveChangesAsync();

        var result = await _accessoryServices.DeleteAccessory(accessory.Id);

        Assert.IsInstanceOf<bool>(result);
        Assert.IsTrue(result);
        var deletedAccessory = await _context.Accessories.FindAsync(accessory.Id);
        Assert.IsNull(deletedAccessory);
    }

    [Test]
    public async Task UpdateAccessory_WithValidId_ReturnsOkResult()
    {
        var accessory = new Accessory() { Id = 5, AccessoryName = "Phone 1" };
        _context.Accessories.Add(accessory);
        await _context.SaveChangesAsync();
        var updatedAccessory = new Accessory() { Id = 1, AccessoryName = "Updated Service" };

        var result = await _accessoryServices.UpdateAccessory(accessory.Id, updatedAccessory);

        Assert.IsInstanceOf<bool>(result);
        Assert.IsTrue(result);
        var retrievedAccessory = await _context.Accessories.FindAsync(accessory.Id);
        Assert.AreEqual(updatedAccessory.AccessoryName, retrievedAccessory.AccessoryName);
    }

    [Test]
    public async Task UpdateAccessory_WithInvalidId_ReturnsNotFoundResult()
    {
        var invalidId = 999;
        var updatedAccessory = new Accessory{ Id = 1, AccessoryName = "Updated Service" };

        var result = await _accessoryServices.UpdateAccessory(invalidId, updatedAccessory);

        Assert.IsInstanceOf<bool>(result);
        Assert.IsTrue(result is false);
    }

    [Test]
    public async Task GetAccessoryById_WithValidId_ReturnsService()
    {
        var accessory = new Accessory { Id = 4, AccessoryName = "Phone 1" };
        _context.Accessories.Add(accessory);
        await _context.SaveChangesAsync();

        var result = await _accessoryServices.GetAccessoryById(accessory.Id);
        var resultValue = result;

        Assert.IsInstanceOf<Accessory>(result);
        Assert.AreEqual(accessory, resultValue);
    }

    [Test]
    public async Task GetAccessoryById_WithInvalidId_ReturnsNull()
    {
        var invalidId = 999;

        var result = await _accessoryServices.GetAccessoryById(invalidId);
        var resultValue = result;

        Assert.IsNull(resultValue);
    }
}