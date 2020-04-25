using System.Threading.Tasks;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Extensions.Alerts;
using Komunumo.Admin.Models.AccountViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Komunumo.Admin.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        #region Register

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.UserName, Email = model.Email };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(AccountController.Login), "Account")
                        .WithSuccess("系統通知", "註冊成功"); ;
                }
                AddErrors(result);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailUnique(string email)
        {
            var owner  = await _userManager.FindByEmailAsync(email);

            if (owner != null)
            {
                return Json(false);
            }

            return Json(true);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IsUserNameUnique(string username)
        {
            var owner = await _userManager.FindByNameAsync(username);

            if (owner != null)
            {
                return Json(false);
            }

            return Json(true);
        }

        #endregion

        #region Login

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToLocal(returnUrl)
                        .WithSuccess("系統通知", "登入成功");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "登入失敗");
                    return View(model).WithWarning("系統通知", "登入失敗");
                }
            }

            return View(model);
        }

        #endregion

        #region Logout

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home")
                .WithSuccess("系統通知", "登出成功");
        }

        #endregion

        #region Healpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}