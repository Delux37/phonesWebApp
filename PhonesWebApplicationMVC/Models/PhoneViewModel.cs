using System.ComponentModel.DataAnnotations;

namespace PhonesWebApplicationMVC.Models;

public class PhoneViewModel
{
    public int Id { get; set; }
    [Required]
    [MinLength(2, ErrorMessage = "Please enter your phone brand name")]
    public string PhoneName { get; set; }
    public ICollection<PhoneAccessory>? PhoneAccessories { get; set; }
    public ICollection<CartPhone>? CartPhones { get; set; }
    [Required]
    public string PhoneInfo { get; set; }
    [Required]
    public decimal Price { get; set; }
}