namespace PhonesWebApplication.Models;

public class Phone
{
    public int Id { get; set; }
    public string PhoneName { get; set; }
    public ICollection<PhoneAccessory>? PhoneAccessories { get; set; }
    public ICollection<CartPhone>? CartPhones { get; set; }
    public string PhoneInfo { get; set; }
    public decimal Price { get; set; }
}