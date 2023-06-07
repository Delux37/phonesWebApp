namespace PhonesWebApplicationMVC.Controllers;

public class CartController : Controller
{
    private readonly ILogger<PhoneController> _logger;
    private readonly UserManager<ApplicationUsers> _userManager;
    private readonly ICartServices _cartServices;

    public CartController(ILogger<PhoneController> logger, UserManager<ApplicationUsers> userManager,
        ICartServices cartServices)
    {
        _logger = logger;
        _cartServices = cartServices;
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Index(string userName)
    {
        var user = await _userManager.FindByNameAsync(userName);
        var cartId = user.CartId;
        var phones = await _cartServices.GetPhonesFromCart(cartId);

        var phonesViewModel = phones.Select(p => new PhoneViewModel()
        {
            Id = p.Id,
            PhoneName = p.PhoneName,
            PhoneAccessories = p.PhoneAccessories,
            PhoneInfo = p.PhoneInfo,
            Price = p.Price,
            CartPhones = p.CartPhones
        });
        return View(phonesViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> BuyEverything(string userName)
    {
        var user = await _userManager.FindByNameAsync(userName);
        var cartId = user.CartId;
        await _cartServices.Buy(cartId);

        return RedirectToAction("SuccessfullyBought", "Cart");
    }

    [HttpGet]
    public async Task<IActionResult> SuccessfullyBought()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> RemovePhoneFromCart(int phoneId, string userName)
    {
        var user = await _userManager.FindByNameAsync(userName);
        var cartId = user.CartId;
        await _cartServices.RemovePhoneFromCart(cartId, phoneId);

        return RedirectToAction("Index", "Home");
    }
}