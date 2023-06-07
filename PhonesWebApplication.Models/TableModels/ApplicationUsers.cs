namespace PhonesWebApplication.Models;

public class ApplicationUsers : IdentityUser
{
    public Cart Cart { get; set; }
    public int CartId { get; set; }
    
}