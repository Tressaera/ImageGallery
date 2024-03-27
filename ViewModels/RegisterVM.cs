using System.ComponentModel.DataAnnotations;

namespace ImageGallery.ViewModels
{
    public class RegisterVM
    {
    [Required]
    public string? FullName {get; set;}
    [Required]
    [EmailAddress]
    public string? Email {get; set;}
    [Required]
    public string? UserName {get; set;}
    [Required]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Password must be between 8 and 15 characters, contain at least one uppercase letter, one lowercase letter, one number and one special character")]
    public string? Password {get; set;}
    [Required]
    [Compare("Password")]
    public string? ConfirmPassword { get; set; }
}
}
