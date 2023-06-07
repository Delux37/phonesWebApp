namespace PhonesWebApplication.Models;

public class Accessory
{
    public int Id { get; set; }
    public string AccessoryName { get; set; }
    public ICollection<PhoneAccessory>? PhoneAccessories { get; set; }
    public decimal Amount { get; set; }
    public string AccessoryInfo { get; set; }
}