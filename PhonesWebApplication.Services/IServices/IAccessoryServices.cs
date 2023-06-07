namespace PhonesWebApplication.Services.IServices;

public interface IAccessoryServices
{
    Task<IEnumerable<Accessory>> GetAccessory();
    Task<bool> AddAccessory(Accessory accessory);
    Task<bool> DeleteAccessory(int id);
    Task<bool> UpdateAccessory(int id, Accessory updateAccessory);
    Task<Accessory?> GetAccessoryById(int id);
}