using System;
using System.Threading.Tasks;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Extensions.Alerts;
using Komunumo.Admin.Models.AccountViewModels;
using Komunumo.Admin.Repositories.Interfaces;
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
        private readonly IUserRepository _userRepository;

        public AccountController(SignInManager<ApplicationUser> signInManager, IUserRepository userRepository, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userRepository = userRepository;
            _userManager = userManager;
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

        #region Index

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region Profile

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var model = new ProfileViewModel
            {
                Username = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Profile(ProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var email = user.Email;
            if (model.Email != email)
            {
                var setEmailResult = await _userManager.SetEmailAsync(user, model.Email);
                if (!setEmailResult.Succeeded)
                {
                    throw new ApplicationException($"Unexpected error occurred setting email for user with ID '{user.Id}'.");
                }
            }

            var phoneNumber = user.PhoneNumber;
            if (model.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, model.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    throw new ApplicationException($"Unexpected error occurred setting phone number for user with ID '{user.Id}'.");
                }
            }

            return RedirectToAction(nameof(AccountController.Index), "Account")
                .WithSuccess("系統通知", "修改成功");
        }

        #endregion

        #region ChangePassword

        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                AddErrors(changePasswordResult);
                return View(model).WithDanger("系統通知", "密碼錯誤");
            }

            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(AccountController.Login), "Account")
                .WithSuccess("系統通知", "修改密碼成功，請重新登入");
        }

        #endregion

        #region Healpers

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailUnique(string email)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null) // 註冊時
            {
                if (_userRepository.ExistsEmail(email))
                {
                    return Json(false);
                }
            }
            else // 修改 Profile 時
            {
                if (user.Email != email)
                {
                    if (_userRepository.ExistsEmail(email))
                    {
                        return Json(false);
                    }
                }
            }

            return Json(true);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IsUserNameUnique(string userName)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null) // 註冊時
            {
                if (_userRepository.ExistsUserName(userName))
                {
                    return Json(false);
                }
            }
            else // 修改 Profile 時
            {
                if (user.UserName != userName)
                {
                    if (_userRepository.ExistsUserName(userName))
                    {
                        return Json(false);
                    }
                }
            }

            return Json(true);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IsPhoneNumberUnique(string phoneNumber)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null) // 註冊時
            {
                if (_userRepository.ExistsPhoneNumber(phoneNumber))
                {
                    return Json(false);
                }
            }
            else // 修改 Profile 時
            {
                if (user.PhoneNumber != phoneNumber)
                {
                    if (_userRepository.ExistsPhoneNumber(phoneNumber))
                    {
                        return Json(false);
                    }
                }
            }

            return Json(true);
        }

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