using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PustokP322.DAL;
using PustokP322.Models;
using System.Threading.Tasks;

namespace PustokP322.Controllers
{
    public class EmailController : Controller
    {
        
        private readonly UserManager<AppUser> _userManager;

        public EmailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ConfirmEmail(string token , string email)
        {
            AppUser User = await _userManager.FindByEmailAsync(email);
            var result = await _userManager.ConfirmEmailAsync(User, token);

            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }
    }
}
