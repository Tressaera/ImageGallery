using Microsoft.AspNetCore.Identity;

namespace ImageGallery.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Image>? Images { get; set; }
    }
}
