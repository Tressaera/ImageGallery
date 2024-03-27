using AspNetCoreHero.ToastNotification.Abstractions;
using ImageGallery.Models;
using ImageGallery.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly INotyfService _notfyService;

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, INotyfService notfyService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _notfyService = notfyService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }   
        [HttpPost]
        public async Task <IActionResult> Register(RegisterVM vm)
        {
            if (!ModelState.IsValid) { return View(vm); }
            if (await CheckDuplicateEmail(vm.Email!))
            {
                _notfyService.Error($"Email: {vm.Email} already exists! Please use another email");
                return View(vm);
            }
            if (await CheckDuplicateUsername(vm.UserName!))
            {
                _notfyService.Error($"Username: {vm. UserName} already exists! Please use another username");
                return View(vm);
            }
            var user = new ApplicationUser
            {
                UserName = vm.UserName,
                Email=vm.Email,
                FullName = vm.FullName,
            };
            await _userManager.CreateAsync(user, vm.Password!);
            _notfyService.Success("Your registration successful");
            return RedirectToAction(nameof(Login));
        }
        private async Task<bool> CheckDuplicateEmail(string email)
        { 
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null) 
            {
                return true;
            }
            return false;
        }
        private async Task<bool> CheckDuplicateUsername(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                return true;
            }
            return false;
        }

        }
}
