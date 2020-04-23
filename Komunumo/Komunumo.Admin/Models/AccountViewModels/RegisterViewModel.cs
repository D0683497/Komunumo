using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Komunumo.Admin.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "{0} 是必填的")]
        [EmailAddress(ErrorMessage = "{0} 格式錯誤")]
        [Remote("IsEmailUnique", "Account", ErrorMessage = "{0} 已經被使用")]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} 是必填的")]
        [Remote("IsUserNameUnique", "Account", ErrorMessage = "{0} 已經被使用")]
        [Display(Name = "使用者名稱")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} 是必填的")]
        [MinLength(4, ErrorMessage = "{0} 至少需要 4 位")]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認密碼")]
        [Compare("Password", ErrorMessage = "密碼不相符")]
        public string ConfirmPassword { get; set; }
    }
}