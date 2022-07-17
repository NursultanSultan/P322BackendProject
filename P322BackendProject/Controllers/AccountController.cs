using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PustokP322.Models;
using PustokP322.ViewModel;
using PustokP322.DAL;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;
using PustokP322.Helper;
using Microsoft.Extensions.Configuration;

namespace PustokP322.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<AppUser> _userManager { get; }
        private SignInManager<AppUser> _signInManager { get; }
        private RoleManager<IdentityRole> _roleManager { get; }
        private AppDbContext _context { get; }
        private IConfiguration _config { get; }

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager
            , AppDbContext context, RoleManager<IdentityRole> roleManager , IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;

            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View();

            //var isExistEmail = _userManager.FindByEmailAsync(registerVM.Email);

            //if (isExistEmail != null)
            //{
            //    ModelState.AddModelError(string.Empty, "you cannot register with this email because it is  already exist");
            //    return View();
            //}

            AppUser newUser = new AppUser
            {
                UserName = registerVM.Username,
                Email = registerVM.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, registerVM.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View();
            }


            string token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
            string ConfirmationLink = Url.Action("ConfirmEmail" , "Email" , new { token , Email = registerVM.Email} , Request.Scheme);

            EmailHelper emailHelper = new EmailHelper(_config.GetSection("ConfirmationParams:Email").Value , _config.GetSection("ConfirmationParams:Password").Value);
            var emailResult = emailHelper.SendEmail(registerVM.Email, ConfirmationLink);

            if (!emailResult)
            {
                return View(registerVM);
            }


            return RedirectToAction("Index", "Home");

        }



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM LoginVM, string ReturnUrl)
        {
            if (!ModelState.IsValid) return View();

            AppUser user = await _userManager.FindByEmailAsync(LoginVM.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Email or password is wrong");
                return View(LoginVM);
            }

            SignInResult signInResult = await _signInManager
                                                .PasswordSignInAsync(user, LoginVM.Password, LoginVM.RememberMe, true);

            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError(string.Empty, "Ged koduvu oyren sonra gel");
                return View(LoginVM);
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Email or Password is wrong");
                return View(LoginVM);
            }

           

            if (ReturnUrl != null)
            {
                return Redirect(ReturnUrl);
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Signout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}
