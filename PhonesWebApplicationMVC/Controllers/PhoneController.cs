namespace PhonesWebApplicationMVC.Controllers;

[Authorize]
public class PhoneController : Controller
{
    private readonly ILogger<PhoneController> _logger;
    private readonly IPhoneServices _phoneService;
    private readonly UserManager<ApplicationUsers> _userManager;
    private readonly ICartServices _cartServices;
    
    public PhoneController(ILogger<PhoneController> logger, IPhoneServices phoneService,
        UserManager<ApplicationUsers> userManager, ICartServices cartServices)
    {
        _logger = logger;
        _phoneService = phoneService;
        _cartServices = cartServices;
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Index(int? page, string? searchWord, decimal? minAmount, decimal? maxAmount, bool? sortBy)
    {
        var phones = await _phoneService.GetPhones();

        if (!string.IsNullOrEmpty(searchWord))
        {
            phones = phones.Where(p => p.PhoneName.Contains(searchWord));
            ViewBag.SearchWord = searchWord;
        }

        if (minAmount != null)
        {
            phones = phones.Where(p => p.Price >= minAmount);
            ViewBag.MinAmount = minAmount;
        }

        if (maxAmount != null)
        {
            phones = phones.Where(p => p.Price <= maxAmount);
            ViewBag.MaxAmount = maxAmount;
        }
        
        if (sortBy != null)
        {
            phones = sortBy switch
            {
                true => phones.OrderBy(p => p.Price),
                false => phones.OrderByDescending(p => p.Price),
                _ => phones
            };
            ViewBag.SortBy = sortBy;
        }
        
        int totalPhones = phones.Count();
        int totalPages = (int)Math.Ceiling((double)totalPhones / 16);
        int currentPage = page ?? 1;
        currentPage = Math.Max(1, Math.Min(currentPage, totalPages));
        int startIndex = (currentPage - 1) * 16;
        var phonesOnCurrentPage = phones.Skip(startIndex).Take(16);

        var phoneViewModel = phonesOnCurrentPage.Select(p => new PhoneViewModel
        {
            Id = p.Id,
            PhoneName = p.PhoneName,
            PhoneAccessories = p.PhoneAccessories,
            Price = p.Price
        });
    
        ViewBag.Page = currentPage;
        ViewBag.TotalPages = totalPages;

        
        return View(phoneViewModel);
    }

    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> AddPhone(PhoneViewModel phoneViewModel)
    {
        if (ModelState.IsValid)
        {
            
            var phone = new Phone
            {
                Id = phoneViewModel.Id,
                PhoneName = phoneViewModel.PhoneName,
                PhoneAccessories = phoneViewModel.PhoneAccessories,
                PhoneInfo = phoneViewModel.PhoneInfo,
                Price = phoneViewModel.Price
            };
            await _phoneService.AddPhones(phone);
            return RedirectToAction("Index", "Phone");
        }

        return View(phoneViewModel);
    }

    [HttpGet]
    [Authorize(Roles = "admin")]
    public IActionResult AddPhone()
    {
        return View();
    }

    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> DeletePhone(int id)
    {
        await _phoneService.DeletePhone(id);
        return RedirectToAction("Index", "Phone");
    }

    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> EditPhone(int id, PhoneViewModel updatedPhone)
    {
        if (ModelState.IsValid)
        {
            var phone = new Phone
            {
                Id = updatedPhone.Id,
                PhoneName = updatedPhone.PhoneName,
                PhoneAccessories = updatedPhone.PhoneAccessories,
                Price = updatedPhone.Price,
                PhoneInfo = updatedPhone.PhoneInfo
            };
            var editResult = await _phoneService.UpdatePhone(id, phone);
            if (editResult)
            {
                return RedirectToAction("Index");
            }

            if (!editResult)
            {
                return NotFound();
            }
        }
        else
        {
            updatedPhone.PhoneName = _phoneService.GetPhoneById(id).Result.PhoneName;
            updatedPhone.PhoneInfo = _phoneService.GetPhoneById(id).Result.PhoneInfo;
            updatedPhone.Price = _phoneService.GetPhoneById(id).Result.Price;
        }

        return View(updatedPhone);
    }
    
    [HttpGet]
    public async Task<IActionResult> ViewDetails(int id, PhoneViewModel updatedPhone)
    {
        var phone = await _phoneService.GetPhoneById(id);

        if (phone == null)
        {
            return NotFound();
        }

        // Update the properties of the updatedPhone parameter with the retrieved phone details
        updatedPhone.Id = phone.Id;
        updatedPhone.PhoneName = phone.PhoneName;
        updatedPhone.PhoneAccessories = phone.PhoneAccessories;
        updatedPhone.PhoneInfo = phone.PhoneInfo;
        updatedPhone.Price = phone.Price;

        return View(updatedPhone);
    }

    [HttpPost]
    public async Task<IActionResult> AddPhoneToCart(string userId, int phoneId)
    {
        var user = await _userManager.FindByNameAsync(userId);
        if (user == null)
        {
            return NotFound();
        }

        var phone = await _phoneService.GetPhoneById(phoneId);
        if (phone == null)
        {
            return NotFound();
        }

        await _cartServices.addPhoneToCart(user.CartId, phone);
        return RedirectToAction("Index", "Phone");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}