namespace PhonesWebApplication.Models;

public class CartPhone
{
    public int Id { get; set; }
    public int PhoneId { get; set; }
    public Phone Phone { get; set; }
    public int CartId { get; set; }
    public Cart Cart { get; set; }
}