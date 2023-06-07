namespace PhonesWebApplication.Models;

public class Cart
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public ApplicationUsers ApplicationUsers { get; set; }
    public ICollection<CartPhone>? CartPhones { get; set; }
}