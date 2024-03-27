using System.ComponentModel.DataAnnotations;

namespace ImageGallery.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string? UserName { get; set; }
        public bool RememberMe { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Password must be between 8 and 15 characters, contain at least one uppercase letter, one lowercase letter, one number and one special character")]
        public string? Password{get; set;}
}
}
