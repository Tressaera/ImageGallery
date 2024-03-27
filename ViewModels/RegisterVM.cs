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
    public string? Password {get; set;}
    [Required]
    [Compare("Password")]
    public string? ConfirmPassword { get; set; }
}
}
