using System.ComponentModel.DataAnnotations;

namespace PhonesWebApplicationMVC.Models;

public class AccessoryViewModel
{
    public int Id { get; set; }
    [Required]
    [MinLength(3, ErrorMessage = "Please enter at least 3 characters")]
    public string AccessoryName { get; set; }
    public ICollection<PhoneAccessory>? PhoneAccessories { get; set; }
}