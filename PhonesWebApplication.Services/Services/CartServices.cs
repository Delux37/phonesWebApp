namespace PhonesWebApplication.Services.Services;

public class CartServices : ICartServices
{
    private readonly ApplicationDbContext _context;
    
    public CartServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Phone>> GetPhonesFromCart(int cartId)
    {
        var cart = await _context.Carts
            .Include(c => c.CartPhones)!
            .ThenInclude(cp => cp.Phone)
            .FirstOrDefaultAsync(c => c.Id == cartId);
        if (cart != null)
        {
            IEnumerable<Phone> phones = cart.CartPhones.Select(cp => cp.Phone);
            return phones;
        }
        
        return Enumerable.Empty<Phone>();
    }

    public async Task<bool> addPhoneToCart(int cartId, Phone phoneToAdd)
    {
        var cart = await _context.Carts.FindAsync(cartId);
        cart.CartPhones ??= new List<CartPhone>();

        bool phoneExistsInCart = cart.CartPhones.Any(cp => cp.PhoneId == phoneToAdd.Id);

        if (phoneExistsInCart)
        {
            return false;
        }

        var cartPhone = new CartPhone
        {
            PhoneId = phoneToAdd.Id,
            CartId = cart.Id,
            Phone = phoneToAdd,
            Cart = cart
        };

        cart.CartPhones.Add(cartPhone);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Buy(int cartId)
    {
        var cart = await _context.Carts.Include(c => c.CartPhones)
            .ThenInclude(cp => cp.Phone)
            .FirstOrDefaultAsync(c => c.Id == cartId);
        
        if (cart != null)
        {
            cart.CartPhones.Clear();
            await _context.SaveChangesAsync();
            return true;
        }

        return false;
    }

    public async Task<bool> RemovePhoneFromCart(int cartId, int phoneId)
    {
        var cart = await _context.Carts
            .Include(c => c.CartPhones)
            .FirstOrDefaultAsync(c => c.Id == cartId);

        if (cart != null)
        {
            var cartPhoneToRemove = cart.CartPhones.FirstOrDefault(cp => cp.PhoneId == phoneId);

            if (cartPhoneToRemove != null)
            {
                cart.CartPhones.Remove(cartPhoneToRemove);
                await _context.SaveChangesAsync();
                return true;
            }
        }
        return false;
    }
}