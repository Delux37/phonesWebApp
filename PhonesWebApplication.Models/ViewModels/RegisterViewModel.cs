namespace PhonesWebApplicationMVC.Models;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Password should be minimum 6 characters")]
    public string Password { get; set; }
    public string UserName { get; set; }
}