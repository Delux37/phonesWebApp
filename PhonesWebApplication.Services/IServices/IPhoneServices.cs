using Microsoft.AspNetCore.Http;

namespace PhonesWebApplication.Services.IServices;

public interface IPhoneServices
{
    Task<IEnumerable<Phone>> GetPhones();
    Task<bool> AddPhones(Phone phone);
    Task<bool> DeletePhone(int id);
    Task<bool> UpdatePhone(int id, Phone updatePhone);
    Task<Phone> GetPhoneById(int id);
}