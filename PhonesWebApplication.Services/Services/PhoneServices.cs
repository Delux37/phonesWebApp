using Microsoft.AspNetCore.Http;

namespace PhonesWebApplication.Services.Services;

public class PhoneServices : IPhoneServices
{
    private readonly ApplicationDbContext _context;
    
    public PhoneServices(ApplicationDbContext context)
    {
        _context = context;
    } 
    
    public async Task<IEnumerable<Phone>> GetPhones()
    {
        return await _context.Phones.ToListAsync();
    }

    public async Task<bool> AddPhones(Phone item)
    {
        try
        {
            _context.Phones.Add(item);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding phone: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> DeletePhone(int id)
    {
        var phone = await _context.Phones.FindAsync(id);
        if (phone == null)
        {
            return false;
        }
        try
        {
            _context.Phones.Remove(phone);
            await _context.SaveChangesAsync();
            return true;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error adding accessory: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> UpdatePhone(int id, Phone updatedPhone)
    {
        var phone = await _context.Phones.FindAsync(id);
        if (phone == null)
        {
            return false;
        }
        phone.PhoneName = updatedPhone.PhoneName;
        phone.PhoneInfo = updatedPhone.PhoneInfo;
        phone.Price = updatedPhone.Price;
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

    

    public async Task<Phone> GetPhoneById(int id)
    {
        return await _context.Phones.FindAsync(id);
    }
}