using System.ComponentModel.DataAnnotations;

namespace Komunumo.Admin.Models.ManageViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "{0} 是必填的")]
        [MinLength(4, ErrorMessage = "{0} 至少需要 4 位")]
        [DataType(DataType.Password)]
        [Display(Name = "現在的密碼")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "{0} 是必填的")]
        [MinLength(4, ErrorMessage = "{0} 至少需要 4 位")]
        [DataType(DataType.Password)]
        [Display(Name = "新的密碼")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "{0} 是必填的")]
        [MinLength(4, ErrorMessage = "{0} 至少需要 4 位")]
        [DataType(DataType.Password)]
        [Display(Name = "確認新的密碼")]
        [Compare(nameof(NewPassword), ErrorMessage = "新的密碼不相符")]
        public string ConfirmPassword { get; set; }
    }
}