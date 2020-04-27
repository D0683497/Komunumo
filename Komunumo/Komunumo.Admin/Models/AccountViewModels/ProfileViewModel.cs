using System.ComponentModel.DataAnnotations;
using Komunumo.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Komunumo.Admin.Models.AccountViewModels
{
    public class ProfileViewModel
    {
        [Display(Name = "使用者名稱")]
        public string Username { get; set; }

        [Required(ErrorMessage = "{0} 是必填的")]
        [EmailAddress(ErrorMessage = "{0} 格式錯誤")]
        [Remote(nameof(AccountController.IsEmailUnique), "Account", HttpMethod = "Get", ErrorMessage = "{0} 已經被使用")]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "{0} 格式錯誤")]
        [Remote(nameof(AccountController.IsPhoneNumberUnique), "Account", HttpMethod = "Get", ErrorMessage = "{0} 已經被使用")]
        [Display(Name = "手機號碼")]
        public string PhoneNumber { get; set; }
    }
}