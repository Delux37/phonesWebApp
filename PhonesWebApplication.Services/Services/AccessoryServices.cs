namespace PhonesWebApplication.Services.Services;

public class AccessoryServices : IAccessoryServices
{
    private readonly ApplicationDbContext _context;

    public AccessoryServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Accessory>> GetAccessory()
    {
        return await _context.Accessories.ToListAsync();
    }

    public async Task<bool> AddAccessory(Accessory accessory)
    {
        try
        {
            _context.Accessories.Add(accessory);
            await _context.SaveChangesAsync();
            return true;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error adding accessory: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> DeleteAccessory(int id)
    {
        var accessory = await _context.Accessories.FindAsync(id);
        if (accessory == null)
        {
            return false;
        }
        try
        {
            _context.Remove(accessory);
            await _context.SaveChangesAsync();
            return true;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error adding accessory: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> UpdateAccessory(int id, Accessory updateAccessory)
    {
        var accessory = await _context.Accessories.FindAsync(id);
        if (accessory == null)
        {
            return false;
        }
        accessory.AccessoryName = updateAccessory.AccessoryName;
        try
        {
            await _context.SaveChangesAsync();
            return true;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error adding accessory: {ex.Message}");
            return false;
        }
    }

    public async Task<Accessory?> GetAccessoryById(int id)
    {
        var accessory = await _context.Accessories.FindAsync(id);
        if (accessory == null)
        {
            return null;
        }
        return accessory;
    }
}