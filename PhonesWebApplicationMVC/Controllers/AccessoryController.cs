namespace PhonesWebApplicationMVC.Controllers;

[Authorize]
public class AccessoryController : Controller
{ 
    private readonly ILogger<AccessoryController> _logger;
    private readonly IAccessoryServices _accessoryServices;

    public AccessoryController(ILogger<AccessoryController> logger, IAccessoryServices accessoryServices)
    {
        _logger = logger;
        _accessoryServices = accessoryServices;
    }

    public async Task<IActionResult> Index()
    {
        var accessories = await _accessoryServices.GetAccessory();
        var accessoriesViewModel = accessories.Select(a => new AccessoryViewModel()
        {
            Id = a.Id,
            AccessoryName = a.AccessoryName,
            PhoneAccessories = a.PhoneAccessories
        }).ToList();
        return View(accessoriesViewModel);
    }

    [HttpGet]
    public IActionResult AddAccessory()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddAccessory(AccessoryViewModel accessoryViewModel)
    {
        if (ModelState.IsValid)
        {
            var accessory = new Accessory
            {
                Id = accessoryViewModel.Id,
                AccessoryName = accessoryViewModel.AccessoryName,
                PhoneAccessories = accessoryViewModel.PhoneAccessories
            };
            await _accessoryServices.AddAccessory(accessory);
            return RedirectToAction("Index", "Accessory");
        }
        return View(accessoryViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> EditAccessory(int id, AccessoryViewModel updateAccessory)
    {
        if (ModelState.IsValid)
        {
            var accessory = new Accessory
            {
                Id = updateAccessory.Id,
                AccessoryName = updateAccessory.AccessoryName,
                PhoneAccessories = updateAccessory.PhoneAccessories
            };
            var editResult = await _accessoryServices.UpdateAccessory(id, accessory);
            if (editResult)
            {
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        updateAccessory.AccessoryName = (await _accessoryServices.GetAccessoryById(id))?.AccessoryName;
        return View(updateAccessory);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteAccessory(int id)
    {
        await _accessoryServices.DeleteAccessory(id);
        return RedirectToAction("Index", "Accessory");
    }
}