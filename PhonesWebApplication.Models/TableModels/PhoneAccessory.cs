namespace PhonesWebApplication.Models;

public class PhoneAccessory
{
    public int Id { get; set; }
    public int PhoneId { get; set; }
    public Phone Phone { get; set; }
    public int AccessoryId { get; set; }
    public Accessory Accessory { get; set; }
}