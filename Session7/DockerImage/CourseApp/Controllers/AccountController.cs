using ASpNetCoreIdentity.Models;
using CourseApp.Constants;
using CourseApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class AccountController : Controller
    {
        readonly UserManager<IdentityUser> _manager;
        readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser> manager, SignInManager<IdentityUser> signInManager)
        {
            _manager = manager;
            _signInManager = signInManager;

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        // [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterModel user)
        {
            if (ModelState.IsValid)
            {
                var createdUser = new IdentityUser { UserName = user.Email, Email = user.Email };
                var result = await _manager.CreateAsync(createdUser, user.Password);
                if (result.Succeeded)
                {
                    await _manager.AddToRoleAsync(createdUser, Roles.User);
                    return RedirectToAction("LogIn");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }
            return View(user);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
                if (result.Succeeded)
                {
                    if(loginModel.Email=="admin@gmail.com")
                    {
                        return RedirectToAction("index", "Course");
                    }
                   else
                    {
                        return RedirectToAction("CourseList", "User");
                    }
                }
                ModelState.AddModelError("", "Login Failed");
            }
            return View(loginModel);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LogIn");
        }

    }
}