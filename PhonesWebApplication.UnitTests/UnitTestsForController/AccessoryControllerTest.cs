using PhonesWebApplicationMVC.Models;

namespace PhonesWebApplication.UnitTests.UnitTestsForController;

public class AccessoryControllerTest
{
    private Mock<ILogger<AccessoryController>> _loggerMock;
    private Mock<IAccessoryServices> _accessoryService;
    private AccessoryController _accessoryController;

    [SetUp]
    public void Setup()
    {
        _loggerMock = new Mock<ILogger<AccessoryController>>();
        _accessoryService = new Mock<IAccessoryServices>();
        _accessoryController = new AccessoryController(_loggerMock.Object, _accessoryService.Object);
    }

    [Test]
    public async Task Index_ReturnsViewWithAccessories_WhenCalled()
    {
        var accessory = new List<Accessory> { new Accessory(), new Accessory() };
        _accessoryService.Setup(service => service.GetAccessory()).ReturnsAsync(accessory);

        var result = await _accessoryController.Index();

        Assert.IsInstanceOf<ViewResult>(result);
        Assert.IsInstanceOf<List<AccessoryViewModel>>(((ViewResult)result).Model);
    }

    [Test]
    public async Task AddAccessory_ValidModelState_RedirectsToIndex()
    {
        var accesory = new AccessoryViewModel();
        
        var result = await _accessoryController.AddAccessory(accesory);

        var redirectToActionResult = (RedirectToActionResult)result;
        Assert.AreEqual("Index", redirectToActionResult.ActionName);
        Assert.AreEqual("Accessory", redirectToActionResult.ControllerName);
    }

    [Test]
    public async Task AddAccessory_InvalidModelState_ReturnsViewWithService()
    {
        var accesory = new AccessoryViewModel();
        _accessoryController.ModelState.AddModelError("ServiceName", "Service name is required.");
        
        var result = await _accessoryController.AddAccessory(accesory);
        
        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.IsInstanceOf<AccessoryViewModel>(viewResult.Model);
    }

    [Test]
    public async Task DeleteAccessory_RedirectsToIndex_WhenCalled()
    {
        var id = 1;
        
        var result = await _accessoryController.DeleteAccessory(id);
        
        var redirectToActionResult = (RedirectToActionResult)result;
        Assert.AreEqual("Index", redirectToActionResult.ActionName);
        Assert.AreEqual("Accessory", redirectToActionResult.ControllerName);
    }

    [Test]
    public async Task EditAccessory_ValidModelStateAndEditSuccess_RedirectsToIndex()
    {
        var id = 1; 
        var updateAccessory = new AccessoryViewModel
        {
            Id = id,
            AccessoryName = "Updated Accessory"
        };
        _accessoryService.Setup(s => s.UpdateAccessory(id, It.IsAny<Accessory>()))
            .ReturnsAsync(true); 
        
        var result = await _accessoryController.EditAccessory(id, updateAccessory);

        var redirectToActionResult = (RedirectToActionResult)result;
        Assert.AreEqual("Index", redirectToActionResult.ActionName);
        Assert.IsNull(redirectToActionResult.ControllerName);
    }

    [Test]
    public async Task EditAccessory_ValidModelStateAndEditNotFound_ReturnsNotFoundResult()
    {
        var id = 1;
        var accessory = new Accessory();
        var updatedAccessory = new AccessoryViewModel();
        _accessoryService.Setup(a => a.UpdateAccessory(id, accessory))
            .ReturnsAsync(false);
        
        var result = await _accessoryController.EditAccessory(id, updatedAccessory);
        Assert.IsInstanceOf<NotFoundResult>(result);
    }

    [Test]
    public async Task EditAccessory_InvalidModelState_SetsUpdatedAccessoryNameAndView()
    {
        var id = 3;
        var updatedAccessory = new AccessoryViewModel();
        var accessoryName = "Sample Accessory";
        var accessory = new Accessory() { AccessoryName = accessoryName };

        _accessoryService.Setup(accessory => accessory.GetAccessoryById(id)).ReturnsAsync(accessory);
        var result = await _accessoryController.EditAccessory(id, updatedAccessory);

        Assert.IsInstanceOf<NotFoundResult>(result);
    }
}