using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Extensions.Alerts;
using Komunumo.Admin.Models.ManageViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Komunumo.Admin.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class ManageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ManageController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        #region Index

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var model = new IndexViewModel
            {
                Username = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(IndexViewModel model)
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

            return RedirectToAction(nameof(Index)).WithSuccess("系統通知", "修改成功");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailUnique([FromQuery(Name = "Email")]string email)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user.Email == email)
            {
                return Json(true);
            }
            else if (_userManager.Users.Any(x => x.Email == email))
            {
                return Json(false);
            }

            return Json(true);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IsPhoneUnique([FromQuery(Name = "PhoneNumber")]string phone)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user.PhoneNumber == phone)
            {
                return Json(true);
            }
            else if (_userManager.Users.Any(x => x.PhoneNumber == phone))
            {
                return Json(false);
            }

            return Json(true);
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
                return View(model).WithDanger("系統通知","密碼錯誤");
            }

            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(AccountController.Login), "Account")
                .WithSuccess("系統通知", "修改密碼成功，請重新登入");
        }

        #endregion

        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        #endregion
    }
}