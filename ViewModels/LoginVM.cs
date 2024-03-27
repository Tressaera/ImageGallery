using System.ComponentModel.DataAnnotations;

namespace ImageGallery.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string? UserName { get; set; }
        public bool RememberMe { get; set; }
        [Required]
        [RegularExpression("(?=^.(8,)$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z]) (?=.*[a-z]).*$\"")]
        public string? Password{get; set;}
}
}
