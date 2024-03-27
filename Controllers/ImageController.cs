using AspNetCoreHero.ToastNotification.Abstractions;
using ImageGallery.Data;
using ImageGallery.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    [Authorize]
    public class ImageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly INotyfService _notfyService;

        public ImageController(INotyfService notfyService, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _notfyService = notfyService;
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
