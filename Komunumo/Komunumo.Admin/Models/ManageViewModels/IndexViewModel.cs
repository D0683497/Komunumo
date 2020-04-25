using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Komunumo.Admin.Models.ManageViewModels
{
    public class IndexViewModel
    {
        [Display(Name = "使用者名稱")]
        public string Username { get; set; }

        [Required(ErrorMessage = "{0} 是必填的")]
        [EmailAddress(ErrorMessage = "{0} 格式錯誤")]
        [Remote("IsEmailUnique", "Manage", ErrorMessage = "{0} 已經被使用")]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "{0} 格式錯誤")]
        [Remote("IsPhoneUnique", "Manage", ErrorMessage = "{0} 已經被使用")]
        [Display(Name = "手機號碼")]
        public string PhoneNumber { get; set; }
    }
}