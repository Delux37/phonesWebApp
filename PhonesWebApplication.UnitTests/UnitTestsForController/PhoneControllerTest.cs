using Microsoft.AspNetCore.Identity;
using PhonesWebApplicationMVC.Models;

namespace PhonesWebApplication.UnitTests.UnitTestsForController;

public class PhoneControllerTest
{
    private Mock<ILogger<PhoneController>> _loggerMock;
    private Mock<IPhoneServices> _phoneServiceMock;
    private PhoneController _phoneController;
    private Mock<ICartServices> _cartServicesMock;
    private Mock<UserManager<ApplicationUsers>> _userManagerMock;

    [SetUp]
    public void Setup()
    {
        _loggerMock = new Mock<ILogger<PhoneController>>();
        _phoneServiceMock = new Mock<IPhoneServices>();
        _phoneController = new PhoneController(_loggerMock.Object, _phoneServiceMock.Object, _userManagerMock.Object, _cartServicesMock.Object);
    }

    [Test]
    public async Task Index_ReturnsViewWithPhones_WhenCalled()
    {
        var phones = new List<Phone> { new Phone(), new Phone() };
        _phoneServiceMock.Setup(service => service.GetPhones()).ReturnsAsync(phones);

        var result = await _phoneController.Index(1, null, null, null, true);

        Assert.IsInstanceOf<ViewResult>(result);
    }

    [Test]
    public async Task AddPhone_ValidModelState_RedirectsToIndex()
    {
        var phone = new PhoneViewModel();

        var result = await _phoneController.AddPhone(phone);

        var redirectToActionResult = (RedirectToActionResult)result;
        Assert.AreEqual("Index", redirectToActionResult.ActionName);
        Assert.AreEqual("Phone", redirectToActionResult.ControllerName);
    }

    [Test]
    public async Task AddPhone_InvalidModelState_ReturnsViewWithPhone()
    {
        var phone = new PhoneViewModel();
        _phoneController.ModelState.AddModelError("PhoneName", "Phone name is required.");

        var result = await _phoneController.AddPhone(phone);
        
        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.IsInstanceOf<PhoneViewModel>(viewResult.Model);
    }

    [Test]
    public async Task DeletePhone_RedirectsToIndex()
    {
        var id = 1;
        
        var result = await _phoneController.DeletePhone(id);
        var redirectToActionResult = (RedirectToActionResult)result;
        
        Assert.AreEqual("Index", redirectToActionResult.ActionName);
        Assert.AreEqual("Phone", redirectToActionResult.ControllerName);
    }

    [Test]
    public async Task EditPhone_ValidModelStateAndEditSuccess_RedirectsToIndex()
    {
        var id = 1; 
        var updatePhone = new PhoneViewModel()
        {
            Id = id,
            PhoneName = "Updated Phone"
        };
        _phoneServiceMock.Setup(s => s.UpdatePhone(id, It.IsAny<Phone>()))
            .ReturnsAsync(true); 
        
        var result = await _phoneController.EditPhone(id, updatePhone);

        var redirectToActionResult = (RedirectToActionResult)result;
        Assert.AreEqual("Index", redirectToActionResult.ActionName);
        Assert.IsNull(redirectToActionResult.ControllerName);
    }

    [Test]
    public async Task EditPhone_InvalidModelState_SetsUpdatedPhoneNameAndView()
    {
        
        var id = 1;
        var updatedPhone = new PhoneViewModel();
        var phoneName = "Sample Phone";
        var phone = new Phone { PhoneName = phoneName };

        _phoneServiceMock.Setup(accessory => accessory.GetPhoneById(id)).ReturnsAsync(phone);
        var result = await _phoneController.EditPhone(id, updatedPhone);

        Assert.IsInstanceOf<NotFoundResult>(result);
    }
}