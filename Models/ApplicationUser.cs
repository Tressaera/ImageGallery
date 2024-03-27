using Microsoft.AspNetCore.Identity;

namespace ImageGallery.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? FullName { get; set; }
        public List<Image>? Images { get; set; }
    }
}
