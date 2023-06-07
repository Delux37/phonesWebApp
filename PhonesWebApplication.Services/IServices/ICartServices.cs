namespace PhonesWebApplication.Services.IServices;

public interface ICartServices
{
    Task<IEnumerable<Phone>> GetPhonesFromCart(int cartId);
    Task<bool> Buy(int cartId);
    Task<bool> RemovePhoneFromCart(int id, int phoneId);
    Task<bool> addPhoneToCart(int cartId, Phone phoneToAdd);
}